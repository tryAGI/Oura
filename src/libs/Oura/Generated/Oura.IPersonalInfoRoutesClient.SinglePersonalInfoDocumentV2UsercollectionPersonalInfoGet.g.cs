#nullable enable

namespace Oura
{
    public partial interface IPersonalInfoRoutesClient
    {
        /// <summary>
        /// Single Personal Info Document
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/personal_info' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.PersonalInfoResponse> SinglePersonalInfoDocumentV2UsercollectionPersonalInfoGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}