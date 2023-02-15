using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json.Converters;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteWxaGameExtensions
    {
        private static T PreprocessRequest<T>(WechatApiClient client, ref T request)
            where T : Models.WxaGameRequestBase, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(request));
            if (request == null) throw new ArgumentNullException(nameof(request));

            string? tmpRawData = null; // 用于缓存待签名数据中的请求正文部分，避免序列化多次浪费性能

            if (request.OfferId == null)
            {
                request.OfferId = client.Credentials.MidasOfferIdV2;
            }

            if (request.Timestamp == null)
            {
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();
            }

            if (request.SignMethod == null)
            {
                request.SignMethod = Constants.MidasSignMethods.HMAC_SHA256;
            }

            if (request.Signature == null)
            {
                tmpRawData = tmpRawData ?? client.JsonSerializer.Serialize(request);

                switch (request.SignMethod)
                {
                    case Constants.MidasSignMethods.HMAC_SHA256:
                        {
                            string msgText = tmpRawData;
                            request.Signature = Utilities.HMACUtility.HashWithSHA256(request.SessionKey ?? string.Empty, msgText).ToLower();
                        }
                        break;

                    default:
                        {
                            request.Signature = string.Empty;
                        }
                        break;
                }
            }

            if (request.PaySign == null)
            {
                tmpRawData = tmpRawData ?? client.JsonSerializer.Serialize(request);

                string msgText = $"{request.GetRequestPath()}&{tmpRawData}";
                request.PaySign = Utilities.HMACUtility.HashWithSHA256(client.Credentials.MidasAppKeyV2 ?? string.Empty, msgText).ToLower();
            }

            return request;
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/game/getbalance 接口。</para>
        /// <para>REF: https://docs.qq.com/doc/DVUN0QWJja0J5c2x4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGameGetBalanceResponse> ExecuteWxaGameGetBalanceAsync(this WechatApiClient client, Models.WxaGameGetBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "game", "getbalance")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("sig_method", request.SignMethod)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.WxaGameGetBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/game/pay 接口。</para>
        /// <para>REF: https://docs.qq.com/doc/DVUN0QWJja0J5c2x4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGamePayResponse> ExecuteWxaGamePayAsync(this WechatApiClient client, Models.WxaGamePayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "game", "pay")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("sig_method", request.SignMethod)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.WxaGamePayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/game/cancelpay 接口。</para>
        /// <para>REF: https://docs.qq.com/doc/DVUN0QWJja0J5c2x4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGameCancelPayResponse> ExecuteWxaGameCancelPayAsync(this WechatApiClient client, Models.WxaGameCancelPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "game", "cancelpay")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("sig_method", request.SignMethod)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.WxaGameCancelPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/game/present 接口。</para>
        /// <para>REF: https://docs.qq.com/doc/DVUN0QWJja0J5c2x4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGamePresentResponse> ExecuteWxaGamePresentAsync(this WechatApiClient client, Models.WxaGamePresentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "game", "present")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("sig_method", request.SignMethod)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.WxaGamePresentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
