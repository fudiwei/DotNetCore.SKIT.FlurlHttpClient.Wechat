using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingGoodsSubsidyActivityExtensions
    {
        #region RetailStore
        #region RetailStore/Representative
        /// <summary>
        /// <para>异步调用 [POST] /marketing/goods-subsidy-activity/retail-store-act/{activity_id}/representative 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/retail-store/retail-stores/add-representative.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddMarketingGoodsSubsidyActivityRetailStoreRepresentativeResponse> ExecuteAddMarketingGoodsSubsidyActivityRetailStoreRepresentativeAsync(this WechatTenpayClient client, Models.AddMarketingGoodsSubsidyActivityRetailStoreRepresentativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "goods-subsidy-activity", "retail-store-act", request.ActivityId, "representative");

            return await client.SendFlurlRequestAsJsonAsync<Models.AddMarketingGoodsSubsidyActivityRetailStoreRepresentativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/goods-subsidy-activity/retail-store-act/{activity_id}/representatives 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/retail-store/retail-store-act/list-representative.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingGoodsSubsidyActivityRetailStoreRepresentativesResponse> ExecuteQueryMarketingGoodsSubsidyActivityRetailStoreRepresentativesAsync(this WechatTenpayClient client, Models.QueryMarketingGoodsSubsidyActivityRetailStoreRepresentativesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "goods-subsidy-activity", "retail-store-act", request.ActivityId, "representatives")
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingGoodsSubsidyActivityRetailStoreRepresentativesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /marketing/goods-subsidy-activity/retail-store-act/{activity_id}/representative 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/retail-store/retail-store-act/delete-representative.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteMarketingGoodsSubsidyActivityRetailStoreRepresentativeResponse> ExecuteDeleteMarketingGoodsSubsidyActivityRetailStoreRepresentativeAsync(this WechatTenpayClient client, Models.DeleteMarketingGoodsSubsidyActivityRetailStoreRepresentativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "marketing", "goods-subsidy-activity", "retail-store-act", request.ActivityId, "representative");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteMarketingGoodsSubsidyActivityRetailStoreRepresentativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region RetailStore/Material
        /// <summary>
        /// <para>异步调用 [POST] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/materials 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/retail-store/retail-store-act/create-materials.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingGoodsSubsidyActivityRetailStoreMaterialResponse> ExecuteCreateMarketingGoodsSubsidyActivityRetailStoreMaterialAsync(this WechatTenpayClient client, Models.CreateMarketingGoodsSubsidyActivityRetailStoreMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "goods-subsidy-activity", "retail-store-act", request.BrandId, "materials");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingGoodsSubsidyActivityRetailStoreMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region RetailStore/Store
        /// <summary>
        /// <para>异步调用 [GET] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/retail-store/retail-store-act/list-store.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingGoodsSubsidyActivityRetailStoresResponse> ExecuteQueryMarketingGoodsSubsidyActivityRetailStoresAsync(this WechatTenpayClient client, Models.QueryMarketingGoodsSubsidyActivityRetailStoresRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "goods-subsidy-activity", "retail-store-act", request.BrandId, "stores")
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingGoodsSubsidyActivityRetailStoresResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores/{store_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/retail-store/retail-store-act/list-store.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingGoodsSubsidyActivityRetailStoreByStoreCodeResponse> ExecuteGetMarketingGoodsSubsidyActivityRetailStoreByStoreCodeAsync(this WechatTenpayClient client, Models.GetMarketingGoodsSubsidyActivityRetailStoreByStoreCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "goods-subsidy-activity", "retail-store-act", request.BrandId, "stores", request.StoreCode);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingGoodsSubsidyActivityRetailStoreByStoreCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/retail-store/retail-store-act/add-stores.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddMarketingGoodsSubsidyActivityRetailStoreResponse> ExecuteAddMarketingGoodsSubsidyActivityRetailStoreAsync(this WechatTenpayClient client, Models.AddMarketingGoodsSubsidyActivityRetailStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "goods-subsidy-activity", "retail-store-act", request.BrandId, "stores");

            return await client.SendFlurlRequestAsJsonAsync<Models.AddMarketingGoodsSubsidyActivityRetailStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/retail-store/retail-store-act/delete-stores.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteMarketingGoodsSubsidyActivityRetailStoreResponse> ExecuteDeleteMarketingGoodsSubsidyActivityRetailStoreAsync(this WechatTenpayClient client, Models.DeleteMarketingGoodsSubsidyActivityRetailStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "marketing", "goods-subsidy-activity", "retail-store-act", request.BrandId, "stores");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteMarketingGoodsSubsidyActivityRetailStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion
    }
}
