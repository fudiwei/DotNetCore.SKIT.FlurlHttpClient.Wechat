namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        #region ECBasics
        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/basics/img/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/resource/api_img_upload.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECBasicsImageUploadResponse> ExecuteShopECBasicsImageUploadAsync(this WechatApiClient client, Models.ShopECBasicsImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "basics", "img", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("resp_type", request.ResponseType);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("upload_type", 1)
                        .SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.ShopECBasicsImageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                flurlReq.SetQueryParam("upload_type", 0)
                        .SetQueryParam("height", request.Height)
                        .SetQueryParam("width", request.Width);

                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "media");
                return await client.SendFlurlRequestAsync<Models.ShopECBasicsImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/basics/img/uploadv2 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/resource/api_img_uploadv2.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECBasicsImageUploadV2Response> ExecuteShopECBasicsImageUploadV2Async(this WechatApiClient client, Models.ShopECBasicsImageUploadV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "basics", "img", "uploadv2")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("scene_type", request.SceneType);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("upload_type", 1)
                        .SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.ShopECBasicsImageUploadV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                flurlReq.SetQueryParam("upload_type", 0);

                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "media");
                return await client.SendFlurlRequestAsync<Models.ShopECBasicsImageUploadV2Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/basics/qualification/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/resource/api_qualificationupload.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECBasicsQualificationUploadResponse> ExecuteShopECBasicsQualificationUploadAsync(this WechatApiClient client, Models.ShopECBasicsQualificationUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
            {
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";
            }

            if (request.FileContentType is null)
            {
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName);
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "basics", "qualification", "upload")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.ShopECBasicsQualificationUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECBrand
        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/brand/all 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/api_getallbrandslogic.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECBrandAllResponse> ExecuteShopECBrandAllAsync(this WechatApiClient client, Models.ShopECBrandAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "brand", "all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopECBrandAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/brand/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/api_addbrandlogic.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECBrandAddResponse> ExecuteShopECBrandAddAsync(this WechatApiClient client, Models.ShopECBrandAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "brand", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopECBrandAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/brand/audit/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/brand/api_cancelauditbrandlogic.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECBrandAuditCancelResponse> ExecuteShopECBrandAuditCancelAsync(this WechatApiClient client, Models.ShopECBrandAuditCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "brand", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopECBrandAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region ECCategory
        /// <summary>
        /// <para>异步调用 [GET] /shop/ec/category/all 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/channels-shop-category/api_getallcategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECCategoryAllResponse> ExecuteShopECCategoryAllAsync(this WechatApiClient client, Models.ShopECCategoryAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "shop", "ec", "category", "all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopECCategoryAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/category/detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/channels-shop-category/api_getcategorydetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECCategoryDetailResponse> ExecuteShopECCategoryDetailAsync(this WechatApiClient client, Models.ShopECCategoryDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "category", "detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopECCategoryDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/category/audit/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/channels-shop-category/api_cancelauditcategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECCategoryAuditCancelResponse> ExecuteShopECCategoryAuditCancelAsync(this WechatApiClient client, Models.ShopECCategoryAuditCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "category", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopECCategoryAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/category/getcategoryrule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category-rule/api_get_category_rule.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category-rule/api_get_delivery_method_category_rule.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECCategoryGetCategoryRuleResponse> ExecuteShopECCategoryGetCategoryRuleAsync<TResponse>(this WechatApiClient client, Models.ShopECCategoryGetCategoryRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "category", "getcategoryrule")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("rule_id", request.RuleId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopECCategoryGetCategoryRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/ec/category/getcategoryproductrule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/category-rule/api_getcategoryproductrule.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopECCategoryGetCategoryProductRuleResponse> ExecuteShopECCategoryGetCategoryProductRuleAsync<TResponse>(this WechatApiClient client, Models.ShopECCategoryGetCategoryProductRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "ec", "category", "getcategoryproductrule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopECCategoryGetCategoryProductRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Funds
        #region Funds/Bank
        /// <summary>
        /// <para>异步调用 [POST] /shop/funds/getbanklist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/bank/api_ecgetbanklist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopFundsGetBankListResponse> ExecuteShopFundsGetBankListAsync(this WechatApiClient client, Models.ShopFundsGetBankListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "funds", "getbanklist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopFundsGetBankListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/funds/getbankbynum 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/bank/api_ecgetbankbynum.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopFundsGetBankByNumberResponse> ExecuteShopFundsGetBankByNumberAsync(this WechatApiClient client, Models.ShopFundsGetBankByNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "funds", "getbankbynum")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopFundsGetBankByNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/funds/getprovince 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/bank/api_ecgetprovince.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopFundsGetProvinceResponse> ExecuteShopFundsGetProvinceAsync(this WechatApiClient client, Models.ShopFundsGetProvinceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "funds", "getprovince")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopFundsGetProvinceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/funds/getcity 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/bank/api_ecgetcity.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopFundsGetCityResponse> ExecuteShopFundsGetCityAsync(this WechatApiClient client, Models.ShopFundsGetCityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "funds", "getcity")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopFundsGetCityResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/funds/getsubbranch 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/bank/api_ecgetsubbranch.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopFundsGetSubBranchResponse> ExecuteShopFundsGetSubBranchAsync(this WechatApiClient client, Models.ShopFundsGetSubBranchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "funds", "getsubbranch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopFundsGetSubBranchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Funds/Qrcode
        /// <summary>
        /// <para>异步调用 [POST] /shop/funds/qrcode/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/qrcode/api_ecgetqrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopFundsQrcodeGetResponse> ExecuteShopFundsQrcodeGetAsync(this WechatApiClient client, Models.ShopFundsQrcodeGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "funds", "qrcode", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopFundsQrcodeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/funds/qrcode/check 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/funds/qrcode/api_eccheckqrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopFundsQrcodeCheckResponse> ExecuteShopFundsQrcodeCheckAsync(this WechatApiClient client, Models.ShopFundsQrcodeCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "shop", "funds", "qrcode", "check")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShopFundsQrcodeCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion
    }
}
