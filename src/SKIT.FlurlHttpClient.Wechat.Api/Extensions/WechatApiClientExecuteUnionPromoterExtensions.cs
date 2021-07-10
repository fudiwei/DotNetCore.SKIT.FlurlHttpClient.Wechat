using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteUnionPromoterExtensions
    {
        #region Promotion
        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/promotion/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/promotion.html#_1-%E6%B7%BB%E5%8A%A0%E6%8E%A8%E5%B9%BF%E4%BD%8D </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterPromotionAddResponse> ExecuteUnionPromoterPromotionAddAsync(this WechatApiClient client, Models.UnionPromoterPromotionAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "union", "promoter", "promotion", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UnionPromoterPromotionAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/promotion/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/promotion.html#_2-%E5%88%A0%E9%99%A4%E6%8E%A8%E5%B9%BF%E4%BD%8D </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterPromotionDeleteResponse> ExecuteUnionPromoterPromotionDeleteAsync(this WechatApiClient client, Models.UnionPromoterPromotionDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "union", "promoter", "promotion", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UnionPromoterPromotionDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/promotion/upd 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/promotion.html#_3-%E7%BC%96%E8%BE%91%E6%8E%A8%E5%B9%BF%E4%BD%8D </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterPromotionUpdateResponse> ExecuteUnionPromoterPromotionUpdateAsync(this WechatApiClient client, Models.UnionPromoterPromotionUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "union", "promoter", "promotion", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UnionPromoterPromotionUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/promotion/list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/promotion.html#_4-%E8%8E%B7%E5%8F%96%E6%8E%A8%E5%B9%BF%E4%BD%8D%E5%88%97%E8%A1%A8 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterPromotionListResponse> ExecuteUnionPromoterPromotionListAsync(this WechatApiClient client, Models.UnionPromoterPromotionListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "union", "promoter", "promotion", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("start", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendRequestWithJsonAsync<Models.UnionPromoterPromotionListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Product
        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/product/category 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/product/category.html#_1-%E8%8E%B7%E5%8F%96%E8%81%94%E7%9B%9F%E5%95%86%E5%93%81%E7%B1%BB%E7%9B%AE%E5%88%97%E8%A1%A8%E5%8F%8A%E7%B1%BB%E7%9B%AEID </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterProductCategoryResponse> ExecuteUnionPromoterProductCategoryAsync(this WechatApiClient client, Models.UnionPromoterProductCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "union", "promoter", "product", "category")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UnionPromoterProductCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/product/list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/product/category.html#_2-%E6%9F%A5%E8%AF%A2%E5%95%86%E5%93%81%E8%AF%A6%E6%83%85%E4%BF%A1%E6%81%AF </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterProductListResponse> ExecuteUnionPromoterProductListAsync(this WechatApiClient client, Models.UnionPromoterProductListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "union", "promoter", "product", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("from", request.Offset)
                .SetQueryParam("limit", request.Limit);

            if (request.QueryType.HasValue)
                flurlReq.SetQueryParam("queryType", request.QueryType.Value);

            if (!string.IsNullOrEmpty(request.Query))
                flurlReq.SetQueryParam("query", request.Query);

            if (request.MaxPrice.HasValue)
                flurlReq.SetQueryParam("maxPrice", request.MaxPrice.Value);

            if (request.MinPrice.HasValue)
                flurlReq.SetQueryParam("minPrice", request.MinPrice.Value);

            if (request.MinCommissionValue.HasValue)
                flurlReq.SetQueryParam("minCommissionValue", request.MinCommissionValue.Value);

            if (request.MinCommissionRatio.HasValue)
                flurlReq.SetQueryParam("minCommissionRatio", request.MinCommissionRatio.Value);

            if (request.SortType.HasValue)
                flurlReq.SetQueryParam("sortType", request.SortType.Value);

            if (request.HasCoupon.HasValue)
                flurlReq.SetQueryParam("hasCoupon", request.HasCoupon.Value ? 1 : 0);

            if (request.ShopAppIdList != null && request.ShopAppIdList.Any())
                flurlReq.SetQueryParam("shopAppIds", string.Join(",", request.ShopAppIdList));

            if (request.CategoryId.HasValue)
                flurlReq.SetQueryParam("categoryId", request.CategoryId);

            if (request.CategoryIdList != null && request.CategoryIdList.Any())
                flurlReq.SetQueryParam("category", string.Join(",", request.CategoryIdList));

            if (request.CategoryIdBlackList != null && request.CategoryIdBlackList.Any())
                flurlReq.SetQueryParam("noCategory", string.Join(",", request.CategoryIdBlackList));

            if (request.ProductIdList != null && request.ProductIdList.Any())
                flurlReq.SetQueryParam("productId", string.Join(",", request.ProductIdList));

            return await client.SendRequestWithJsonAsync<Models.UnionPromoterProductListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/product/generate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/product/category.html#_3-%E8%8E%B7%E5%8F%96%E5%95%86%E5%93%81%E6%8E%A8%E5%B9%BF%E7%B4%A0%E6%9D%90 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterProductGenerateResponse> ExecuteUnionPromoterProductGenerateAsync(this WechatApiClient client, Models.UnionPromoterProductGenerateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "union", "promoter", "product", "generate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UnionPromoterProductGenerateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/order/info 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/order/order-info.html#_1-%E6%A0%B9%E6%8D%AE%E8%AE%A2%E5%8D%95ID%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E8%AF%A6%E6%83%85 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOrderInfoResponse> ExecuteUnionPromoterOrderInfoAsync(this WechatApiClient client, Models.UnionPromoterOrderInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "union", "promoter", "order", "info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UnionPromoterOrderInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/order/search 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/order/order-info.html#_2-%E6%A0%B9%E6%8D%AE%E8%AE%A2%E5%8D%95%E6%94%AF%E4%BB%98%E6%97%B6%E9%97%B4%E3%80%81%E8%AE%A2%E5%8D%95%E5%88%86%E4%BD%A3%E7%8A%B6%E6%80%81%E6%8B%89%E5%8F%96%E8%AE%A2%E5%8D%95%E8%AF%A6%E6%83%85 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOrderSearchResponse> ExecuteUnionPromoterOrderSearchAsync(this WechatApiClient client, Models.UnionPromoterOrderSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "union", "promoter", "order", "search")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("page", request.Page);

            if (request.StartTimestamp.HasValue)
                flurlReq.SetQueryParam("startTimestamp", request.StartTimestamp.Value);

            if (request.EndTimestamp.HasValue)
                flurlReq.SetQueryParam("endTimestamp", request.EndTimestamp.Value);

            if (!string.IsNullOrEmpty(request.CommissionStatus))
                flurlReq.SetQueryParam("commissionStatus", request.CommissionStatus);

            return await client.SendRequestWithJsonAsync<Models.UnionPromoterOrderSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
