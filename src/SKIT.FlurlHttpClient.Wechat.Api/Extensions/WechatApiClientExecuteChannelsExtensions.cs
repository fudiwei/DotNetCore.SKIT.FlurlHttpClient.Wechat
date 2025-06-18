using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteChannelsExtensions
    {
        #region ECActivity
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/activity/del 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/giftactivity/del.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECActivityDeleteResponse> ExecuteChannelsECActivityDeleteAsync(this WechatApiClient client, Models.ChannelsECActivityDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "activity", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECActivityDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/activity/stop 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/giftactivity/shop.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECActivityStopResponse> ExecuteChannelsECActivityStopAsync(this WechatApiClient client, Models.ChannelsECActivityStopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "activity", "stop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECActivityStopResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECAftersale
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/genaftersaleorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/genaftersaleorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGenerateAftersaleOrderResponse> ExecuteChannelsECAftersaleGenerateAftersaleOrderAsync(this WechatApiClient client, Models.ChannelsECAftersaleGenerateAftersaleOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "genaftersaleorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGenerateAftersaleOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getaftersalelist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/getaftersalelist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/getaftersalelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGetAftersaleListResponse> ExecuteChannelsECAftersaleGetAftersaleListAsync(this WechatApiClient client, Models.ChannelsECAftersaleGetAftersaleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getaftersalelist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGetAftersaleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getaftersaleorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/getaftersaleorder.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/query_after-sales.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/getaftersaleorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGetAftersaleOrderResponse> ExecuteChannelsECAftersaleGetAftersaleOrderAsync(this WechatApiClient client, Models.ChannelsECAftersaleGetAftersaleOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getaftersaleorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGetAftersaleOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/acceptapply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/acceptapply.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/acceptapply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleAcceptApplyResponse> ExecuteChannelsECAftersaleAcceptApplyAsync(this WechatApiClient client, Models.ChannelsECAftersaleAcceptApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "acceptapply")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleAcceptApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/rejectapply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/rejectapply.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/rejectapply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleRejectApplyResponse> ExecuteChannelsECAftersaleRejectApplyAsync(this WechatApiClient client, Models.ChannelsECAftersaleRejectApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "rejectapply")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleRejectApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/acceptexchangereship 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/acceptexchangereship.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleAcceptExchangeReshipResponse> ExecuteChannelsECAftersaleAcceptExchangeReshipAsync(this WechatApiClient client, Models.ChannelsECAftersaleAcceptExchangeReshipRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "acceptexchangereship")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleAcceptExchangeReshipResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/rejectexchangereship 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/rejectexchangereship.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleRejectExchangeReshipResponse> ExecuteChannelsECAftersaleRejectExchangeReshipAsync(this WechatApiClient client, Models.ChannelsECAftersaleRejectExchangeReshipRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "rejectexchangereship")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleRejectExchangeReshipResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/merchantupdateaftersale 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/merchantupdateaftersale.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleMerchantUpdateAftersaleResponse> ExecuteChannelsECAftersaleMerchantUpdateAftersaleAsync(this WechatApiClient client, Models.ChannelsECAftersaleMerchantUpdateAftersaleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "merchantupdateaftersale")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleMerchantUpdateAftersaleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/uploadrefundcertificate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/uploadrefundcertificate.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/uploadrefundcertificate.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleUploadRefundCertificateResponse> ExecuteChannelsECAftersaleUploadRefundCertificateAsync(this WechatApiClient client, Models.ChannelsECAftersaleUploadRefundCertificateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "uploadrefundcertificate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleUploadRefundCertificateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECAftersale/Complaint
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/addcomplaintmaterial 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/complaint/addcomplaintmaterial.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/complaint/addcomplaintmaterial.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleAddComplaintMaterialResponse> ExecuteChannelsECAftersaleAddComplaintMaterialAsync(this WechatApiClient client, Models.ChannelsECAftersaleAddComplaintMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "addcomplaintmaterial")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleAddComplaintMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/addcomplaintproof 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/complaint/addcomplaintproof.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/complaint/addcomplaintproof.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleAddComplaintProofResponse> ExecuteChannelsECAftersaleAddComplaintProofAsync(this WechatApiClient client, Models.ChannelsECAftersaleAddComplaintProofRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "addcomplaintproof")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleAddComplaintProofResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getcomplaintorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/complaint/getcomplaintorder.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/complaint/getcomplaintorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGetComplaintOrderResponse> ExecuteChannelsECAftersaleGetComplaintOrderAsync(this WechatApiClient client, Models.ChannelsECAftersaleGetComplaintOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getcomplaintorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGetComplaintOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECAftersale/GuaranteeOrder
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/searchguaranteeorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/searchguaranteeorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleSearchGuaranteeOrderResponse> ExecuteChannelsECAftersaleSearchGuaranteeOrderAsync(this WechatApiClient client, Models.ChannelsECAftersaleSearchGuaranteeOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "searchguaranteeorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleSearchGuaranteeOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getguaranteeorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/getguaranteeorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGetGuaranteeOrderResponse> ExecuteChannelsECAftersaleGetGuaranteeOrderAsync(this WechatApiClient client, Models.ChannelsECAftersaleGetGuaranteeOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getguaranteeorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGetGuaranteeOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/merchantacceptguarantee 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/merchantacceptguarantee.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleMerchantAcceptGuaranteeResponse> ExecuteChannelsECAftersaleMerchantAcceptGuaranteeAsync(this WechatApiClient client, Models.ChannelsECAftersaleMerchantAcceptGuaranteeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "merchantacceptguarantee")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleMerchantAcceptGuaranteeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/merchantrefuseguarantee 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/merchantrefuseguarantee.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleMerchantRefuseGuaranteeResponse> ExecuteChannelsECAftersaleMerchantRefuseGuaranteeAsync(this WechatApiClient client, Models.ChannelsECAftersaleMerchantRefuseGuaranteeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "merchantrefuseguarantee")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleMerchantRefuseGuaranteeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/merchantmodifyguarantee 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/merchantmodifyguarantee.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleMerchantModifyGuaranteeResponse> ExecuteChannelsECAftersaleMerchantModifyGuaranteeAsync(this WechatApiClient client, Models.ChannelsECAftersaleMerchantModifyGuaranteeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "merchantmodifyguarantee")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleMerchantModifyGuaranteeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/merchantproofguarantee 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/merchantproofguarantee.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleMerchantProofGuaranteeResponse> ExecuteChannelsECAftersaleMerchantProofGuaranteeAsync(this WechatApiClient client, Models.ChannelsECAftersaleMerchantProofGuaranteeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "merchantproofguarantee")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleMerchantProofGuaranteeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECAftersale/Present
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getpresentaftersalelist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/getpresentaftersalelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGetPresentAftersaleListResponse> ExecuteChannelsECAftersaleGetPresentAftersaleListAsync(this WechatApiClient client, Models.ChannelsECAftersaleGetPresentAftersaleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getpresentaftersalelist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGetPresentAftersaleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getpresentaftersaleorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/getpresentaftersaleorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGetPresentAftersaleOrderResponse> ExecuteChannelsECAftersaleGetPresentAftersaleOrderAsync(this WechatApiClient client, Models.ChannelsECAftersaleGetPresentAftersaleOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getpresentaftersaleorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGetPresentAftersaleOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECAftersale/Reason
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/reason/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/getaftersalereason.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/getaftersalereason.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleReasonGetResponse> ExecuteChannelsECAftersaleReasonGetAsync(this WechatApiClient client, Models.ChannelsECAftersaleReasonGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "reason", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleReasonGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/rejectreason/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/getrejectreason.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/getrejectreason.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleRejectReasonGetResponse> ExecuteChannelsECAftersaleRejectReasonGetAsync(this WechatApiClient client, Models.ChannelsECAftersaleRejectReasonGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "rejectreason", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleRejectReasonGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECAftersale/VirtualTelNumber
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/applyvirtualtelnum 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/applyvirtualtelnumber.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleApplyVirtualTelNumberResponse> ExecuteChannelsECAftersaleApplyVirtualTelNumberAsync(this WechatApiClient client, Models.ChannelsECAftersaleApplyVirtualTelNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "applyvirtualtelnum")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleApplyVirtualTelNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECBasics
        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/basics/info/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/getbasicinfo.html ]]>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/basics/getbasicinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsInfoGetResponse> ExecuteChannelsECBasicsInfoGetAsync(this WechatApiClient client, Models.ChannelsECBasicsInfoGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "basics", "info", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsInfoGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/img/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/img_upload.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/basics/img_upload.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsImageUploadResponse> ExecuteChannelsECBasicsImageUploadAsync(this WechatApiClient client, Models.ChannelsECBasicsImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "img", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("resp_type", request.ResponseType);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("upload_type", 1)
                        .SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsImageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                flurlReq.SetQueryParam("upload_type", 0)
                        .SetQueryParam("height", request.Height)
                        .SetQueryParam("width", request.Width);

                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes!, fileContentType: "image/png", formDataName: "media");
                return await client.SendFlurlRequestAsync<Models.ChannelsECBasicsImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/qualification/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/qualificationupload.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/basics/qualificationupload.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsQualificationUploadResponse> ExecuteChannelsECBasicsQualificationUploadAsync(this WechatApiClient client, Models.ChannelsECBasicsQualificationUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileContentType is null)
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName!);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "qualification", "upload")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.ChannelsECBasicsQualificationUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/addresscode/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/getaddresscode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/basics/getaddresscode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsAddressCodeGetResponse> ExecuteChannelsECBasicsAddressCodeGetAsync(this WechatApiClient client, Models.ChannelsECBasicsAddressCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "addresscode", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsAddressCodeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/basics/media/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/getdatabymediaid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsMediaGetResponse> ExecuteChannelsECBasicsMediaGetAsync(this WechatApiClient client, Models.ChannelsECBasicsMediaGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "basics", "media", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsMediaGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECBasics/HomepageBackground
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/homepage/background/apply/submit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/background/submit_background_apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsHomepageBackgroundApplySubmitResponse> ExecuteChannelsECBasicsHomepageBackgroundApplySubmitAsync(this WechatApiClient client, Models.ChannelsECBasicsHomepageBackgroundApplySubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "homepage", "background", "apply", "submit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsHomepageBackgroundApplySubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/homepage/background/apply/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/background/cancel_background_apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsHomepageBackgroundApplyCancelResponse> ExecuteChannelsECBasicsHomepageBackgroundApplyCancelAsync(this WechatApiClient client, Models.ChannelsECBasicsHomepageBackgroundApplyCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "homepage", "background", "apply", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsHomepageBackgroundApplyCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/homepage/background/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/background/get_background.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsHomepageBackgroundGetResponse> ExecuteChannelsECBasicsHomepageBackgroundGetAsync(this WechatApiClient client, Models.ChannelsECBasicsHomepageBackgroundGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "homepage", "background", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsHomepageBackgroundGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/homepage/background/remove 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/background/remove_background.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsHomepageBackgroundRemoveResponse> ExecuteChannelsECBasicsHomepageBackgroundRemoveAsync(this WechatApiClient client, Models.ChannelsECBasicsHomepageBackgroundRemoveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "homepage", "background", "remove")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsHomepageBackgroundRemoveResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECBasics/HomepageBanner
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/homepage/banner/apply/submit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/banner/submit_banner_apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsHomepageBannerApplySubmitResponse> ExecuteChannelsECBasicsHomepageBannerApplySubmitAsync(this WechatApiClient client, Models.ChannelsECBasicsHomepageBannerApplySubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "homepage", "banner", "apply", "submit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsHomepageBannerApplySubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/homepage/banner/apply/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/banner/cancel_banner_apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsHomepageBannerApplyCancelResponse> ExecuteChannelsECBasicsHomepageBannerApplyCancelAsync(this WechatApiClient client, Models.ChannelsECBasicsHomepageBannerApplyCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "homepage", "banner", "apply", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsHomepageBannerApplyCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/homepage/banner/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/banner/get_banner.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsHomepageBannerGetResponse> ExecuteChannelsECBasicsHomepageBannerGetAsync(this WechatApiClient client, Models.ChannelsECBasicsHomepageBannerGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "homepage", "banner", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsHomepageBannerGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/homepage/banner/remove 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/banner/remove_banner.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsHomepageBannerRemoveResponse> ExecuteChannelsECBasicsHomepageBannerRemoveAsync(this WechatApiClient client, Models.ChannelsECBasicsHomepageBannerRemoveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "homepage", "banner", "remove")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsHomepageBannerRemoveResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECBasics/Shop
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/shop/h5url/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/basics/getshoph5url.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsShopH5UrlGetResponse> ExecuteChannelsECBasicsShopH5UrlGetAsync(this WechatApiClient client, Models.ChannelsECBasicsShopH5UrlGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "shop", "h5url", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsShopH5UrlGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/shop/taglink/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/basics/getshoptaglink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsShopTagLinkGetResponse> ExecuteChannelsECBasicsShopTagLinkGetAsync(this WechatApiClient client, Models.ChannelsECBasicsShopTagLinkGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "shop", "taglink", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsShopTagLinkGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/shop/qrcode/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/basics/getshopqrcode.html ]]>
        /// </para> 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsShopQrcodeGetResponse> ExecuteChannelsECBasicsShopQrcodeGetAsync(this WechatApiClient client, Models.ChannelsECBasicsShopQrcodeGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "shop", "qrcode", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsShopQrcodeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECBrand
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/all 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/all_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/all_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandAllResponse> ExecuteChannelsECBrandAllAsync(this WechatApiClient client, Models.ChannelsECBrandAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/add.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandAddResponse> ExecuteChannelsECBrandAddAsync(this WechatApiClient client, Models.ChannelsECBrandAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/update.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandUpdateResponse> ExecuteChannelsECBrandUpdateAsync(this WechatApiClient client, Models.ChannelsECBrandUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/audit/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/audit_cancel.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/audit_cancel.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandAuditCancelResponse> ExecuteChannelsECBrandAuditCancelAsync(this WechatApiClient client, Models.ChannelsECBrandAuditCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/delete.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/delete.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandDeleteResponse> ExecuteChannelsECBrandDeleteAsync(this WechatApiClient client, Models.ChannelsECBrandDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandGetResponse> ExecuteChannelsECBrandGetAsync(this WechatApiClient client, Models.ChannelsECBrandGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/list_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandListGetResponse> ExecuteChannelsECBrandListGetAsync(this WechatApiClient client, Models.ChannelsECBrandListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/valid/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/valid_list_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/valid_list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandValidListGetResponse> ExecuteChannelsECBrandValidListGetAsync(this WechatApiClient client, Models.ChannelsECBrandValidListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "valid", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandValidListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECCategory
        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/category/all 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/getallcategory.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category/getallcategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAllResponse> ExecuteChannelsECCategoryAllAsync(this WechatApiClient client, Models.ChannelsECCategoryAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "category", "all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/category/league/all 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/basic/category/getallcategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryLeagueAllResponse> ExecuteChannelsECCategoryLeagueAllAsync(this WechatApiClient client, Models.ChannelsECCategoryLeagueAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "category", "league", "all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryLeagueAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/getcategorydetail.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category/getcategorydetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryDetailResponse> ExecuteChannelsECCategoryDetailAsync(this WechatApiClient client, Models.ChannelsECCategoryDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/availablesoncategories/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/getavailablesoncategories.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category/getavailablesoncategories.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAvailableSonCategoriesGetResponse> ExecuteChannelsECCategoryAvailableSonCategoriesGetAsync(this WechatApiClient client, Models.ChannelsECCategoryAvailableSonCategoriesGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "availablesoncategories", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAvailableSonCategoriesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/add.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAddResponse> ExecuteChannelsECCategoryAddAsync(this WechatApiClient client, Models.ChannelsECCategoryAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/audit/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/audit_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category/audit_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAuditGetResponse> ExecuteChannelsECCategoryAuditGetAsync(this WechatApiClient client, Models.ChannelsECCategoryAuditGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "audit", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAuditGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/audit/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/cancelauditcategory.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category/cancelauditcategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAuditCancelResponse> ExecuteChannelsECCategoryAuditCancelAsync(this WechatApiClient client, Models.ChannelsECCategoryAuditCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/category/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/getavailablebizcat.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category/getavailablebizcat.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryListGetResponse> ExecuteChannelsECCategoryListGetAsync(this WechatApiClient client, Models.ChannelsECCategoryListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "category", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECCommonKf
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/commkf/cosupload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/kf/upload_cos/upload_cos_api.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCommonKfCosUploadResponse> ExecuteChannelsECCommonKfCosUploadAsync(this WechatApiClient client, Models.ChannelsECCommonKfCosUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
            {
                if ("image".Equals(request.FileType))
                    request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";
                else if ("video".Equals(request.FileType))
                    request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".mp4";
                else
                    request.FileName = Guid.NewGuid().ToString("N").ToLower();
            }

            if (request.FileContentType is null)
            {
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName!);
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "commkf", "cosupload")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes!, fileContentType: request.FileContentType, formDataName: "file");
            httpContent.Add(new StringContent(request.FileType), "msg_type");
            httpContent.Add(new StringContent(request.OpenId), "open_id");
            return await client.SendFlurlRequestAsync<Models.ChannelsECCommonKfCosUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/commkf/sendmsg 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/kf/send_msg/send_msg_api.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCommonKfSendMessageResponse> ExecuteChannelsECCommonKfSendMessageAsync(this WechatApiClient client, Models.ChannelsECCommonKfSendMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "commkf", "sendmsg")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCommonKfSendMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECCompass
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/overall/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/getshopoverall.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/getshopoverall.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopOverallGetResponse> ExecuteChannelsECCompassShopOverallGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopOverallGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "overall", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopOverallGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/finder/authorization/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/get_finder_authorization_list.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/get_finder_authorization_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopFinderAuthorizationListGetResponse> ExecuteChannelsECCompassShopFinderAuthorizationListGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopFinderAuthorizationListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "finder", "authorization", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopFinderAuthorizationListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/finder/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/getshopfinderlist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/getshopfinderlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopFinderListGetResponse> ExecuteChannelsECCompassShopFinderListGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopFinderListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "finder", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopFinderListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/finder/overall/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/getshopfinderoverall.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/getshopfinderoverall.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopFinderOverallGetResponse> ExecuteChannelsECCompassShopFinderOverallGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopFinderOverallGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "finder", "overall", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopFinderOverallGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/finder/product/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/getshopfinderproductlist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/getshopfinderproductlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopFinderProductListGetResponse> ExecuteChannelsECCompassShopFinderProductListGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopFinderProductListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "finder", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopFinderProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/finder/product/overall/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/getshopfinderproductoverall.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/getshopfinderproductoverall.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopFinderProductOverallGetResponse> ExecuteChannelsECCompassShopFinderProductOverallGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopFinderProductOverallGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "finder", "product", "overall", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopFinderProductOverallGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/live/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/getshoplivelist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/getshoplivelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopLiveListGetResponse> ExecuteChannelsECCompassShopLiveListGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopLiveListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "live", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopLiveListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/product/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/getshopproductlist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/getshopproductlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopProductListGetResponse> ExecuteChannelsECCompassShopProductListGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopProductListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/product/data/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/getshopproductdata.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/getshopproductdata.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopProductDataGetResponse> ExecuteChannelsECCompassShopProductDataGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopProductDataGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "product", "data", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopProductDataGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/shop/sale/profile/data/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/shop/getshopsaleprofiledata.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/compass/shop/getshopsaleprofiledata.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassShopSaleProfileDataGetResponse> ExecuteChannelsECCompassShopSaleProfileDataGetAsync(this WechatApiClient client, Models.ChannelsECCompassShopSaleProfileDataGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "shop", "sale", "profile", "data", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassShopSaleProfileDataGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/finder/overall/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/finder/getfinderoverall.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassFinderOverallGetResponse> ExecuteChannelsECCompassFinderOverallGetAsync(this WechatApiClient client, Models.ChannelsECCompassFinderOverallGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "finder", "overall", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassFinderOverallGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/finder/product/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/finder/getfinderproductlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassFinderProductListGetResponse> ExecuteChannelsECCompassFinderProductListGetAsync(this WechatApiClient client, Models.ChannelsECCompassFinderProductListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "finder", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassFinderProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/finder/product/data/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/finder/getfinderproductdata.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassFinderProductDataGetResponse> ExecuteChannelsECCompassFinderProductDataGetAsync(this WechatApiClient client, Models.ChannelsECCompassFinderProductDataGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "finder", "product", "data", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassFinderProductDataGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/compass/finder/sale/profile/data/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/compass/finder/getfindersaleprofiledata.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCompassFinderSaleProfileDataGetResponse> ExecuteChannelsECCompassFinderSaleProfileDataGetAsync(this WechatApiClient client, Models.ChannelsECCompassFinderSaleProfileDataGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "compass", "finder", "sale", "profile", "data", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCompassFinderSaleProfileDataGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECCooperation
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/cooperation/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/cooperation/list_sharer.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCooperationListResponse> ExecuteChannelsECCooperationListAsync(this WechatApiClient client, Models.ChannelsECCooperationListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "cooperation", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCooperationListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/cooperation/shop/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/cooperation_shop/list_shop.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCooperationShopListResponse> ExecuteChannelsECCooperationShopListAsync(this WechatApiClient client, Models.ChannelsECCooperationShopListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "cooperation", "shop", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCooperationShopListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/cooperation/product/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/cooperation_shop/list_cooperation_shop_product.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCooperationProductListResponse> ExecuteChannelsECCooperationProductListAsync(this WechatApiClient client, Models.ChannelsECCooperationProductListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "cooperation", "product", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCooperationProductListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/cooperation/product/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/cooperation_shop/get_product.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCooperationProductGetResponse> ExecuteChannelsECCooperationProductGetAsync(this WechatApiClient client, Models.ChannelsECCooperationProductGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "cooperation", "product", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCooperationProductGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/cooperation/order/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/cooperation_shop/get_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCooperationOrderGetResponse> ExecuteChannelsECCooperationOrderGetAsync(this WechatApiClient client, Models.ChannelsECCooperationOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "cooperation", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCooperationOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECCooperation/Invitation
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/cooperation/invitation/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/cooperation/cancel_invitation.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCooperationInvitationCancelResponse> ExecuteChannelsECCooperationInvitationCancelAsync(this WechatApiClient client, Models.ChannelsECCooperationInvitationCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "cooperation", "invitation", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCooperationInvitationCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/cooperation/invitation/unbind 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/cooperation/unbind.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCooperationInvitationUnbindResponse> ExecuteChannelsECCooperationInvitationUnbindAsync(this WechatApiClient client, Models.ChannelsECCooperationInvitationUnbindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "cooperation", "invitation", "unbind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCooperationInvitationUnbindResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/cooperation/invitation/qrcode/generate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/cooperation/generate_invitation_qrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCooperationInvitationQrcodeGenerateResponse> ExecuteChannelsECCooperationInvitationQrcodeGenerateAsync(this WechatApiClient client, Models.ChannelsECCooperationInvitationQrcodeGenerateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "cooperation", "invitation", "qrcode", "generate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCooperationInvitationQrcodeGenerateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/cooperation/invitation/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/cooperation/generate_invitation_qrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCooperationInvitationGetResponse> ExecuteChannelsECCooperationInvitationGetAsync(this WechatApiClient client, Models.ChannelsECCooperationInvitationGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "cooperation", "invitation", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCooperationInvitationGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECCoupon
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/create.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/coupon/create.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponCreateResponse> ExecuteChannelsECCouponCreateAsync(this WechatApiClient client, Models.ChannelsECCouponCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/update.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/coupon/update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponUpdateResponse> ExecuteChannelsECCouponUpdateAsync(this WechatApiClient client, Models.ChannelsECCouponUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/update_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/update_status.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/coupon/update_status.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponUpdateStatusResponse> ExecuteChannelsECCouponUpdateStatusAsync(this WechatApiClient client, Models.ChannelsECCouponUpdateStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "update_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponUpdateStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/coupon/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponGetResponse> ExecuteChannelsECCouponGetAsync(this WechatApiClient client, Models.ChannelsECCouponGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/get_list.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/coupon/get_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponGetListResponse> ExecuteChannelsECCouponGetListAsync(this WechatApiClient client, Models.ChannelsECCouponGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get_user_coupon_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/get_user_coupon_list.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/coupon/get_user_coupon_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponGetUserCouponListResponse> ExecuteChannelsECCouponGetUserCouponListAsync(this WechatApiClient client, Models.ChannelsECCouponGetUserCouponListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get_user_coupon_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponGetUserCouponListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get_user_coupon 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/get_user_coupon.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/coupon/get_user_coupon.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponGetUserCouponResponse> ExecuteChannelsECCouponGetUserCouponAsync(this WechatApiClient client, Models.ChannelsECCouponGetUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get_user_coupon")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponGetUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECFinderLive
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/finderlive/getfinderliverecordlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/getfinderliverecordlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ECFinderLiveGetFinderLiveRecordListResponse> ExecuteECFinderLiveGetFinderLiveRecordListAsync(this WechatApiClient client, Models.ECFinderLiveGetFinderLiveRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "finderlive", "getfinderliverecordlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ECFinderLiveGetFinderLiveRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/finderlive/getfinderlivenoticerecordlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/getfinderlivenoticerecordlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ECFinderLiveGetFinderLiveNoticeRecordListResponse> ExecuteECFinderLiveGetFinderLiveNoticeRecordListAsync(this WechatApiClient client, Models.ECFinderLiveGetFinderLiveNoticeRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "finderlive", "getfinderlivenoticerecordlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ECFinderLiveGetFinderLiveNoticeRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECFunds
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getbalance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getbalance.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/getbalance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsGetBalanceResponse> ExecuteChannelsECFundsGetBalanceAsync(this WechatApiClient client, Models.ChannelsECFundsGetBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getbalance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsGetBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getfundsflowlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getfundsflowlist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/Fund.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/getfundsflowlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsGetFundsFlowListResponse> ExecuteChannelsECFundsGetFundsFlowListAsync(this WechatApiClient client, Models.ChannelsECFundsGetFundsFlowListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getfundsflowlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsGetFundsFlowListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getfundsflowdetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getfundsflowdetail.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/getfundsflowdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsGetFundsFlowDetailResponse> ExecuteChannelsECFundsGetFundsFlowDetailAsync(this WechatApiClient client, Models.ChannelsECFundsGetFundsFlowDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getfundsflowdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsGetFundsFlowDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECFunds/BankAccount
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getbankacct 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getbankacct.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/getbankacct.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsGetBankAccountResponse> ExecuteChannelsECFundsGetBankAccountAsync(this WechatApiClient client, Models.ChannelsECFundsGetBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getbankacct")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsGetBankAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/setbankacct 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/setbankacct.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/setbankacct.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsSetBankAccountResponse> ExecuteChannelsECFundsSetBankAccountAsync(this WechatApiClient client, Models.ChannelsECFundsSetBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "setbankacct")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsSetBankAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECFunds/Withdraw
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getwithdrawdetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getwithdrawdetail.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/getwithdrawdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECGetWithdrawDetailResponse> ExecuteChannelsECGetWithdrawDetailAsync(this WechatApiClient client, Models.ChannelsECGetWithdrawDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getwithdrawdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECGetWithdrawDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getwithdrawlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getwithdrawlist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/getwithdrawlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECGetWithdrawListResponse> ExecuteChannelsECGetWithdrawListAsync(this WechatApiClient client, Models.ChannelsECGetWithdrawListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getwithdrawlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECGetWithdrawListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/submitwithdraw 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/submitwithdraw.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/submitwithdraw.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsSubmitWithdrawResponse> ExecuteChannelsECFundsSubmitWithdrawAsync(this WechatApiClient client, Models.ChannelsECFundsSubmitWithdrawRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "submitwithdraw")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsSubmitWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECLeague
        #region ECLeague/Funds
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/funds/getfundsflowdetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getfundsflowdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueFundsGetFundsFlowDetailResponse> ExecuteChannelsECLeagueFundsGetFundsFlowDetailAsync(this WechatApiClient client, Models.ChannelsECLeagueFundsGetFundsFlowDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "funds", "getfundsflowdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueFundsGetFundsFlowDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/funds/getfundsflowlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getfundsflowlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueFundsGetFundsFlowListResponse> ExecuteChannelsECLeagueFundsGetFundsFlowListAsync(this WechatApiClient client, Models.ChannelsECLeagueFundsGetFundsFlowListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "funds", "getfundsflowlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueFundsGetFundsFlowListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier
        #region ECLeague/HeadSupplier/Clue
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/clue/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/clue/getcluelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierClueListGetResponse> ExecuteChannelsECLeagueHeadSupplierClueListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierClueListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "clue", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierClueListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/clue/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/clue/getclue.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierClueGetResponse> ExecuteChannelsECLeagueHeadSupplierClueGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierClueGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "clue", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierClueGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/CooperativeItem
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/cooperativeitem/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/addcooperativeitem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierCooperativeItemAddResponse> ExecuteChannelsECLeagueHeadSupplierCooperativeItemAddAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierCooperativeItemAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "cooperativeitem", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierCooperativeItemAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/cooperativeitem/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getcooperativeitemlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierCooperativeItemListGetResponse> ExecuteChannelsECLeagueHeadSupplierCooperativeItemListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierCooperativeItemListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "cooperativeitem", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierCooperativeItemListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Funds
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/funds/balance/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getbalance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierFundsBalanceGetResponse> ExecuteChannelsECLeagueHeadSupplierFundsBalanceGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierFundsBalanceGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "funds", "balance", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierFundsBalanceGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/funds/flowdetail/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getfundsflowdeatail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierFundsFlowDetailGetResponse> ExecuteChannelsECLeagueHeadSupplierFundsFlowDetailGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierFundsFlowDetailGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "funds", "flowdetail", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierFundsFlowDetailGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/funds/flowlist/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getfundsflowlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierFundsFlowListGetResponse> ExecuteChannelsECLeagueHeadSupplierFundsFlowListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierFundsFlowListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "funds", "flowlist", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierFundsFlowListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Item
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/item/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getitemlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierItemListGetResponse> ExecuteChannelsECLeagueHeadSupplierItemListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierItemListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "item", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierItemListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/item/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getitem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierItemGetResponse> ExecuteChannelsECLeagueHeadSupplierItemGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierItemGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "item", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierItemGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/item/upd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/updateitem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierItemUpdateResponse> ExecuteChannelsECLeagueHeadSupplierItemUpdateAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierItemUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "item", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierItemUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/item/promotiondetail/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getpromotiondetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierItemPromotionDetailGetResponse> ExecuteChannelsECLeagueHeadSupplierItemPromotionDetailGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierItemPromotionDetailGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "item", "promotiondetail", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierItemPromotionDetailGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion、

        #region ECLeague/HeadSupplier/LiveProtection
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/liveprotection/getqrcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_live_protection_qrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierLiveProtectionGetQrcodeResponse> ExecuteChannelsECLeagueHeadSupplierLiveProtectionGetQrcodeAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierLiveProtectionGetQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "liveprotection", "getqrcode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierLiveProtectionGetQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Order
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/order/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getorderlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierOrderListGetResponse> ExecuteChannelsECLeagueHeadSupplierOrderListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierOrderListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "order", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierOrderListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/order/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierOrderGetResponse> ExecuteChannelsECLeagueHeadSupplierOrderGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/ProductDetail
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/productdetail/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getproductdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierProductDetailGetResponse> ExecuteChannelsECLeagueHeadSupplierProductDetailGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierProductDetailGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "productdetail", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierProductDetailGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/SelectionProduct
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/selectionproducts/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/listselectionproducts.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierSelectionProductsListGetResponse> ExecuteChannelsECLeagueHeadSupplierSelectionProductsListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierSelectionProductsListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "selectionproducts", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierSelectionProductsListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Shop
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/shop/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getshoplist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierShopListGetResponse> ExecuteChannelsECLeagueHeadSupplierShopListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierShopListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "shop", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierShopListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/shop/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getshop.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierShopGetResponse> ExecuteChannelsECLeagueHeadSupplierShopGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierShopGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "shop", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierShopGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/SubItem
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/subitem/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/addsubitem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierSubItemAddResponse> ExecuteChannelsECLeagueHeadSupplierSubItemAddAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierSubItemAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "subitem", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierSubItemAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/subitem/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getsubitemlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierSubItemListGetResponse> ExecuteChannelsECLeagueHeadSupplierSubItemListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierSubItemListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "shop", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierSubItemListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Subscription
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/subscription/subscribe 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/hs_subscribe.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierSubscriptionSubscribeResponse> ExecuteChannelsECLeagueHeadSupplierSubscriptionSubscribeAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierSubscriptionSubscribeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "subscription", "subscribe")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierSubscriptionSubscribeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/subscription/unsubscribe 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/hs_unsubscribe.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierSubscriptionUnsubscribeResponse> ExecuteChannelsECLeagueHeadSupplierSubscriptionUnsubscribeAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierSubscriptionUnsubscribeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "subscription", "unsubscribe")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierSubscriptionUnsubscribeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/subscription/getsubscribe 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/hs_getsubscribe.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierSubscriptionGetSubscribeResponse> ExecuteChannelsECLeagueHeadSupplierSubscriptionGetSubscribeAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierSubscriptionGetSubscribeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "subscription", "getsubscribe")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierSubscriptionGetSubscribeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Window
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowAddResponse> ExecuteChannelsECLeagueHeadSupplierWindowAddAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/remove 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/removewindow.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowRemoveResponse> ExecuteChannelsECLeagueHeadSupplierWindowRemoveAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowRemoveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "remove")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowRemoveResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/getall 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getallwindow.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowGetAllResponse> ExecuteChannelsECLeagueHeadSupplierWindowGetAllAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowGetAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "getall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowGetAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/getdetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getwindowdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowGetDetailResponse> ExecuteChannelsECLeagueHeadSupplierWindowGetDetailAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowGetDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "getdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowGetDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/windowauth/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getauth.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowAuthGetResponse> ExecuteChannelsECLeagueHeadSupplierWindowAuthGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowAuthGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "windowauth", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowAuthGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/windowauth/status/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/getauthstatus.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowAuthStatusGetResponse> ExecuteChannelsECLeagueHeadSupplierWindowAuthStatusGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowAuthStatusGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "windowauth", "status", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowAuthStatusGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECLeague/Item
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/batchadd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_batchadditem.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_batchadditem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemBatchAddResponse> ExecuteChannelsECLeagueItemBatchAddAsync(this WechatApiClient client, Models.ChannelsECLeagueItemBatchAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "batchadd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemBatchAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/upd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_upditem.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_upditem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemUpdateResponse> ExecuteChannelsECLeagueItemUpdateAsync(this WechatApiClient client, Models.ChannelsECLeagueItemUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_deleteitem.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_upditem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemDeleteResponse> ExecuteChannelsECLeagueItemDeleteAsync(this WechatApiClient client, Models.ChannelsECLeagueItemDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getitem.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_getitem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemGetResponse> ExecuteChannelsECLeagueItemGetAsync(this WechatApiClient client, Models.ChannelsECLeagueItemGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getitemlist.htmll ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_getitemlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemListGetResponse> ExecuteChannelsECLeagueItemListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueItemListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/headsupplier/batchadd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_batchaddheadsupplieritem.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_batchaddheadsupplieritem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemHeadSupplierBatchAddResponse> ExecuteChannelsECLeagueItemHeadSupplierBatchAddAsync(this WechatApiClient client, Models.ChannelsECLeagueItemHeadSupplierBatchAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "headsupplier", "batchadd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemHeadSupplierBatchAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/Promoter
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_addpromoter.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_addpromoter.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterAddResponse> ExecuteChannelsECLeaguePromoterAddAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/upd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_updpromoter.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_updpromoter.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterUpdateResponse> ExecuteChannelsECLeaguePromoterUpdateAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_deletepromoter.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_deletepromoter.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterDeleteResponse> ExecuteChannelsECLeaguePromoterDeleteAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getpromoter.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_getpromoter.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterGetResponse> ExecuteChannelsECLeaguePromoterGetAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getpromoterlist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/league/ecleague_getpromoterlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterListGetResponse> ExecuteChannelsECLeaguePromoterListGetAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECLogistics
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/phonenumberpool/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/logistics/delivery_virtual_number.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/logistics/delivery_virtual_number.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsPhoneNumberPoolGetResponse> ExecuteChannelsECLogisticsPhoneNumberPoolGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsPhoneNumberPoolGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "phonenumberpool", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsPhoneNumberPoolGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/phonenumber/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/logistics/delivery_virtual_number_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/logistics/delivery_virtual_number_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsPhoneNumberGetResponse> ExecuteChannelsECLogisticsPhoneNumberGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsPhoneNumberGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "phonenumber", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsPhoneNumberGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/virtualnumber/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/logistics/delivery_virtual_number_get_virtual.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/logistics/delivery_virtual_number_get_virtual.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsVirtualNumberGetResponse> ExecuteChannelsECLogisticsVirtualNumberGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsVirtualNumberGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "virtualnumber", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsVirtualNumberGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECLogistics/EWaybill
        #region ECLogistics/EWaybill/Account
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/account/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_account.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/get_account.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillAccountGetResponse> ExecuteChannelsECLogisticsEWaybillAccountGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillAccountGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "account", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillAccountGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLogistics/EWaybill/Delivery
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/delivery/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_acctdeliverylist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/get_acctdeliverylist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillDeliveryGetResponse> ExecuteChannelsECLogisticsEWaybillDeliveryGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillDeliveryGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "delivery", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillDeliveryGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLogistics/EWaybill/Order
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/precreate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/precreate_order.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/precreate_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderPrecreateResponse> ExecuteChannelsECLogisticsEWaybillOrderPrecreateAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderPrecreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "precreate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderPrecreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/create_order.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/create_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderCreateResponse> ExecuteChannelsECLogisticsEWaybillOrderCreateAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/addsuborder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/add_suborder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderAddSubOrderResponse> ExecuteChannelsECLogisticsEWaybillOrderAddSubOrderAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderAddSubOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "addsuborder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderAddSubOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/cancel_order.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/cancel_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderCancelResponse> ExecuteChannelsECLogisticsEWaybillOrderCancelAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_order.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/get_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderGetResponse> ExecuteChannelsECLogisticsEWaybillOrderGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/print 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/notify_print.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/notify_print.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderPrintResponse> ExecuteChannelsECLogisticsEWaybillOrderPrintAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderPrintRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "print")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderPrintResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/batchprint 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/batchnotify_print.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/batchnotify_print.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderBatchPrintResponse> ExecuteChannelsECLogisticsEWaybillOrderBatchPrintAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderBatchPrintRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "batchprint")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderBatchPrintResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLogistics/EWaybill/Print
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/print/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_print_info.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/get_print_info.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillPrintGetResponse> ExecuteChannelsECLogisticsEWaybillPrintGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillPrintGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "print", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillPrintGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLogistics/EWaybill/Template
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/config 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_template_config.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/get_template_config.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateConfigResponse> ExecuteChannelsECLogisticsEWaybillTemplateConfigAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/add_template.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/add_template.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateCreateResponse> ExecuteChannelsECLogisticsEWaybillTemplateCreateAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/update_template.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/update_template.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateUpdateResponse> ExecuteChannelsECLogisticsEWaybillTemplateUpdateAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/delete_template.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/delete_template.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateDeleteResponse> ExecuteChannelsECLogisticsEWaybillTemplateDeleteAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_template.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/get_template.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateGetResponse> ExecuteChannelsECLogisticsEWaybillTemplateGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/getbyid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_templatebyid.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/get_templatebyid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateGetByIdResponse> ExecuteChannelsECLogisticsEWaybillTemplateGetByIdAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateGetByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "getbyid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateGetByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion
        #endregion

        #region ECMerchant
        #region ECMerchant/FreightTemplate
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/getfreighttemplatelist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/deliverycompanylist_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/merchant/getfreighttemplatelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantGetFreightTemplateListResponse> ExecuteChannelsECMerchantGetFreightTemplateListAsync(this WechatApiClient client, Models.ChannelsECMerchantGetFreightTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "getfreighttemplatelist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantGetFreightTemplateListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/getfreighttemplatedetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/getfreighttemplatedetail.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/merchant/getfreighttemplatedetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantGetFreightTemplateDetailResponse> ExecuteChannelsECMerchantGetFreightTemplateDetailAsync(this WechatApiClient client, Models.ChannelsECMerchantGetFreightTemplateDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "getfreighttemplatedetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantGetFreightTemplateDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/addfreighttemplate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/addfreighttemplate.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/merchant/addfreighttemplate.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddFreightTemplateResponse> ExecuteChannelsECMerchantAddFreightTemplateAsync(this WechatApiClient client, Models.ChannelsECMerchantAddFreightTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "addfreighttemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddFreightTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/updatefreighttemplate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/updatefreighttemplate.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/merchant/updatefreighttemplate.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantUpdateFreightTemplateResponse> ExecuteChannelsECMerchantUpdateFreightTemplateAsync(this WechatApiClient client, Models.ChannelsECMerchantUpdateFreightTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "updatefreighttemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantUpdateFreightTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECMerchant/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/list.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/merchant/address/list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressListResponse> ExecuteChannelsECMerchantAddressListAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/merchant/address/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressGetResponse> ExecuteChannelsECMerchantAddressGetAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/add.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/merchant/address/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressAddResponse> ExecuteChannelsECMerchantAddressAddAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/update.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/merchant/address/update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressUpdateResponse> ExecuteChannelsECMerchantAddressUpdateAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/delete.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/merchant/address/delete.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressDeleteResponse> ExecuteChannelsECMerchantAddressDeleteAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECOpen
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/open/get_download_url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/miniandstore/get_download_url.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOpenGetDownloadUrlResponse> ExecuteChannelsECOpenGetDownloadUrlAsync(this WechatApiClient client, Models.ChannelsECOpenGetDownloadUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "open", "get_download_url")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOpenGetDownloadUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECOrder
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/search.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/search.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderSearchResponse> ExecuteChannelsECOrderSearchAsync(this WechatApiClient client, Models.ChannelsECOrderSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "search")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/list_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderListGetResponse> ExecuteChannelsECOrderListGetAsync(this WechatApiClient client, Models.ChannelsECOrderListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/query_coupon.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderGetResponse> ExecuteChannelsECOrderGetAsync(this WechatApiClient client, Models.ChannelsECOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/price/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/price_update.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/price_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderPriceUpdateResponse> ExecuteChannelsECOrderPriceUpdateAsync(this WechatApiClient client, Models.ChannelsECOrderPriceUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "price", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderPriceUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/merchantnotes/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/merchantnotes_update.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/merchantnotes_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderMerchantNotesUpdateResponse> ExecuteChannelsECOrderMerchantNotesUpdateAsync(this WechatApiClient client, Models.ChannelsECOrderMerchantNotesUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "merchantnotes", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderMerchantNotesUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/presentnote/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/present_note_add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderPresentNoteAddResponse> ExecuteChannelsECOrderPresentNoteAddAsync(this WechatApiClient client, Models.ChannelsECOrderPresentNoteAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "presentnote", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderPresentNoteAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/presentsuborder/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/get_by_presentid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderPresentSubOrderGetResponse> ExecuteChannelsECOrderPresentSubOrderGetAsync(this WechatApiClient client, Models.ChannelsECOrderPresentSubOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "presentsuborder", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderPresentSubOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/sensitiveinfo/decode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/decode_order_sensitive_info.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/decode_order_sensitive_info.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderSensitiveInfoDecodeResponse> ExecuteChannelsECOrderSensitiveInfoDecodeAsync(this WechatApiClient client, Models.ChannelsECOrderSensitiveInfoDecodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "sensitiveinfo", "decode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderSensitiveInfoDecodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/virtualtelnumber/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/virtualtelnumber_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/virtualtelnumber_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-05-09 下线。")]
        public static async Task<Models.ChannelsECOrderVirtualTelNumberGetResponse> ExecuteChannelsECOrderVirtualTelNumberGetAsync(this WechatApiClient client, Models.ChannelsECOrderVirtualTelNumberGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "virtualtelnumber", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderVirtualTelNumberGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/freshinspect/submit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/fresh_inspect_submit.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/fresh_inspect_submit.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderFreshInspectSubmitResponse> ExecuteChannelsECOrderFreshInspectSubmitAsync(this WechatApiClient client, Models.ChannelsECOrderFreshInspectSubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "freshinspect", "submit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderFreshInspectSubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ECOrder/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/address/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/address_update.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/address_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderAddressUpdateResponse> ExecuteChannelsECOrderAddressUpdateAsync(this WechatApiClient client, Models.ChannelsECOrderAddressUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "address", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderAddressUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/addressmodify/accept 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/accept_address_modify_apply.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/accept_address_modify_apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderAddressModifyAcceptResponse> ExecuteChannelsECOrderAddressModifyAcceptAsync(this WechatApiClient client, Models.ChannelsECOrderAddressModifyAcceptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "addressmodify", "accept")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderAddressModifyAcceptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/addressmodify/reject 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/reject_address_modify_apply.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/reject_address_modify_apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderAddressModifyRejectResponse> ExecuteChannelsECOrderAddressModifyRejectAsync(this WechatApiClient client, Models.ChannelsECOrderAddressModifyRejectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "addressmodify", "reject")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderAddressModifyRejectResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECOrder/Delivery
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/deliveryinfo/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/deliveryinfo_update.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/deliveryinfo_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderDeliveryInfoUpdateResponse> ExecuteChannelsECOrderDeliveryInfoUpdateAsync(this WechatApiClient client, Models.ChannelsECOrderDeliveryInfoUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "deliveryinfo", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderDeliveryInfoUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/deliverycompanylist/new/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/ewaybill/deliverycompanylist_get_new.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderDeliveryCompanyListNewGetResponse> ExecuteChannelsECOrderDeliveryCompanyListNewGetAsync(this WechatApiClient client, Models.ChannelsECOrderDeliveryCompanyListNewGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "deliverycompanylist", "new", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderDeliveryCompanyListNewGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/deliverycompanylist/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/deliverycompanylist_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/deliverycompanylist_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderDeliveryCompanyListGetResponse> ExecuteChannelsECOrderDeliveryCompanyListGetAsync(this WechatApiClient client, Models.ChannelsECOrderDeliveryCompanyListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "deliverycompanylist", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderDeliveryCompanyListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/delivery/send 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/delivery_send.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/delivery_send.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderDeliverySendResponse> ExecuteChannelsECOrderDeliverySendAsync(this WechatApiClient client, Models.ChannelsECOrderDeliverySendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "delivery", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderDeliverySendResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECOrder/PreshipmentChangeSKU
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/preshipmentchangesku/approve 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/preshipment_change_sku_approve.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderPreshipmentChangeSKUApproveResponse> ExecuteChannelsECOrderPreshipmentChangeSKUApproveAsync(this WechatApiClient client, Models.ChannelsECOrderPreshipmentChangeSKUApproveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "preshipmentchangesku", "approve")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderPreshipmentChangeSKUApproveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/preshipmentchangesku/reject 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/preshipment_change_sku_reject.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderPreshipmentChangeSKURejectResponse> ExecuteChannelsECOrderPreshipmentChangeSKURejectAsync(this WechatApiClient client, Models.ChannelsECOrderPreshipmentChangeSKURejectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "preshipmentchangesku", "reject")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderPreshipmentChangeSKURejectResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/preshipmentchangesku/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/order/preshipment_change_sku_reject.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderPreshipmentChangeSKUGetResponse> ExecuteChannelsECOrderPreshipmentChangeSKUGetAsync(this WechatApiClient client, Models.ChannelsECOrderPreshipmentChangeSKUGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "preshipmentchangesku", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderPreshipmentChangeSKUGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region ECProduct
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/add.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductAddResponse> ExecuteChannelsECProductAddAsync(this WechatApiClient client, Models.ChannelsECProductAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/update.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductUpdateResponse> ExecuteChannelsECProductUpdateAsync(this WechatApiClient client, Models.ChannelsECProductUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/delete.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/delete.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/delete.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_delete.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductDeleteResponse> ExecuteChannelsECProductDeleteAsync(this WechatApiClient client, Models.ChannelsECProductDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductGetResponse> ExecuteChannelsECProductGetAsync(this WechatApiClient client, Models.ChannelsECProductGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/list_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductListGetResponse> ExecuteChannelsECProductListGetAsync(this WechatApiClient client, Models.ChannelsECProductListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/listing 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/listing.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/listing.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/listing.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_listing.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductListingResponse> ExecuteChannelsECProductListingAsync(this WechatApiClient client, Models.ChannelsECProductListingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "listing")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductListingResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/delisting 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/delisting.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/removed.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/delisting.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_delisting.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductDelistingResponse> ExecuteChannelsECProductDelistingAsync(this WechatApiClient client, Models.ChannelsECProductDelistingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "delisting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductDelistingResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/auditfree 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/audit_free.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductAuditFreeResponse> ExecuteChannelsECProductAuditFreeAsync(this WechatApiClient client, Models.ChannelsECProductAuditFreeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "auditfree")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductAuditFreeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/audit/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/audit_cancel.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/withdraw.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/audit_cancel.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_audit_cancel.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductAuditCancelResponse> ExecuteChannelsECProductAuditCancelAsync(this WechatApiClient client, Models.ChannelsECProductAuditCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/h5url/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_h5url.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/get_h5url.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductH5UrlGetResponse> ExecuteChannelsECProductH5UrlGetAsync(this WechatApiClient client, Models.ChannelsECProductH5UrlGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "h5url", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductH5UrlGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/taglink/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_taglink.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/get_taglink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductTagLinkGetResponse> ExecuteChannelsECProductTagLinkGetAsync(this WechatApiClient client, Models.ChannelsECProductTagLinkGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "taglink", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductTagLinkGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/qrcode/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_qrcode.html ]]> <br />
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/get_qrcode.html ]]>
        /// </para> 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductQrcodeGetResponse> ExecuteChannelsECProductQrcodeGetAsync(this WechatApiClient client, Models.ChannelsECProductQrcodeGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "qrcode", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductQrcodeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/scheme/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/get_scheme.html ]]>
        /// </para> 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductSchemeGetResponse> ExecuteChannelsECProductSchemeGetAsync(this WechatApiClient client, Models.ChannelsECProductSchemeGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "scheme", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductSchemeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECProduct/Activity
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/activity/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/giftactivity/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductActivityAddResponse> ExecuteChannelsECProductActivityAddAsync(this WechatApiClient client, Models.ChannelsECProductActivityAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "activity", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductActivityAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECProduct/Gift
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/gift/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductGiftAddResponse> ExecuteChannelsECProductGiftAddAsync(this WechatApiClient client, Models.ChannelsECProductGiftAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "gift", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductGiftAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/gift/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductGiftUpdateResponse> ExecuteChannelsECProductGiftUpdateAsync(this WechatApiClient client, Models.ChannelsECProductGiftUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "gift", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductGiftUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/gift/onsale/set 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_onsale_set.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductGiftOnSaleSetResponse> ExecuteChannelsECProductGiftOnSaleSetAsync(this WechatApiClient client, Models.ChannelsECProductGiftOnSaleSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "gift", "onsale", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductGiftOnSaleSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/gift/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductGiftGetResponse> ExecuteChannelsECProductGiftGetAsync(this WechatApiClient client, Models.ChannelsECProductGiftGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "gift", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductGiftGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/gift/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductGiftListGetResponse> ExecuteChannelsECProductGiftListGetAsync(this WechatApiClient client, Models.ChannelsECProductGiftListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "gift", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductGiftListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/gift/stock/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/gift/gift_update_stock.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductGiftStockUpdateResponse> ExecuteChannelsECProductGiftStockUpdateAsync(this WechatApiClient client, Models.ChannelsECProductGiftStockUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "gift", "stock", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductGiftStockUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECProduct/LimitedDiscountTask
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/add.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/limiteddiscounttask/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLimitedDiscountTaskAddResponse> ExecuteChannelsECProductLimitedDiscountTaskAddAsync(this WechatApiClient client, Models.ChannelsECProductLimitedDiscountTaskAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLimitedDiscountTaskAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/list_get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/limiteddiscounttask/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLimitedDiscountTaskListGetResponse> ExecuteChannelsECProductLimitedDiscountTaskListGetAsync(this WechatApiClient client, Models.ChannelsECProductLimitedDiscountTaskListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLimitedDiscountTaskListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/stop 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/stop.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/limiteddiscounttask/stop.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLimitedDiscountTaskStopResponse> ExecuteChannelsECProductLimitedDiscountTaskStopAsync(this WechatApiClient client, Models.ChannelsECProductLimitedDiscountTaskStopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "stop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLimitedDiscountTaskStopResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/delete.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/limiteddiscounttask/delete.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLimitedDiscountTaskDeleteResponse> ExecuteChannelsECProductLimitedDiscountTaskDeleteAsync(this WechatApiClient client, Models.ChannelsECProductLimitedDiscountTaskDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLimitedDiscountTaskDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECProduct/Stock
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/stock_update.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/modify-stock.html ]]>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/stock_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductStockUpdateResponse> ExecuteChannelsECProductStockUpdateAsync(this WechatApiClient client, Models.ChannelsECProductStockUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductStockUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_stock.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/get_stock.html ]]> <br/>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductStockGetResponse> ExecuteChannelsECProductStockGetAsync(this WechatApiClient client, Models.ChannelsECProductStockGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductStockGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/batchget 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/batchget_stock.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/batchget_stock.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductStockBatchGetResponse> ExecuteChannelsECProductStockBatchGetAsync(this WechatApiClient client, Models.ChannelsECProductStockBatchGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "batchget")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductStockBatchGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/getflow 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_stock_flow.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/product/get_stock_flow.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductStockGetFlowResponse> ExecuteChannelsECProductStockGetFlowAsync(this WechatApiClient client, Models.ChannelsECProductStockGetFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "getflow")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductStockGetFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECProductLocalLife
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/locallife/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/query.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLocalLifeListGetResponse> ExecuteChannelsECProductLocalLifeListGetAsync(this WechatApiClient client, Models.ChannelsECProductLocalLifeListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "locallife", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLocalLifeListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/locallife/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/query_details.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLocalLifeGetResponse> ExecuteChannelsECProductLocalLifeGetAsync(this WechatApiClient client, Models.ChannelsECProductLocalLifeGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "locallife", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLocalLifeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/locallife/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLocalLifeAddResponse> ExecuteChannelsECProductLocalLifeAddAsync(this WechatApiClient client, Models.ChannelsECProductLocalLifeAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "locallife", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLocalLifeAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/locallife/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLocalLifeUpdateResponse> ExecuteChannelsECProductLocalLifeUpdateAsync(this WechatApiClient client, Models.ChannelsECProductLocalLifeUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "locallife", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLocalLifeUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/locallife/auditfree 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/review-free.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLocalLifeAuditFreeResponse> ExecuteChannelsECProductLocalLifeAuditFreeAsync(this WechatApiClient client, Models.ChannelsECProductLocalLifeAuditFreeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "locallife", "auditfree")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLocalLifeAuditFreeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECPromoter
        #region ECPromoter/Article
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_talent_biz_article_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/article/get_talent_biz_article_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetTalentMpArticleListResponse> ExecuteChannelsECPromoterGetTalentMpArticleListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetTalentMpArticleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_talent_biz_article_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetTalentMpArticleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_shop_mp_article_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/article/get_shop_mp_article_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetShopMpArticleListResponse> ExecuteChannelsECPromoterGetShopMpArticleListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetShopMpArticleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_shop_mp_article_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetShopMpArticleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECPromoter/Coupon
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_public_coupon_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/coupon/getpubliccouponlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetPublicCouponListResponse> ExecuteChannelsECPromoterGetPublicCouponListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetPublicCouponListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_public_coupon_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetPublicCouponListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_cooperative_coupon_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/coupon/getcooperativecouponlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetCooperativeCouponListResponse> ExecuteChannelsECPromoterGetCooperativeCouponListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetCooperativeCouponListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_cooperative_coupon_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetCooperativeCouponListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_coupon_detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/coupon/getcoupondetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetCouponDetailResponse> ExecuteChannelsECPromoterGetCouponDetailAsync(this WechatApiClient client, Models.ChannelsECPromoterGetCouponDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_coupon_detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetCouponDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_coupon_short_link 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/coupon/getcouponshortlink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetCouponShortLinkResponse> ExecuteChannelsECPromoterGetCouponShortLinkAsync(this WechatApiClient client, Models.ChannelsECPromoterGetCouponShortLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_coupon_short_link")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetCouponShortLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_coupon_qr_code 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/coupon/getcouponqrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetCouponQrcodeResponse> ExecuteChannelsECPromoterGetCouponQrcodeAsync(this WechatApiClient client, Models.ChannelsECPromoterGetCouponQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_coupon_qr_code")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetCouponQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECPromoter/Feed
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_feed_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/video/get_feed_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetFeedListResponse> ExecuteChannelsECPromoterGetFeedListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetFeedListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_feed_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetFeedListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_shop_feed_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/video/get_shop_feed_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetShopFeedListResponse> ExecuteChannelsECPromoterGetShopFeedListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetShopFeedListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_shop_feed_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetShopFeedListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_feed_promotion_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/video/get_feed_promotion_info.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetFeedPromotionInfoResponse> ExecuteChannelsECPromoterGetFeedPromotionInfoAsync(this WechatApiClient client, Models.ChannelsECPromoterGetFeedPromotionInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_feed_promotion_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetFeedPromotionInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_shop_feed_promotion_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/video/get_shop_feed_promotion_info.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetShopFeedPromotionInfoResponse> ExecuteChannelsECPromoterGetShopFeedPromotionInfoAsync(this WechatApiClient client, Models.ChannelsECPromoterGetShopFeedPromotionInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_shop_feed_promotion_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetShopFeedPromotionInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECPromoter/Live
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_live_record_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_live_record_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetLiveRecordListResponse> ExecuteChannelsECPromoterGetLiveRecordListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetLiveRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_live_record_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetLiveRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_live_notice_record_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_live_notice_record_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetLiveNoticeRecordListResponse> ExecuteChannelsECPromoterGetLiveNoticeRecordListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetLiveNoticeRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_live_notice_record_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetLiveNoticeRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_live_record_qr_code 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_live_record_qr_code.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetLiveRecordQrcodeResponse> ExecuteChannelsECPromoterGetLiveRecordQrcodeAsync(this WechatApiClient client, Models.ChannelsECPromoterGetLiveRecordQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_live_record_qr_code")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetLiveRecordQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_live_notice_record_qr_code 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_live_notice_record_qr_code.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetLiveNoticeRecordQrcodeResponse> ExecuteChannelsECPromoterGetLiveNoticeRecordQrcodeAsync(this WechatApiClient client, Models.ChannelsECPromoterGetLiveNoticeRecordQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_live_notice_record_qr_code")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetLiveNoticeRecordQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_live_commission_product_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_live_commission_product_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetLiveCommissionProductListResponse> ExecuteChannelsECPromoterGetLiveCommissionProductListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetLiveCommissionProductListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_live_commission_product_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetLiveCommissionProductListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_live_notice_reservation_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_live_notice_reservation_info.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetLiveNoticeReservationInfoResponse> ExecuteChannelsECPromoterGetLiveNoticeReservationInfoAsync(this WechatApiClient client, Models.ChannelsECPromoterGetLiveNoticeReservationInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_live_notice_reservation_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetLiveNoticeReservationInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_shop_live_record_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_shop_live_record_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetShopLiveRecordListResponse> ExecuteChannelsECPromoterGetShopLiveRecordListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetShopLiveRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_shop_live_record_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetShopLiveRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_shop_live_notice_record_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_shop_live_notice_record_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetShopLiveNoticeRecordListResponse> ExecuteChannelsECPromoterGetShopLiveNoticeRecordListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetShopLiveNoticeRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_shop_live_notice_record_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetShopLiveNoticeRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_shop_live_record_qr_code 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_shop_live_record_qr_code.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetShopLiveRecordQrcodeResponse> ExecuteChannelsECPromoterGetShopLiveRecordQrcodeAsync(this WechatApiClient client, Models.ChannelsECPromoterGetShopLiveRecordQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_shop_live_record_qr_code")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetShopLiveRecordQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_shop_live_notice_record_qr_code 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_shop_live_notice_record_qr_code.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetShopLiveNoticeRecordQrcodeResponse> ExecuteChannelsECPromoterGetShopLiveNoticeRecordQrcodeAsync(this WechatApiClient client, Models.ChannelsECPromoterGetShopLiveNoticeRecordQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_shop_live_notice_record_qr_code")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetShopLiveNoticeRecordQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_shop_live_commission_product_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/content/live/get_shop_live_commission_product_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetShopLiveCommissionProductListResponse> ExecuteChannelsECPromoterGetShopLiveCommissionProductListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetShopLiveCommissionProductListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_shop_live_commission_product_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetShopLiveCommissionProductListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECPromoter/Product
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/set_sharer_product_commission_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/product/setsharerproductcommissioninfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterSetSharerProductCommissionInfoResponse> ExecuteChannelsECPromoterSetSharerProductCommissionInfoAsync(this WechatApiClient client, Models.ChannelsECPromoterSetSharerProductCommissionInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "set_sharer_product_commission_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterSetSharerProductCommissionInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_sharer_product_commission_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/product/getsharerproductcommissioninfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetSharerProductCommissionInfoResponse> ExecuteChannelsECPromoterGetSharerProductCommissionInfoAsync(this WechatApiClient client, Models.ChannelsECPromoterGetSharerProductCommissionInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_sharer_product_commission_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetSharerProductCommissionInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_promote_product_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/product/getpromoteproductlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetPromoteProductListResponse> ExecuteChannelsECPromoterGetPromoteProductListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetPromoteProductListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_promote_product_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetPromoteProductListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_promote_product_detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/product/getpromoteproductdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetPromoteProductDetailResponse> ExecuteChannelsECPromoterGetPromoteProductDetailAsync(this WechatApiClient client, Models.ChannelsECPromoterGetPromoteProductDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_promote_product_detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetPromoteProductDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_product_promotion_link_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/product/getproductpromotionlinkinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetProductPromotionLinkInfoResponse> ExecuteChannelsECPromoterGetProductPromotionLinkInfoAsync(this WechatApiClient client, Models.ChannelsECPromoterGetProductPromotionLinkInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_product_promotion_link_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetProductPromotionLinkInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_product_promotion_qrcode_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/product/getproductpromotionqrcodeinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetProductPromotionQrcodeInfoResponse> ExecuteChannelsECPromoterGetProductPromotionQrcodeInfoAsync(this WechatApiClient client, Models.ChannelsECPromoterGetProductPromotionQrcodeInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_product_promotion_qrcode_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetProductPromotionQrcodeInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_promoter_single_product_promotion_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/product/getpromotersingleproductpromotioninfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetPromoterSingleProductPromotionInfoResponse> ExecuteChannelsECPromoterGetPromoterSingleProductPromotionInfoAsync(this WechatApiClient client, Models.ChannelsECPromoterGetPromoterSingleProductPromotionInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_promoter_single_product_promotion_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetPromoterSingleProductPromotionInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECPromoter/Sharer
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_promoter_register_and_bind_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/sharer/getpromoterregisterandbindstatus.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetPromoterRegisterAndBindStatusResponse> ExecuteChannelsECPromoterGetPromoterRegisterAndBindStatusAsync(this WechatApiClient client, Models.ChannelsECPromoterGetPromoterRegisterAndBindStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_promoter_register_and_bind_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetPromoterRegisterAndBindStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/set_sharer_commission_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/sharer/setsharercommissioninfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterSetSharerCommissionInfoResponse> ExecuteChannelsECPromoterSetSharerCommissionInfoAsync(this WechatApiClient client, Models.ChannelsECPromoterSetSharerCommissionInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "set_sharer_commission_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterSetSharerCommissionInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_bind_sharer_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/sharer/getbindsharerlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetBindSharerListResponse> ExecuteChannelsECPromoterGetBindSharerListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetBindSharerListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_bind_sharer_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetBindSharerListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_bind_talent_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/sharer/get_bind_talent_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetBindTalentListResponse> ExecuteChannelsECPromoterGetBindTalentListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetBindTalentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_bind_talent_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetBindTalentListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_bind_shop_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/sharer/get_bind_shop_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetBindShopListResponse> ExecuteChannelsECPromoterGetBindShopListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetBindShopListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_bind_shop_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetBindShopListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/promoter/get_bind_shop_promoter_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/leagueheadsupplier/API/promotion/sharer/get_bind_shop_promoter_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECPromoterGetBindShopPromoterListResponse> ExecuteChannelsECPromoterGetBindShopPromoterListAsync(this WechatApiClient client, Models.ChannelsECPromoterGetBindShopPromoterListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "promoter", "get_bind_shop_promoter_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECPromoterGetBindShopPromoterListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECQIC
        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/qic/inspect/config/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/qic/getinspectconfig.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/qic/getinspectconfig.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECQICInspectConfigGetResponse> ExecuteChannelsECQICInspectConfigGetAsync(this WechatApiClient client, Models.ChannelsECQICInspectConfigGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "qic", "inspect", "config", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECQICInspectConfigGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/qic/inspect/submitconfig/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/qic/getinspectsubmitconfig.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/qic/getinspectsubmitconfig.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECQICInspectSubmitConfigGetResponse> ExecuteChannelsECQICInspectSubmitConfigGetAsync(this WechatApiClient client, Models.ChannelsECQICInspectSubmitConfigGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "qic", "inspect", "submitconfig", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECQICInspectSubmitConfigGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/qic/inspect/code/print 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/qic/printinspectcode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/qic/printinspectcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECQICInspectCodePrintResponse> ExecuteChannelsECQICInspectCodePrintAsync(this WechatApiClient client, Models.ChannelsECQICInspectCodePrintRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "qic", "inspect", "code", "print")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECQICInspectCodePrintResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/qic/inspect/submit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/qic/submitinspectinfo.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/qic/submitinspectinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECQICInspectSubmitResponse> ExecuteChannelsECQICInspectSubmitAsync(this WechatApiClient client, Models.ChannelsECQICInspectSubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "qic", "inspect", "submit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECQICInspectSubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/qic/inspect/register_logistics 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/qic/registerlogistics.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECQICInspectRegisterLogisticsResponse> ExecuteChannelsECQICInspectRegisterLogisticsAsync(this WechatApiClient client, Models.ChannelsECQICInspectRegisterLogisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "qic", "inspect", "register_logistics")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECQICInspectRegisterLogisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECSharer
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/bind 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/bindsharer.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/bindsharer.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerBindResponse> ExecuteChannelsECSharerBindAsync(this WechatApiClient client, Models.ChannelsECSharerBindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "bind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerBindResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/unbind 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/unbindsharer.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/unbindsharer.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerUnbindResponse> ExecuteChannelsECSharerUnbindAsync(this WechatApiClient client, Models.ChannelsECSharerUnbindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "unbind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerUnbindResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/search_sharer 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/search_sharer.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/search_sharer.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerSearchSharerResponse> ExecuteChannelsECSharerSearchSharerAsync(this WechatApiClient client, Models.ChannelsECSharerSearchSharerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "search_sharer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerSearchSharerResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_list.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/get_sharer_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerGetSharerListResponse> ExecuteChannelsECSharerGetSharerListAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_order_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_order_list.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/get_sharer_order_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerGetSharerOrderListResponse> ExecuteChannelsECSharerGetSharerOrderListAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_order_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_product_h5url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_product_h5url.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/get_sharer_product_h5url.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerGetSharerProductH5UrlResponse> ExecuteChannelsECSharerGetSharerProductH5UrlAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerProductH5UrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_product_h5url")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerProductH5UrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_product_taglink 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_product_taglink.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/get_sharer_product_taglink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerGetSharerProductTagLinkResponse> ExecuteChannelsECSharerGetSharerProductTagLinkAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerProductTagLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_product_taglink")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerProductTagLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_product_qrcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_product_qrcode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/get_sharer_product_qrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerGetSharerProductQrcodeResponse> ExecuteChannelsECSharerGetSharerProductQrcodeAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerProductQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_product_qrcode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerProductQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_shop_finder_live_notice_sharer_url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/promote_finder_notice.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/promote_finder_notice.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerGetShopFinderLiveNoticeSharerUrlResponse> ExecuteChannelsECSharerGetShopFinderLiveNoticeSharerUrlAsync(this WechatApiClient client, Models.ChannelsECSharerGetShopFinderLiveNoticeSharerUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_shop_finder_live_notice_sharer_url")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetShopFinderLiveNoticeSharerUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_shop_finder_live_sharer_url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/promote_finder_live.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/sharer/promote_finder_live.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2025-03-07 下线。")]
        public static async Task<Models.ChannelsECSharerGetShopFinderLiveSharerUrlResponse> ExecuteChannelsECSharerGetShopFinderLiveSharerUrlAsync(this WechatApiClient client, Models.ChannelsECSharerGetShopFinderLiveSharerUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_shop_finder_live_sharer_url")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetShopFinderLiveSharerUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECStore
        #region ECStore/Classification
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/store/classification/tree/product/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/classification/addclassificationproduct.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECStoreClassificationTreeProductAddResponse> ExecuteChannelsECStoreClassificationTreeProductAddAsync(this WechatApiClient client, Models.ChannelsECStoreClassificationTreeProductAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "store", "classification", "tree", "product", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECStoreClassificationTreeProductAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/store/classification/tree/product/del 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/classification/delclassificationproduct.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECStoreClassificationTreeProductDeleteResponse> ExecuteChannelsECStoreClassificationTreeProductDeleteAsync(this WechatApiClient client, Models.ChannelsECStoreClassificationTreeProductDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "store", "classification", "tree", "product", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECStoreClassificationTreeProductDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/store/classification/tree/product/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/classification/getclassificationproductlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECStoreClassificationTreeProductGetResponse> ExecuteChannelsECStoreClassificationTreeProductGetAsync(this WechatApiClient client, Models.ChannelsECStoreClassificationTreeProductGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "store", "classification", "tree", "product", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECStoreClassificationTreeProductGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/store/classification/tree/set 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/classification/setclassificationtree.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECStoreClassificationTreeSetResponse> ExecuteChannelsECStoreClassificationTreeSetAsync(this WechatApiClient client, Models.ChannelsECStoreClassificationTreeSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "store", "classification", "tree", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECStoreClassificationTreeSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/store/classification/tree/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/classification/getclassificationtree.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECStoreClassificationTreeGetResponse> ExecuteChannelsECStoreClassificationTreeGetAsync(this WechatApiClient client, Models.ChannelsECStoreClassificationTreeGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "store", "classification", "tree", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECStoreClassificationTreeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECStore/Window
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/store/window/product/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/storewindow/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECStoreWindowProductListGetResponse> ExecuteChannelsECStoreWindowProductListGetAsync(this WechatApiClient client, Models.ChannelsECStoreWindowProductListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "store", "window", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECStoreWindowProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/store/window/product/reorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/storewindow/reorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECStoreWindowProductReorderResponse> ExecuteChannelsECStoreWindowProductReorderAsync(this WechatApiClient client, Models.ChannelsECStoreWindowProductReorderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "store", "window", "product", "reorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECStoreWindowProductReorderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/store/window/product/hide 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/storewindow/set_hide.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECStoreWindowProductHideResponse> ExecuteChannelsECStoreWindowProductHideAsync(this WechatApiClient client, Models.ChannelsECStoreWindowProductHideRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "store", "window", "product", "hide")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECStoreWindowProductHideResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/store/window/product/settop 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/homepage/storewindow/set_top.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECStoreWindowProductSetTopResponse> ExecuteChannelsECStoreWindowProductSetTopAsync(this WechatApiClient client, Models.ChannelsECStoreWindowProductSetTopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "store", "window", "product", "settop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECStoreWindowProductSetTopResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECTalent
        #region ECTalent/Order
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/talent/get_order_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/talent/openapi/order/get_order_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECTalentGetOrderListResponse> ExecuteChannelsECTalentGetOrderListAsync(this WechatApiClient client, Models.ChannelsECTalentGetOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "talent", "get_order_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECTalentGetOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/talent/get_order_detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/talent/openapi/order/get_order_detail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECTalentGetOrderDetailResponse> ExecuteChannelsECTalentGetOrderDetailAsync(this WechatApiClient client, Models.ChannelsECTalentGetOrderDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "talent", "get_order_detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECTalentGetOrderDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECTalent/Window
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/talent/window/product/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/talent/openapi/window/get_product_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECTalentWindowProductListGetResponse> ExecuteChannelsECTalentWindowProductListGetAsync(this WechatApiClient client, Models.ChannelsECTalentWindowProductListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "talent", "window", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECTalentWindowProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/talent/window/product/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/talent/openapi/window/get_product_detail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECTalentWindowProductGetResponse> ExecuteChannelsECTalentWindowProductGetAsync(this WechatApiClient client, Models.ChannelsECTalentWindowProductGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "talent", "window", "product", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECTalentWindowProductGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECVoucher
        #region ECVoucher/Bill
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/voucher/get_bill_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/query_voucher.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVoucherGetBillListResponse> ExecuteChannelsECVoucherGetBillListAsync(this WechatApiClient client, Models.ChannelsECVoucherGetBillListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "voucher", "get_bill_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVoucherGetBillListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECVoucher/Codes
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/voucher/codes/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/upload.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVoucherCodesUploadResponse> ExecuteChannelsECVoucherCodesUploadAsync(this WechatApiClient client, Models.ChannelsECVoucherCodesUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "voucher", "codes", "upload")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVoucherCodesUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/voucher/get_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/query_discount.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVoucherGetListResponse> ExecuteChannelsECVoucherGetListAsync(this WechatApiClient client, Models.ChannelsECVoucherGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "voucher", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVoucherGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/voucher/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/purchase.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVoucherGetResponse> ExecuteChannelsECVoucherGetAsync(this WechatApiClient client, Models.ChannelsECVoucherGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "voucher", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVoucherGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/voucher/consume 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/api.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVoucherConsumeResponse> ExecuteChannelsECVoucherConsumeAsync(this WechatApiClient client, Models.ChannelsECVoucherConsumeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "voucher", "consume")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVoucherConsumeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/voucher/revoke 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/discount-cancel.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVoucherRevokeResponse> ExecuteChannelsECVoucherRevokeAsync(this WechatApiClient client, Models.ChannelsECVoucherRevokeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "voucher", "revoke")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVoucherRevokeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECWarehouse
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/create.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/create.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseCreateResponse> ExecuteChannelsECWarehouseCreateAsync(this WechatApiClient client, Models.ChannelsECWarehouseCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/get_list.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/get_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseListGetResponse> ExecuteChannelsECWarehouseListGetAsync(this WechatApiClient client, Models.ChannelsECWarehouseListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/get.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseGetResponse> ExecuteChannelsECWarehouseGetAsync(this WechatApiClient client, Models.ChannelsECWarehouseGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/detail/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/update_detail.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/update_detail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseDetailUpdateResponse> ExecuteChannelsECWarehouseDetailUpdateAsync(this WechatApiClient client, Models.ChannelsECWarehouseDetailUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "detail", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseDetailUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Warehouse/CoverLocation
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/coverlocations/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/add_coverlocations.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/add_coverlocations.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseCoverLocationsAddResponse> ExecuteChannelsECWarehouseCoverLocationsAddAsync(this WechatApiClient client, Models.ChannelsECWarehouseCoverLocationsAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "coverlocations", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseCoverLocationsAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/coverlocations/del 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/del_coverlocations.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/del_coverlocations.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseCoverLocationsDeleteResponse> ExecuteChannelsECWarehouseCoverLocationsDeleteAsync(this WechatApiClient client, Models.ChannelsECWarehouseCoverLocationsDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "coverlocations", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseCoverLocationsDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Warehouse/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/address/prioritysort/set 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/set_prioritysort.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/set_prioritysort.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseAddressPrioritySortSetResponse> ExecuteChannelsECWarehouseAddressPrioritySortSetAsync(this WechatApiClient client, Models.ChannelsECWarehouseAddressPrioritySortSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "address", "prioritysort", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseAddressPrioritySortSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/address/prioritysort/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/get_prioritysort.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/get_prioritysort.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseAddressPrioritySortGetResponse> ExecuteChannelsECWarehouseAddressPrioritySortGetAsync(this WechatApiClient client, Models.ChannelsECWarehouseAddressPrioritySortGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "address", "prioritysort", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseAddressPrioritySortGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Warehouse/Stock
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/stock/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/update_stock.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/update_stock.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseStockUpdateResponse> ExecuteChannelsECWarehouseStockUpdateAsync(this WechatApiClient client, Models.ChannelsECWarehouseStockUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "stock", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseStockUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/stock/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/get_stock.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/warehouse/get_stock.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseStockGetResponse> ExecuteChannelsECWarehouseStockGetAsync(this WechatApiClient client, Models.ChannelsECWarehouseStockGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "stock", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseStockGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECWecom
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/wecom/get_wecom_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/wecom/getwecomid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWecomGetWecomIdResponse> ExecuteChannelsECWecomGetWecomIdAsync(this WechatApiClient client, Models.ChannelsECWecomGetWecomIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "wecom", "get_wecom_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWecomGetWecomIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECWindow
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductAddResponse> ExecuteChannelsECWindowProductAddAsync(this WechatApiClient client, Models.ChannelsECWindowProductAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWindowProductAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/off 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/off.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductOffResponse> ExecuteChannelsECWindowProductOffAsync(this WechatApiClient client, Models.ChannelsECWindowProductOffRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "off")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWindowProductOffResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductGetResponse> ExecuteChannelsECWindowProductGetAsync(this WechatApiClient client, Models.ChannelsECWindowProductGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWindowProductGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductListGetResponse> ExecuteChannelsECWindowProductListGetAsync(this WechatApiClient client, Models.ChannelsECWindowProductListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWindowProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region FinderLive
        /// <summary>
        /// <para>异步调用 [POST] /channels/finderlive/get_finder_attr_by_appid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/get_finder_attr_by_appid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsFinderLiveGetFinderAttributeByAppIdResponse> ExecuteChannelsFinderLiveGetFinderAttributeByAppIdAsync(this WechatApiClient client, Models.ChannelsFinderLiveGetFinderAttributeByAppIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "finderlive", "get_finder_attr_by_appid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsFinderLiveGetFinderAttributeByAppIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/finderlive/get_finder_live_data_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/get_finder_live_data_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsFinderLiveGetFinderLiveDataListResponse> ExecuteChannelsFinderLiveGetFinderLiveDataListAsync(this WechatApiClient client, Models.ChannelsFinderLiveGetFinderLiveDataListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "finderlive", "get_finder_live_data_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsFinderLiveGetFinderLiveDataListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/finderlive/get_finder_live_leads_data 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/get_finder_live_leads_data.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsFinderLiveGetFinderLeadsDataListResponse> ExecuteChannelsFinderLiveGetFinderLeadsDataListAsync(this WechatApiClient client, Models.ChannelsFinderLiveGetFinderLeadsDataListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "finderlive", "get_finder_live_leads_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsFinderLiveGetFinderLeadsDataListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Leads
        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_info_by_component_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_info_by_component_id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsInfoByComponentIdResponse> ExecuteChannelsLeadsGetLeadsInfoByComponentIdAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsInfoByComponentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_info_by_component_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsInfoByComponentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_info_by_request_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_info_by_request_id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsInfoByRequestIdResponse> ExecuteChannelsLeadsGetLeadsInfoByRequestIdAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsInfoByRequestIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_info_by_request_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsInfoByRequestIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_request_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_request_id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsRequestIdResponse> ExecuteChannelsLeadsGetLeadsRequestIdAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsRequestIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_request_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsRequestIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_component_promote_record 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_component_promote_record.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsComponentPromoteRecordResponse> ExecuteChannelsLeadsGetLeadsComponentPromoteRecordAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsComponentPromoteRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_component_promote_record")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsComponentPromoteRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_component_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_component_id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsComponentIdResponse> ExecuteChannelsLeadsGetLeadsComponentIdAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsComponentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_component_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsComponentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region LiveDashboard
        /// <summary>
        /// <para>异步调用 [POST] /channels/livedashboard/getlivelist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/livedashboard/getlivelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLiveDashboardGetLiveListResponse> ExecuteChannelsLiveDashboardGetLiveListAsync(this WechatApiClient client, Models.ChannelsLiveDashboardGetLiveListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "livedashboard", "getlivelist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLiveDashboardGetLiveListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/livedashboard/getlivedata 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/livedashboard/getlivedata.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLiveDashboardGetLiveDataResponse> ExecuteChannelsLiveDashboardGetLiveDataAsync(this WechatApiClient client, Models.ChannelsLiveDashboardGetLiveDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "livedashboard", "getlivedata")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLiveDashboardGetLiveDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
