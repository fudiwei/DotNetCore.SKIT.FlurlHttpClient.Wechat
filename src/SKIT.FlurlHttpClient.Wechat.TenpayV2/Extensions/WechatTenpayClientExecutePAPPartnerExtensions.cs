using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePAPPartnerExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /papay/partner/preentrustweb 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPPayPartnerPreEntrustWebResponse> ExecuteCreatePAPPayPartnerPreEntrustWebAsync(this WechatTenpayClient client, Models.CreatePAPPayPartnerPreEntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Timestamp == null)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "partner", "preentrustweb");

            return await client.SendRequestWithXmlAsync<Models.CreatePAPPayPartnerPreEntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/partner/h5entrustweb 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPPayPartnerH5EntrustWebResponse> ExecuteCreatePAPPayPartnerH5EntrustWebAsync(this WechatTenpayClient client, Models.CreatePAPPayPartnerH5EntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Timestamp == null)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "papay", "partner", "h5entrustweb")
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("mch_id", request.MerchantId)
                .SetQueryParam("sub_appid", request.SubAppId)
                .SetQueryParam("sub_mch_id", request.SubMerchantId)
                .SetQueryParam("plan_id", request.PlanId)
                .SetQueryParam("contract_code", request.ContractCode)
                .SetQueryParam("request_serial", request.RequestSerialNumber)
                .SetQueryParam("contract_display_account", request.ContractDisplayAccount)
                .SetQueryParam("notify_url", request.NotifyUrl)
                .SetQueryParam("version", request.Version)
                .SetQueryParam("sign", request.Signature)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("clientip", request.ClientIp)
                .SetQueryParam("deviceid", request.DeviceId)
                .SetQueryParam("mobile", request.UserMobile)
                .SetQueryParam("email", request.UserEmail)
                .SetQueryParam("qq", request.UserQQ)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("creid", request.IDCardNumber)
                .SetQueryParam("outerid", request.OuterId)
                .SetQueryParam("return_appid", request.ReturnAppId);

            return await client.SendRequestWithXmlAsync<Models.CreatePAPPayPartnerH5EntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/partner/pappayapply 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPAPPayPartnerResponse> ExecuteApplyPAPPayPartnerAsync(this WechatTenpayClient client, Models.ApplyPAPPayPartnerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "pay", "partner", "pappayapply");

            return await client.SendRequestWithXmlAsync<Models.ApplyPAPPayPartnerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/partner/querycontract 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPPayPartnerContractResponse> ExecuteGetPAPPayPartnerContractAsync(this WechatTenpayClient client, Models.GetPAPPayPartnerContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "partner", "querycontract");

            return await client.SendRequestWithXmlAsync<Models.GetPAPPayPartnerContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
