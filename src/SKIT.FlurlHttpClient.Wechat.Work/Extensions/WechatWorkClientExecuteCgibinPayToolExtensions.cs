using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinPayToolExtensions
    {
        #region Invoice
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/paytool/get_invoice_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99436 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinPayToolGetInvoiceListResponse> ExecuteCgibinPayToolGetInvoiceListAsync(this WechatWorkClient client, Models.CgibinPayToolGetInvoiceListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "paytool", "get_invoice_list")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinPayToolGetInvoiceListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/paytool/mark_invoice_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99437 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinPayToolMarkInvoiceStatusResponse> ExecuteCgibinPayToolMarkInvoiceStatusAsync(this WechatWorkClient client, Models.CgibinPayToolMarkInvoiceStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "paytool", "mark_invoice_status")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinPayToolMarkInvoiceStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Order
        private static T PreprocessRequest<T>(WechatWorkClient client, ref T request)
            where T : Models.CgibinPayToolOrderRequestBase, new()
        {
            if (client is null) throw new ArgumentNullException(nameof(request));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.NonceString is null)
            {
                request.NonceString = Guid.NewGuid().ToString("N");
            }

            if (request.Timestamp is null)
            {
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();
            }

            if (request.Signature is null)
            {
                if (string.IsNullOrEmpty(client.Credentials.PayToolApiSecret))
                    throw new WechatWorkException("Could not sign request, because paytool API secret is missing.");

                Func<string, JToken, List<string>> flatten = default!;
                flatten = (path, token) =>
                {
                    List<string> results = new List<string>();

                    switch (token.Type)
                    {
                        case JTokenType.Null:
                            break;

                        case JTokenType.Integer:
                        case JTokenType.Float:
                        case JTokenType.String:
                            {
                                string key = path;
                                string val = token.ToString();
                                if (string.IsNullOrEmpty(key))
                                    throw new InvalidOperationException();
                                if (!string.IsNullOrEmpty(val))
                                    results.Add($"{key}={val}");
                            }
                            break;

                        case JTokenType.Boolean:
                            {
                                string key = path;
                                string val = token.ToString().ToLower();
                                if (string.IsNullOrEmpty(key))
                                    throw new InvalidOperationException();
                                results.Add($"{key}={val}");
                            }
                            break;

                        case JTokenType.Array:
                            {
                                foreach (var item in (JArray)token)
                                {
                                    results.AddRange(flatten(path, item));
                                }
                            }
                            break;

                        case JTokenType.Object:
                            { 
                                foreach (JProperty prop in ((JObject)token).Properties())
                                {
                                    results.AddRange(flatten(prop.Name, prop.Value));
                                }
                            }
                            break;

                        default:
                            throw new InvalidOperationException();
                    }

                    return results;
                };

                List<string> tmp = flatten(string.Empty, JObject.Parse(client.JsonSerializer.Serialize(request)));
                tmp.Sort(StringComparer.Ordinal);

                byte[] keyBytes = Encoding.UTF8.GetBytes(client.Credentials.PayToolApiSecret!);
                byte[] msgBytes = Encoding.UTF8.GetBytes(string.Join("&", tmp));
                byte[] signBytes = Utilities.HMACUtility.HashWithSHA256(keyBytes, msgBytes);
                request.Signature = Convert.ToBase64String(signBytes);
            }

            return request;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/paytool/open_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98045 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinPayToolOpenOrderResponse> ExecuteCgibinPayToolOpenOrderAsync(this WechatWorkClient client, Models.CgibinPayToolOpenOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "paytool", "open_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinPayToolOpenOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/paytool/close_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98046 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinPayToolCloseOrderResponse> ExecuteCgibinPayToolCloseOrderAsync(this WechatWorkClient client, Models.CgibinPayToolCloseOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "paytool", "close_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinPayToolCloseOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/paytool/get_order_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98053 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinPayToolGetOrderListResponse> ExecuteCgibinPayToolGetOrderListAsync(this WechatWorkClient client, Models.CgibinPayToolGetOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "paytool", "get_order_list")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinPayToolGetOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/paytool/get_order_detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98054 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinPayToolGetOrderDetailResponse> ExecuteCgibinPayToolGetOrderDetailAsync(this WechatWorkClient client, Models.CgibinPayToolGetOrderDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "paytool", "get_order_detail")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinPayToolGetOrderDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
