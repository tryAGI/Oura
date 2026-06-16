#nullable enable

using Microsoft.Extensions.AI;

namespace Oura;

/// <summary>
/// MEAI AIFunction tool extensions for OuraClient.
/// </summary>
public static class OuraClientTools
{
    /// <summary>
    /// Returns all available AIFunction tools for the OuraClient.
    /// </summary>
    [CLSCompliant(false)]
    public static IList<AIFunction> AsTools(this OuraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return [];
    }
}
