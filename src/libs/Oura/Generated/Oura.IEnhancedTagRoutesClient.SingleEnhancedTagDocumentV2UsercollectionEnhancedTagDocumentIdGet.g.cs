#nullable enable

namespace Oura
{
    public partial interface IEnhancedTagRoutesClient
    {
        /// <summary>
        /// Single Enhanced Tag Document
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/enhanced_tag/2-5daccc095220cc5493a4e9c2b681ca941e' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.EnhancedTagModel> SingleEnhancedTagDocumentV2UsercollectionEnhancedTagDocumentIdGetAsync(
            string documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}