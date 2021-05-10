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
    /// 为 <see cref="WechatTenpayClient"/> 提供微信支付分（免确认预授权模式）相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePayScorePermissionsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /payscore/permissions 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPayScorePermissionsResponse> ExecuteApplyPayScorePermissionsAsync(this WechatTenpayClient client, Models.ApplyPayScorePermissionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "payscore", "permissions")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.ApplyPayScorePermissionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/permissions/authorization-code/{authorization_code} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePermissionsByAuthorizationCodeResponse> ExecuteGetPayScorePermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.GetPayScorePermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "payscore", "permissions", "authorization-code", request.AuthorizationCode)
                .SetOptions(request)
                .SetQueryParam("service_id", request.ServiceId);

            return await client.SendRequestAsync<Models.GetPayScorePermissionsByAuthorizationCodeResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/permissions/authorization-code/{authorization_code}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePayScorePermissionsByAuthorizationCodeResponse> ExecuteTerminatePayScorePermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.TerminatePayScorePermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "payscore", "permissions", "authorization-code", request.AuthorizationCode, "terminate")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.TerminatePayScorePermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/permissions/openid/{openid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePermissionsByOpenIdResponse> ExecuteGetPayScorePermissionsByOpenIdAsync(this WechatTenpayClient client, Models.GetPayScorePermissionsByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "payscore", "permissions", "openid", request.OpenId)
                .SetOptions(request)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("service_id", request.ServiceId);

            return await client.SendRequestAsync<Models.GetPayScorePermissionsByOpenIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/permissions/openid/{openid}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePayScorePermissionsByOpenIdResponse> ExecuteTerminatePayScorePermissionsByOpenIdAsync(this WechatTenpayClient client, Models.TerminatePayScorePermissionsByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "payscore", "permissions", "openid", request.OpenId, "terminate")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.TerminatePayScorePermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
