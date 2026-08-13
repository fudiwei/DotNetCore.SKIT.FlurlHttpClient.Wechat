using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteBrandCardExtensions
    {
        #region /Configs
        /// <summary>
        /// <para>异步调用 [POST] /brand/card/card-configs 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016249989 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBrandCardConfigResponse> ExecuteCreateBrandCardConfigAsync(this WechatTenpayClient client, Models.CreateBrandCardConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "card", "card-configs");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBrandCardConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/card/card-configs/publish 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016475176 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PublishBrandCardConfigResponse> ExecutePublishBrandCardConfigAsync(this WechatTenpayClient client, Models.PublishBrandCardConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "card", "card-configs", "publish");

            return await client.SendFlurlRequestAsJsonAsync<Models.PublishBrandCardConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/card/card-configs/cancel-applyment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016475172 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelBrandCardConfigResponse> ExecuteCancelBrandCardConfigAsync(this WechatTenpayClient client, Models.CancelBrandCardConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "card", "card-configs", "cancel-applyment");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelBrandCardConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/card/card-configs 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016475172 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandCardConfigByBusinessCodeResponse> ExecuteGetBrandCardConfigByBusinessCodeAsync(this WechatTenpayClient client, Models.GetBrandCardConfigByBusinessCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "card", "card-configs")
                .SetQueryParam("business_code", request.BusinessCode)
                .SetQueryParam("brand_id", request.BrandId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandCardConfigByBusinessCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/card/card-configs 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016475172 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandCardConfigByApplymentIdResponse> ExecuteGetBrandCardConfigByApplymentIdAsync(this WechatTenpayClient client, Models.GetBrandCardConfigByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "card", "card-configs")
                .SetQueryParam("applyment_id", request.ApplymentId)
                .SetQueryParam("brand_id", request.BrandId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandCardConfigByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/card/card-configs/preview-url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016641998 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandCardConfigPreviewUrlResponse> ExecuteGetBrandCardConfigPreviewUrlAsync(this WechatTenpayClient client, Models.GetBrandCardConfigPreviewUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "card", "card-configs", "preview-url")
                .SetQueryParam("brand_id", request.BrandId);

            if (request.BusinessCode is not null)
                flurlReq.SetQueryParam("business_code", request.BusinessCode);

            if (request.ApplymentId is not null)
                flurlReq.SetQueryParam("applyment_id", request.ApplymentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandCardConfigPreviewUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region /Links
        /// <summary>
        /// <para>异步调用 [POST] /brand/card/card-links 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016333302 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBrandCardLinkResponse> ExecuteCreateBrandCardLinkAsync(this WechatTenpayClient client, Models.CreateBrandCardLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "card", "card-links");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBrandCardLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/card/card-links/unbind-card-link 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016366804 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnbindBrandCardLinkResponse> ExecuteUnbindBrandCardLinkAsync(this WechatTenpayClient client, Models.UnbindBrandCardLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "card", "card-links", "unbind-card-link");

            return await client.SendFlurlRequestAsJsonAsync<Models.UnbindBrandCardLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/card/card-links/cancel-applyment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016366797 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelBrandCardLinkApplymentResponse> ExecuteCancelBrandCardLinkApplymentAsync(this WechatTenpayClient client, Models.CancelBrandCardLinkApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "card", "card-links", "cancel-applyment");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelBrandCardLinkApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/card/card-links 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016366785 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryBrandCardLinksResponse> ExecuteQueryBrandCardLinksAsync(this WechatTenpayClient client, Models.QueryBrandCardLinksRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "card", "card-links")
                .SetQueryParam("brand_id", request.BrandId)
                .SetQueryParam("page_index", request.Page)
                .SetQueryParam("page_size", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryBrandCardLinksResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/card/card-links/business-code/{business_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016366816 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandCardLinkByBusinessCodeResponse> ExecuteGetBrandCardLinkByBusinessCodeAsync(this WechatTenpayClient client, Models.GetBrandCardLinkByBusinessCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "card", "card-links", "business-code", request.BusinessCode)
                .SetQueryParam("brand_id", request.BrandId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandCardLinkByBusinessCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
