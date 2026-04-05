#nullable enable

namespace Oura
{
    public partial interface IVo2MaxRoutesClient
    {
        /// <summary>
        /// Single Vo2 Max Document
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/vO2_max/2-5daccc095220cc5493a4e9c2b681ca941e' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.VO2MaxModel> SingleVO2MaxDocumentV2UsercollectionVO2MaxDocumentIdGetAsync(
            string documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}