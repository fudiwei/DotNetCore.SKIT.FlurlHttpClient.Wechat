using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinExternalPayExtensions
    {
        #region Merchant
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/addmerchant 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93666 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPayAddMerchantResponse> ExecuteCgibinExternalPayAddMerchantAsync(this WechatWorkClient client, Models.CgibinExternalPayAddMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalpay", "addmerchant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalPayAddMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/getmerchant 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93666 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPayGetMerchantResponse> ExecuteCgibinExternalPayGetMerchantAsync(this WechatWorkClient client, Models.CgibinExternalPayGetMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalpay", "getmerchant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalPayGetMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/delmerchant 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93666 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPayDeleteMerchantResponse> ExecuteCgibinExternalPayDeleteMerchantAsync(this WechatWorkClient client, Models.CgibinExternalPayDeleteMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalpay", "delmerchant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalPayDeleteMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/set_mch_use_scope 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93666 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPaySetMerchantUseScopeResponse> ExecuteCgibinExternalPaySetMerchantUseScopeAsync(this WechatWorkClient client, Models.CgibinExternalPaySetMerchantUseScopeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalpay", "set_mch_use_scope")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalPaySetMerchantUseScopeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Bill
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/get_bill_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93667 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93727 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPayGetBillListResponse> ExecuteCgibinExternalPayGetBillListAsync(this WechatWorkClient client, Models.CgibinExternalPayGetBillListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalpay", "get_bill_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalPayGetBillListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Payment
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalpay/get_payment_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95944 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalPayGetPaymentInfoResponse> ExecuteCgibinExternalPayGetPaymentInfoAsync(this WechatWorkClient client, Models.CgibinExternalPayGetPaymentInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalpay", "get_payment_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalPayGetPaymentInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
