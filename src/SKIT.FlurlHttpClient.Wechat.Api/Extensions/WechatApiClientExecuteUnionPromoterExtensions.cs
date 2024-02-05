using System;
using System.Net.Http;
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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/promotion.html#_1-%E6%B7%BB%E5%8A%A0%E6%8E%A8%E5%B9%BF%E4%BD%8D ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "promotion", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterPromotionAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/promotion/del 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/promotion.html#_2-%E5%88%A0%E9%99%A4%E6%8E%A8%E5%B9%BF%E4%BD%8D ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "promotion", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterPromotionDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/promotion/upd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/promotion.html#_3-%E7%BC%96%E8%BE%91%E6%8E%A8%E5%B9%BF%E4%BD%8D ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "promotion", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterPromotionUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/promotion/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/promotion.html#_4-%E8%8E%B7%E5%8F%96%E6%8E%A8%E5%B9%BF%E4%BD%8D%E5%88%97%E8%A1%A8 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "promotion", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("start", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterPromotionListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Product
        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/product/category 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/product/category.html#_1-%E8%8E%B7%E5%8F%96%E8%81%94%E7%9B%9F%E5%95%86%E5%93%81%E7%B1%BB%E7%9B%AE%E5%88%97%E8%A1%A8%E5%8F%8A%E7%B1%BB%E7%9B%AEID ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/product/category.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "product", "category")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterProductCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/product/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/product/category.html#_2-%E6%9F%A5%E8%AF%A2%E5%95%86%E5%93%81%E8%AF%A6%E6%83%85%E4%BF%A1%E6%81%AF ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/product/category.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "product", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("from", request.Offset)
                .SetQueryParam("limit", request.Limit);

            if (request.QueryType is not null)
                flurlReq.SetQueryParam("queryType", request.QueryType.Value);

            if (request.Query is not null)
                flurlReq.SetQueryParam("query", request.Query);

            if (request.MaxPrice is not null)
                flurlReq.SetQueryParam("maxPrice", request.MaxPrice.Value);

            if (request.MinPrice is not null)
                flurlReq.SetQueryParam("minPrice", request.MinPrice.Value);

            if (request.MinCommissionValue is not null)
                flurlReq.SetQueryParam("minCommissionValue", request.MinCommissionValue.Value);

            if (request.MinCommissionRatio is not null)
                flurlReq.SetQueryParam("minCommissionRatio", request.MinCommissionRatio.Value);

            if (request.SortType is not null)
                flurlReq.SetQueryParam("sortType", request.SortType.Value);

            if (request.HasCoupon is not null)
                flurlReq.SetQueryParam("hasCoupon", request.HasCoupon.Value ? 1 : 0);

            if (request.ShopAppIdList is not null)
                flurlReq.SetQueryParam("shopAppIds", string.Join(",", request.ShopAppIdList));

            if (request.CategoryId is not null)
                flurlReq.SetQueryParam("categoryId", request.CategoryId);

            if (request.CategoryIdList is not null)
                flurlReq.SetQueryParam("category", string.Join(",", request.CategoryIdList));

            if (request.CategoryIdBlackList is not null)
                flurlReq.SetQueryParam("noCategory", string.Join(",", request.CategoryIdBlackList));

            if (request.ProductIdList is not null)
                flurlReq.SetQueryParam("productId", string.Join(",", request.ProductIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterProductListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/product/select 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/product/category.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterProductSelectResponse> ExecuteUnionPromoterProductSelectAsync(this WechatApiClient client, Models.UnionPromoterProductSelectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "product", "select")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("from", request.Offset)
                .SetQueryParam("limit", request.Limit);

            if (request.MaxPrice is not null)
                flurlReq.SetQueryParam("maxPrice", request.MaxPrice.Value);

            if (request.MinPrice is not null)
                flurlReq.SetQueryParam("minPrice", request.MinPrice.Value);

            if (request.MinCommissionValue is not null)
                flurlReq.SetQueryParam("minCommissionValue", request.MinCommissionValue.Value);

            if (request.MinCommissionRatio is not null)
                flurlReq.SetQueryParam("minCommissionRatio", request.MinCommissionRatio.Value);

            if (request.SortType is not null)
                flurlReq.SetQueryParam("sortType", request.SortType.Value);

            if (request.HasCoupon is not null)
                flurlReq.SetQueryParam("hasCoupon", request.HasCoupon.Value ? 1 : 0);

            if (request.ShopAppIdList is not null)
                flurlReq.SetQueryParam("shopAppIds", string.Join(",", request.ShopAppIdList));

            if (request.CategoryId is not null)
                flurlReq.SetQueryParam("categoryId", request.CategoryId);

            if (request.CategoryIdList is not null)
                flurlReq.SetQueryParam("category", string.Join(",", request.CategoryIdList));

            if (request.CategoryIdBlackList is not null)
                flurlReq.SetQueryParam("noCategory", string.Join(",", request.CategoryIdBlackList));

            if (request.ProductIdList is not null)
                flurlReq.SetQueryParam("productId", string.Join(",", request.ProductIdList));

            if (request.ShippingMethods is not null)
                flurlReq.SetQueryParam("shippingMethods", client.JsonSerializer.Serialize(request.ShippingMethods));

            if (request.AddressList is not null)
                flurlReq.SetQueryParam("addressList", client.JsonSerializer.Serialize(request.AddressList));

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterProductSelectResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/product/generate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/product/category.html#_3-%E8%8E%B7%E5%8F%96%E5%95%86%E5%93%81%E6%8E%A8%E5%B9%BF%E7%B4%A0%E6%9D%90 ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/product/category.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "product", "generate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterProductGenerateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/product/parse_tag 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/parse_tag.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterProductParseTagResponse> ExecuteUnionPromoterProductParseTagAsync(this WechatApiClient client, Models.UnionPromoterProductParseTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "product", "parse_tag")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterProductParseTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region OpenAccount
        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/open_account/bind 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/customized-userinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOpenAccountBindResponse> ExecuteUnionPromoterOpenAccountBindAsync(this WechatApiClient client, Models.UnionPromoterOpenAccountBindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "open_account", "bind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOpenAccountBindResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/open_account/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/customized-userinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOpenAccountGetResponse> ExecuteUnionPromoterOpenAccountGetAsync(this WechatApiClient client, Models.UnionPromoterOpenAccountGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "open_account", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOpenAccountGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/open_account/add_customize_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/customized-userinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOpenAccountAddCustomizeInfoResponse> ExecuteUnionPromoterOpenAccountAddCustomizeInfoAsync(this WechatApiClient client, Models.UnionPromoterOpenAccountAddCustomizeInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "open_account", "add_customize_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOpenAccountAddCustomizeInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/open_account/del_customize_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/customized-userinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOpenAccountDeleteCustomizeInfoResponse> ExecuteUnionPromoterOpenAccountDeleteCustomizeInfoAsync(this WechatApiClient client, Models.UnionPromoterOpenAccountDeleteCustomizeInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "open_account", "del_customize_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOpenAccountDeleteCustomizeInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/open_account/get_customize_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/customized-userinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOpenAccountGetCustomizeInfoResponse> ExecuteUnionPromoterOpenAccountGetCustomizeInfoAsync(this WechatApiClient client, Models.UnionPromoterOpenAccountGetCustomizeInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "open_account", "get_customize_info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("unionid", request.UnionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOpenAccountGetCustomizeInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region OpenProduct
        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/open_product/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/promoter/openproduct.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOpenProductListResponse> ExecuteUnionPromoterOpenProductListAsync(this WechatApiClient client, Models.UnionPromoterOpenProductListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "open_product", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("from", request.Offset)
                .SetQueryParam("limit", request.Limit);

            if (request.QueryType is not null)
                flurlReq.SetQueryParam("queryType", request.QueryType.Value);

            if (request.Query is not null)
                flurlReq.SetQueryParam("query", request.Query);

            if (request.MaxPrice is not null)
                flurlReq.SetQueryParam("maxPrice", request.MaxPrice.Value);

            if (request.MinPrice is not null)
                flurlReq.SetQueryParam("minPrice", request.MinPrice.Value);

            if (request.MinCommissionValue is not null)
                flurlReq.SetQueryParam("minCommissionValue", request.MinCommissionValue.Value);

            if (request.MinCommissionRatio is not null)
                flurlReq.SetQueryParam("minCommissionRatio", request.MinCommissionRatio.Value);

            if (request.SortType is not null)
                flurlReq.SetQueryParam("sortType", request.SortType.Value);

            if (request.ShopAppIdList is not null)
                flurlReq.SetQueryParam("shopAppIds", string.Join(",", request.ShopAppIdList));

            if (request.CategoryId is not null)
                flurlReq.SetQueryParam("categoryId", request.CategoryId);

            if (request.CategoryIdList is not null)
                flurlReq.SetQueryParam("category", string.Join(",", request.CategoryIdList));

            if (request.CategoryIdBlackList is not null)
                flurlReq.SetQueryParam("noCategory", string.Join(",", request.CategoryIdBlackList));

            if (request.ProductIdList is not null)
                flurlReq.SetQueryParam("productId", string.Join(",", request.ProductIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOpenProductListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/open_product/generate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/promoter/openpromotion.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOpenProductGenerateResponse> ExecuteUnionPromoterOpenProductGenerateAsync(this WechatApiClient client, Models.UnionPromoterOpenProductGenerateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "open_product", "generate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOpenProductGenerateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/order/info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/order/order-info.html#_1-%E6%A0%B9%E6%8D%AE%E8%AE%A2%E5%8D%95ID%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E8%AF%A6%E6%83%85 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "order", "info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOrderInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/order/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/ministore/union/access-guidelines/promoter/api/order/order-info.html#_2-%E6%A0%B9%E6%8D%AE%E8%AE%A2%E5%8D%95%E6%94%AF%E4%BB%98%E6%97%B6%E9%97%B4%E3%80%81%E8%AE%A2%E5%8D%95%E5%88%86%E4%BD%A3%E7%8A%B6%E6%80%81%E6%8B%89%E5%8F%96%E8%AE%A2%E5%8D%95%E8%AF%A6%E6%83%85 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "order", "search")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("page", request.Page);

            if (request.StartTimestamp is not null)
                flurlReq.SetQueryParam("startTimestamp", request.StartTimestamp.Value);

            if (request.EndTimestamp is not null)
                flurlReq.SetQueryParam("endTimestamp", request.EndTimestamp.Value);

            if (request.CommissionStatus is not null)
                flurlReq.SetQueryParam("commissionStatus", request.CommissionStatus);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOrderSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/order/search_normal_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/promoter/order-info.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterOrderSearchNormalOrderResponse> ExecuteUnionPromoterOrderSearchNormalOrderAsync(this WechatApiClient client, Models.UnionPromoterOrderSearchNormalOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "order", "search_normal_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            if (request.Query is not null)
                flurlReq.SetQueryParam("query", request.Query);

            if (request.OrderId is not null)
                flurlReq.SetQueryParam("orderId", request.OrderId.Value);

            if (request.OutOrderId is not null)
                flurlReq.SetQueryParam("outOrderId", request.OutOrderId);

            if (request.OutOrderIdList is not null)
                flurlReq.SetQueryParam("outOrderIdList", string.Join(",", request.OutOrderId));

            if (request.TransactionId is not null)
                flurlReq.SetQueryParam("tradeNo", request.TransactionId);

            if (request.TransactionIdList is not null)
                flurlReq.SetQueryParam("transactionIdList", string.Join(",", request.TransactionIdList));

            if (request.StartPayTimestamp is not null)
                flurlReq.SetQueryParam("startPayTime", request.StartPayTimestamp.Value);

            if (request.EndPayTimestamp is not null)
                flurlReq.SetQueryParam("endPayTime", request.EndPayTimestamp.Value);

            if (request.CommissionStatus is not null)
                flurlReq.SetQueryParam("commissionStatus", request.CommissionStatus);

            if (request.StartStatusUpdateTimestamp is not null)
                flurlReq.SetQueryParam("startStatusUpdateTime", request.StartStatusUpdateTimestamp.Value);

            if (request.EndStatusUpdateTimestamp is not null)
                flurlReq.SetQueryParam("endStatusUpdateTime", request.EndStatusUpdateTimestamp.Value);

            if (request.SortBy is not null)
                flurlReq.SetQueryParam("sortBy", request.SortBy);

            if (request.SortOrder is not null)
                flurlReq.SetQueryParam("sortOrder", request.SortOrder);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterOrderSearchNormalOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Target
        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/target/plan_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/target_plan/target_plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterTargetPlanInfoResponse> ExecuteUnionPromoterTargetPlanInfoAsync(this WechatApiClient client, Models.UnionPromoterTargetPlanInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "target", "plan_info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("planInvitationUrl", request.PlanInvitaionUrl);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterTargetPlanInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/promoter/target/apply_target 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/target_plan/target_plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterTargetApplyTargetResponse> ExecuteUnionPromoterTargetApplyTargetAsync(this WechatApiClient client, Models.UnionPromoterTargetApplyTargetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "promoter", "target", "apply_target")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterTargetApplyTargetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/promoter/target/apply_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/access-guidelines/promoter/api/target_plan/target_plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionPromoterTargetApplyStatusResponse> ExecuteUnionPromoterTargetApplyStatusAsync(this WechatApiClient client, Models.UnionPromoterTargetApplyStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "promoter", "target", "apply_status")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("planId", request.PlanId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionPromoterTargetApplyStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
