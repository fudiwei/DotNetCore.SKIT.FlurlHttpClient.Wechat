using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinWxopenExtensions
    {
        #region Category
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/wxopen/getallcategories 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/category-management/getAllCategories.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenGetAllCategoriesResponse> ExecuteCgibinWxopenGetAllCategoriesAsync(this WechatApiClient client, Models.CgibinWxopenGetAllCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "wxopen", "getallcategories")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenGetAllCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/wxopen/getcategory 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/category-management/getSettingCategories.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenGetCategoryResponse> ExecuteCgibinWxopenGetCategoryAsync(this WechatApiClient client, Models.CgibinWxopenGetCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "wxopen", "getcategory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenGetCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/getcategoriesbytype 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/category-management/getAllCategoriesByType.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenGetCategoriesByTypeResponse> ExecuteCgibinWxopenGetCategoriesByTypeAsync(this WechatApiClient client, Models.CgibinWxopenGetCategoriesByTypeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "getcategoriesbytype")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenGetCategoriesByTypeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/addcategory 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/category-management/addCategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenAddCategoryResponse> ExecuteCgibinWxopenAddCategoryAsync(this WechatApiClient client, Models.CgibinWxopenAddCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "addcategory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenAddCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/deletecategory 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/category-management/deleteCategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenDeleteCategoryResponse> ExecuteCgibinWxopenDeleteCategoryAsync(this WechatApiClient client, Models.CgibinWxopenDeleteCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "deletecategory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenDeleteCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/modifycategory 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/category-management/modifyCategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenModifyCategoryResponse> ExecuteCgibinWxopenModifyCategoryAsync(this WechatApiClient client, Models.CgibinWxopenModifyCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "modifycategory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenModifyCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region QrcodeJump
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/qrcodejumpget 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/qrcode/qrcodejumpget.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/jumpqrcode-config/getJumpQRCode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/officalaccount-management/qrcode-config/getJumpQRCode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenQrcodeJumpGetResponse> ExecuteCgibinWxopenQrcodeJumpGetAsync(this WechatApiClient client, Models.CgibinWxopenQrcodeJumpGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "qrcodejumpget")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenQrcodeJumpGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/qrcodejumpdownload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/jumpqrcode-config/downloadQRCodeText.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenQrcodeJumpDownloadResponse> ExecuteCgibinWxopenQrcodeJumpDownloadAsync(this WechatApiClient client, Models.CgibinWxopenQrcodeJumpDownloadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "qrcodejumpdownload")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenQrcodeJumpDownloadResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/qrcodejumpadd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/qrcode/qrcodejumpadd.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/jumpqrcode-config/addJumpQRCode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/officalaccount-management/qrcode-config/addJumpQRCode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenQrcodeJumpAddResponse> ExecuteCgibinWxopenQrcodeJumpAddAsync(this WechatApiClient client, Models.CgibinWxopenQrcodeJumpAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "qrcodejumpadd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenQrcodeJumpAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/qrcodejumppublish 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/qrcode/qrcodejumppublish.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/jumpqrcode-config/publishJumpQRCode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/officalaccount-management/qrcode-config/publishJumpQRCode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenQrcodeJumpPublishResponse> ExecuteCgibinWxopenQrcodeJumpPublishAsync(this WechatApiClient client, Models.CgibinWxopenQrcodeJumpPublishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "qrcodejumppublish")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenQrcodeJumpPublishResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/qrcodejumpdelete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/qrcode/qrcodejumpdelete.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/jumpqrcode-config/deleteJumpQRCode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/officalaccount-management/qrcode-config/deleteJumpQRCode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenQrcodeJumpDeleteResponse> ExecuteCgibinWxopenQrcodeJumpDeleteAsync(this WechatApiClient client, Models.CgibinWxopenQrcodeJumpDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "qrcodejumpdelete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenQrcodeJumpDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region WeappSupportVersion
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/wxopen/getweappsupportversion 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/code-management/getSupportVersion.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenGetWeappSupportVersionResponse> ExecuteCgibinWxopenGetWeappSupportVersionAsync(this WechatApiClient client, Models.CgibinWxopenGetWeappSupportVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "wxopen", "getweappsupportversion")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenGetWeappSupportVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/setweappsupportversion 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/code-management/setSupportVersion.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenSetWeappSupportVersionResponse> ExecuteCgibinWxopenSetWeappSupportVersionAsync(this WechatApiClient client, Models.CgibinWxopenSetWeappSupportVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "setweappsupportversion")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenSetWeappSupportVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region WxaMpLink
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/wxamplinkget 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/officalaccount-management/link-miniprogram/getLinkMiniprogram.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenWxaMpLinkGetResponse> ExecuteCgibinWxopenWxaMpLinkGetAsync(this WechatApiClient client, Models.CgibinWxopenWxaMpLinkGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "wxamplinkget")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenWxaMpLinkGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/wxamplink 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/officalaccount-management/link-miniprogram/linkMiniprogram.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenWxaMpLinkResponse> ExecuteCgibinWxopenWxaMpLinkAsync(this WechatApiClient client, Models.CgibinWxopenWxaMpLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "wxamplink")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenWxaMpLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxopen/wxampunlink 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/officalaccount-management/link-miniprogram/unlinkMiniprogram.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxopenWxaMpUnlinkResponse> ExecuteCgibinWxopenWxaMpUnlinkAsync(this WechatApiClient client, Models.CgibinWxopenWxaMpUnlinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "wxopen", "wxampunlink")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinWxopenWxaMpUnlinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
