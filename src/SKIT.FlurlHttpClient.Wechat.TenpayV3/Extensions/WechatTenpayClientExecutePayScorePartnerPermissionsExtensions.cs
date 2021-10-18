using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供微信支付分服务商（免确认模式）相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePayScorePartnerPermissionsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPayScorePartnerPermissionsResponse> ExecuteApplyPayScorePartnerPermissionsAsync(this WechatTenpayClient client, Models.ApplyPayScorePartnerPermissionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "permissions");

            return await client.SendRequestWithJsonAsync<Models.ApplyPayScorePartnerPermissionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/permissions/authorization-code/{authorization_code} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePartnerPermissionsByAuthorizationCodeResponse> ExecuteGetPayScorePartnerPermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.GetPayScorePartnerPermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "partner", "permissions", "authorization-code", request.AuthorizationCode)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScorePartnerPermissionsByAuthorizationCodeResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions/authorization-code/{authorization_code}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePayScorePartnerPermissionsByAuthorizationCodeResponse> ExecuteTerminatePayScorePartnerPermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.TerminatePayScorePartnerPermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "permissions", "authorization-code", request.AuthorizationCode, "terminate");

            return await client.SendRequestWithJsonAsync<Models.TerminatePayScorePartnerPermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/permissions/search 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePartnerPermissionsByOpenIdResponse> ExecuteGetPayScorePartnerPermissionsByOpenIdAsync(this WechatTenpayClient client, Models.GetPayScorePartnerPermissionsByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "partner", "permissions", "search")
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("sub_appid", request.SubAppId);

            if (request.OpenId != null)
                flurlReq.SetQueryParam("openid", request.OpenId);

            if (request.SubOpenId != null)
                flurlReq.SetQueryParam("sub_openid", request.SubOpenId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScorePartnerPermissionsByOpenIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePayScorePartnerPermissionsByOpenIdResponse> ExecuteTerminatePayScorePartnerPermissionsByOpenIdAsync(this WechatTenpayClient client, Models.TerminatePayScorePartnerPermissionsByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "permissions", "terminate");

            return await client.SendRequestWithJsonAsync<Models.TerminatePayScorePartnerPermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
