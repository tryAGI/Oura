dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://cloud.ouraring.com/v2/static/json/openapi-1.30.json

# Convert OpenAPI 3.1.0 to 3.0.3 for AutoSDK compatibility + fix server URL
python3 -c "
import json, sys

with open('openapi.json') as f:
    spec = json.load(f)

# 1. Downgrade version
spec['openapi'] = '3.0.3'

# 2. Fix server URL (spec has 'https://api.None')
spec['servers'] = [{'url': 'https://api.ouraring.com', 'description': 'Oura API'}]

# 3. Convert anyOf nullable patterns to 3.0.3 style
def convert_anyof(obj):
    if isinstance(obj, dict):
        if 'anyOf' in obj:
            anyof = obj['anyOf']
            null_items = [a for a in anyof if a.get('type') == 'null']
            non_null = [a for a in anyof if a.get('type') != 'null']
            if null_items:
                if len(non_null) == 1:
                    item = non_null[0]
                    if '\$ref' in item:
                        del obj['anyOf']
                        obj['allOf'] = [item]
                        obj['nullable'] = True
                    else:
                        del obj['anyOf']
                        obj.update(item)
                        obj['nullable'] = True
                elif len(non_null) > 1:
                    obj['anyOf'] = non_null
                    obj['nullable'] = True
        for k, v in obj.items():
            convert_anyof(v)
    elif isinstance(obj, list):
        for item in obj:
            convert_anyof(item)

convert_anyof(spec)

# 4. Remove 'examples' keyword (3.1 feature) - keep 'example' (3.0)
def remove_examples(obj):
    if isinstance(obj, dict):
        if 'examples' in obj and isinstance(obj['examples'], list):
            if obj['examples']:
                obj['example'] = obj['examples'][0]
            del obj['examples']
        for k, v in list(obj.items()):
            remove_examples(v)
    elif isinstance(obj, list):
        for item in obj:
            remove_examples(item)

remove_examples(spec)

with open('openapi.json', 'w') as f:
    json.dump(spec, f, indent=2)

print('Converted to OpenAPI 3.0.3 with fixed server URL')
"

autosdk generate openapi.json \
  --namespace Oura \
  --clientClassName OuraClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
