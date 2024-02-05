using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteGoldPlanExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/changegoldplanstatus 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gold-plan/status/change-gold-plan-status.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "goldplan", "merchants", "changegoldplanstatus");

            return await client.SendFlurlRequestAsJsonAsync<Models.ChangeGoldPlanStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/changecustompagestatus 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gold-plan/status/change-custom-page-status.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "goldplan", "merchants", "changecustompagestatus");

            return await client.SendFlurlRequestAsJsonAsync<Models.ChangeGoldPlanCustomPageStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/set-advertising-industry-filter 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gold-plan/merchants/set-advertising-industry-filter.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "goldplan", "merchants", "set-advertising-industry-filter");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetGoldPlanAdvertisingIndustryFilterResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/open-advertising-show 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gold-plan/merchants/open-advertising-show.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "goldplan", "merchants", "open-advertising-show");

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenGoldPlanAdvertisingShowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goldplan/merchants/close-advertising-show 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gold-plan/merchants/close-advertising-show.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "goldplan", "merchants", "close-advertising-show");

            return await client.SendFlurlRequestAsJsonAsync<Models.CloseGoldPlanAdvertisingShowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
