using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCustomServiceExtensions
    {
        #region KfAccount
        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Service_Center_messages.html#1 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Customer_Service_Management.html#2 </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/introduction/custom.html#%E6%B7%BB%E5%8A%A0%E5%AE%A2%E6%9C%8D%E8%B4%A6%E5%8F%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountAddResponse> ExecuteCustomServiceKfAccountAddAsync(this WechatApiClient client, Models.CustomServiceKfAccountAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "customservice", "kfaccount", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfAccountAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Service_Center_messages.html#2 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Customer_Service_Management.html#4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountUpdateResponse> ExecuteCustomServiceKfAccountUpdateAsync(this WechatApiClient client, Models.CustomServiceKfAccountUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "customservice", "kfaccount", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfAccountUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Service_Center_messages.html#3 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Customer_Service_Management.html#6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountDeleteResponse> ExecuteCustomServiceKfAccountDeleteAsync(this WechatApiClient client, Models.CustomServiceKfAccountDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "customservice", "kfaccount", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfAccountDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfaccount/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/introduction/custom.html#%E5%88%A0%E9%99%A4%E5%AE%A2%E6%9C%8D%E8%B4%A6%E5%8F%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountDeleteByOpenIdResponse> ExecuteCustomServiceKfAccountDeleteByOpenIdAsync(this WechatApiClient client, Models.CustomServiceKfAccountDeleteByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "customservice", "kfaccount", "del")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_openid", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfAccountDeleteByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/uploadheadimg 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Service_Center_messages.html#4 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Customer_Service_Management.html#5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountUploadHeadImageResponse> ExecuteCustomServiceKfAccountUploadHeadImageAsync(this WechatApiClient client, Models.CustomServiceKfAccountUploadHeadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "customservice", "kfaccount", "uploadheadimg")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_account", request.KfAccount);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "image.jpg", fileBytes: request.HeadImageFileBytes, fileContentType: "image/jpeg", formDataName: "media");
            return await client.SendRequestAsync<Models.CustomServiceKfAccountUploadHeadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/inviteworker 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Customer_Service_Management.html#3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountInviteWorkerResponse> ExecuteCustomServiceKfAccountInviteWorkerAsync(this WechatApiClient client, Models.CustomServiceKfAccountInviteWorkerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "customservice", "kfaccount", "inviteworker")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfAccountInviteWorkerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfaccount/setadmin 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/introduction/custom.html#%E8%AE%BE%E7%BD%AE%E5%AE%A2%E6%9C%8D%E7%AE%A1%E7%90%86%E5%91%98 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountSetAdminByOpenIdResponse> ExecuteCustomServiceKfAccountSetAdminByOpenIdAsync(this WechatApiClient client, Models.CustomServiceKfAccountSetAdminByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "customservice", "kfaccount", "setadmin")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_openid", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfAccountSetAdminByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfaccount/canceladmin 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/introduction/custom.html#%E5%8F%96%E6%B6%88%E5%AE%A2%E6%9C%8D%E7%AE%A1%E7%90%86%E5%91%98 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountCancelAdminByOpenIdResponse> ExecuteCustomServiceKfAccountCancelAdminByOpenIdAsync(this WechatApiClient client, Models.CustomServiceKfAccountCancelAdminByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "customservice", "kfaccount", "canceladmin")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_openid", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfAccountCancelAdminByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region KfSession
        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfsession/create 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Session_control.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionCreateResponse> ExecuteCustomServiceKfSessionCreateAsync(this WechatApiClient client, Models.CustomServiceKfSessionCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "customservice", "kfsession", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfSessionCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfsession/close 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Session_control.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionCloseResponse> ExecuteCustomServiceKfSessionCloseAsync(this WechatApiClient client, Models.CustomServiceKfSessionCloseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "customservice", "kfsession", "close")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfSessionCloseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfsession/getsession 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Session_control.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionGetSessionResponse> ExecuteCustomServiceKfSessionGetSessionAsync(this WechatApiClient client, Models.CustomServiceKfSessionGetSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "customservice", "kfsession", "getsession")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfSessionGetSessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfsession/getsessionlist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Session_control.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionGetSessionListResponse> ExecuteCustomServiceKfSessionGetSessionListAsync(this WechatApiClient client, Models.CustomServiceKfSessionGetSessionListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "customservice", "kfsession", "getsessionlist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_account", request.KfAccount);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfSessionGetSessionListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfsession/getwaitcase 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Session_control.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionGetWaitCaseResponse> ExecuteCustomServiceKfSessionGetWaitCaseAsync(this WechatApiClient client, Models.CustomServiceKfSessionGetWaitCaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "customservice", "kfsession", "getwaitcase")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceKfSessionGetWaitCaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MessageRecord
        /// <summary>
        /// <para>异步调用 [POST] /customservice/msgrecord/getmsglist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Obtain_chat_transcript.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceMessageRecordGetMessageListResponse> ExecuteCustomServiceMessageRecordGetMessageListAsync(this WechatApiClient client, Models.CustomServiceMessageRecordGetMessageListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "customservice", "msgrecord", "getmsglist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomServiceMessageRecordGetMessageListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
