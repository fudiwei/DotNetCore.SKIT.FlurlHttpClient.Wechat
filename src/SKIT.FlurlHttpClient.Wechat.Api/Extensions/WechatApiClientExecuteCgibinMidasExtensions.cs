using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinMidasExtensions
    {
        private static T InitRequest<T>(WechatApiClient client, string method, string reqLoc, ref T request)
            where T : Models.CgibinMidasRequestBase, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(request));
            if (method == null) throw new ArgumentNullException(nameof(method));
            if (reqLoc == null) throw new ArgumentNullException(nameof(reqLoc));
            if (request == null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            if (request.Timestamp == null)
            {
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();
            }

            if (request.Signature == null)
            {
                IDictionary<string, string> paramMap = new SortedDictionary<string, string>(
                    new Dictionary<string, string>()
                    {
                        { "appid", HttpUtility.UrlEncode(request.AppId ?? string.Empty) },
                        { "openid", HttpUtility.UrlEncode(request.OpenId ?? string.Empty) },
                        { "offer_id", HttpUtility.UrlEncode(request.MidasOfferId ?? string.Empty) },
                        { "zone_id", HttpUtility.UrlEncode(request.MidasZoneId ?? string.Empty) },
                        { "pf", HttpUtility.UrlEncode(request.Platform ?? string.Empty) },
                        { "ts", request.Timestamp.ToString()! }
                    }
                );
                string plainText = string.Join("&", paramMap.Select(e => $"{e.Key}={e.Value}"))
                    + $"&org_loc={reqLoc}"
                    + $"&method={method.ToUpper()}"
                    + $"&secret={client.Credentials.MidasAppKey}";
                request.Signature = Utilities.HMACUtility.HashWithSHA256(client.Credentials.MidasAppKey ?? string.Empty, plainText).ToLower();
            }

            return request;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/midas/cancelpay 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/midas.cancelPay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMidasCancelPayResponse> ExecuteCgibinMidasCancelPayAsync(this WechatApiClient client, Models.CgibinMidasCancelPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, HttpMethod.Post.Method, "/cgi-bin/midas/cancelpay", ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "midas", "cancelpay")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMidasCancelPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/midas/getbalance 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/midas.getBalance.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMidasGetBalanceResponse> ExecuteCgibinMidasGetBalanceAsync(this WechatApiClient client, Models.CgibinMidasGetBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, HttpMethod.Post.Method, "/cgi-bin/midas/getbalance", ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "midas", "getbalance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMidasGetBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/midas/pay 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/midas.pay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMidasPayResponse> ExecuteCgibinMidasPayAsync(this WechatApiClient client, Models.CgibinMidasPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, HttpMethod.Post.Method, "/cgi-bin/midas/pay", ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "midas", "pay")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMidasPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/midas/present 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/midas.present.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMidasPresentResponse> ExecuteCgibinMidasPresentAsync(this WechatApiClient client, Models.CgibinMidasPresentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, HttpMethod.Post.Method, "/cgi-bin/midas/present", ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "midas", "present")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMidasPresentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Sandbox
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/midas/sandbox/cancelpay 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/midas.cancelPay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMidasSandboxCancelPayResponse> ExecuteCgibinMidasSandboxCancelPayAsync(this WechatApiClient client, Models.CgibinMidasSandboxCancelPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, HttpMethod.Post.Method, "/cgi-bin/midas/sandbox/cancelpay", ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "midas", "sandbox", "cancelpay")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMidasSandboxCancelPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/midas/sandbox/getbalance 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/midas.getBalance.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMidasSandboxGetBalanceResponse> ExecuteCgibinMidasSandboxGetBalanceAsync(this WechatApiClient client, Models.CgibinMidasSandboxGetBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, HttpMethod.Post.Method, "/cgi-bin/midas/sandbox/getbalance", ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "midas", "sandbox", "getbalance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMidasSandboxGetBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/midas/sandbox/pay 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/midas.pay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMidasSandboxPayResponse> ExecuteCgibinMidasSandboxPayAsync(this WechatApiClient client, Models.CgibinMidasSandboxPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, HttpMethod.Post.Method, "/cgi-bin/midas/sandbox/pay", ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "midas", "sandbox", "pay")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMidasSandboxPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/midas/sandbox/present 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/midas.present.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMidasSandboxPresentResponse> ExecuteCgibinMidasSandboxPresentAsync(this WechatApiClient client, Models.CgibinMidasSandboxPresentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, HttpMethod.Post.Method, "/cgi-bin/midas/sandbox/present", ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "midas", "sandbox", "present")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMidasSandboxPresentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
