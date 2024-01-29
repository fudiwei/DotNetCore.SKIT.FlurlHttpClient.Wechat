using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteDonutExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /donut/code2verifyinfo 接口。</para>
        /// <para>REF: https://dev.weixin.qq.com/docs/framework/dev/openapi/code2Verifyinfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DonutCode2VerifyInfoResponse> ExecuteDonutCode2VerifyInfoAsync(this WechatApiClient client, Models.DonutCode2VerifyInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "donut", "code2verifyinfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("appid", client.Credentials.AppId)
                .SetQueryParam("appsecret", client.Credentials.AppSecret)
                .SetQueryParam("code", request.Code)
                .SetQueryParam("grant_type", request.GrantType);

            return await client.SendFlurlRequestAsJsonAsync<Models.DonutCode2VerifyInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /donut/unbindphone 接口。</para>
        /// <para>REF: https://dev.weixin.qq.com/docs/framework/dev/openapi/unbindphone.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DonutUnbindPhoneResponse> ExecuteDonutUnbindPhoneAsync(this WechatApiClient client, Models.DonutUnbindPhoneRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "donut", "unbindphone")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DonutUnbindPhoneResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /donut/unbindweixin 接口。</para>
        /// <para>REF: https://dev.weixin.qq.com/docs/framework/dev/openapi/unbindweixin.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DonutUnbindWeixinResponse> ExecuteDonutUnbindWeixinAsync(this WechatApiClient client, Models.DonutUnbindWeixinRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "donut", "unbindweixin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DonutUnbindWeixinResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /donut/unbindapple 接口。</para>
        /// <para>REF: https://dev.weixin.qq.com/docs/framework/dev/openapi/unbindapple.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DonutUnbindAppleResponse> ExecuteDonutUnbindAppleAsync(this WechatApiClient client, Models.DonutUnbindAppleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "donut", "unbindapple")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DonutUnbindAppleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /donut/unregisteruser 接口。</para>
        /// <para>REF: https://dev.weixin.qq.com/docs/framework/dev/openapi/unregisteruser.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DonutUnregisterUserResponse> ExecuteDonutUnregisterUserAsync(this WechatApiClient client, Models.DonutUnregisterUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "donut", "unregisteruser")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DonutUnregisterUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
