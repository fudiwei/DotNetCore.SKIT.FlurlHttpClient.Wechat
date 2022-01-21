using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供点金计划相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteGoldPlanExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/changegoldplanstatus 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_5_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChangeGoldPlanStatusResponse> ExecuteChangeGoldPlanStatusAsync(this WechatTenpayClient client, Models.ChangeGoldPlanStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "goldplan", "merchants", "changegoldplanstatus");

            return await client.SendRequestWithJsonAsync<Models.ChangeGoldPlanStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/changecustompagestatus 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_5_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChangeGoldPlanCustomPageStatusResponse> ExecuteChangeGoldPlanCustomPageStatusAsync(this WechatTenpayClient client, Models.ChangeGoldPlanCustomPageStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "goldplan", "merchants", "changecustompagestatus");

            return await client.SendRequestWithJsonAsync<Models.ChangeGoldPlanCustomPageStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/set-advertising-industry-filter 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_5_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetGoldPlanAdvertisingIndustryFilterResponse> ExecuteSetGoldPlanAdvertisingIndustryFilterAsync(this WechatTenpayClient client, Models.SetGoldPlanAdvertisingIndustryFilterRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "goldplan", "merchants", "set-advertising-industry-filter");

            return await client.SendRequestWithJsonAsync<Models.SetGoldPlanAdvertisingIndustryFilterResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/open-advertising-show 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_5_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenGoldPlanAdvertisingShowResponse> ExecuteOpenGoldPlanAdvertisingShowAsync(this WechatTenpayClient client, Models.OpenGoldPlanAdvertisingShowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "goldplan", "merchants", "open-advertising-show");

            return await client.SendRequestWithJsonAsync<Models.OpenGoldPlanAdvertisingShowResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/close-advertising-show 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_5_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CloseGoldPlanAdvertisingShowResponse> ExecuteCloseGoldPlanAdvertisingShowAsync(this WechatTenpayClient client, Models.CloseGoldPlanAdvertisingShowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "goldplan", "merchants", "close-advertising-show");

            return await client.SendRequestWithJsonAsync<Models.CloseGoldPlanAdvertisingShowResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
