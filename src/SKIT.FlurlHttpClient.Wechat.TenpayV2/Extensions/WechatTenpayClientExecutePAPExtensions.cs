using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePAPExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /papay/preentrustweb 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPPayPreEntrustWebResponse> ExecuteCreatePAPPayPreEntrustWebAsync(this WechatTenpayClient client, Models.CreatePAPPayPreEntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Timestamp == null)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "preentrustweb");

            return await client.SendRequestWithXmlAsync<Models.CreatePAPPayPreEntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/h5entrustweb 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPPayH5EntrustWebResponse> ExecuteCreatePAPPayH5EntrustWebAsync(this WechatTenpayClient client, Models.CreatePAPPayH5EntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Timestamp == null)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "papay", "h5entrustweb");

            return await client.SendRequestWithXmlAsync<Models.CreatePAPPayH5EntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
