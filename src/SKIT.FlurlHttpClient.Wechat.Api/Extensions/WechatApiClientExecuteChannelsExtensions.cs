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
        #region ECBasics
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/img/upload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/basics/img_upload.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "basics", "img", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("resp_type", request.ResponseType);

            if (request.ImageUrl != null)
            {
                flurlReq.SetQueryParam("upload_type", 1)
                        .SetQueryParam("img_url", request.ImageUrl);

                return await client.SendRequestWithJsonAsync<Models.ChannelsECBasicsImageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            }
            else
            {
                flurlReq.SetQueryParam("upload_type", 0)
                        .SetQueryParam("height", request.Height)
                        .SetQueryParam("width", request.Width);

                using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "image.png", fileBytes: request.ImageFileBytes!, fileContentType: "image/png", formDataName: "media");
                return await client.SendRequestAsync<Models.ChannelsECBasicsImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
            }
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/basics/info/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/basics/getbasicinfo.html </para>
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
                .CreateRequest(request, HttpMethod.Get, "channels", "ec", "basics", "info", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBasicsInfoGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/qualification/upload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/basics/qualificationupload.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsQualificationUploadResponse> ExecuteChannelsECBasicsQualificationUploadAsync(this WechatApiClient client, Models.ChannelsECBasicsQualificationUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileContentType == null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "basics", "qualification", "upload")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendRequestAsync<Models.ChannelsECBasicsQualificationUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/addresscode/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/basics/getaddresscode.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "basics", "addresscode", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBasicsAddressCodeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/basics/media/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/basics/getdatabymediaid.html </para>
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
                .CreateRequest(request, HttpMethod.Get, "channels", "ec", "basics", "media", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBasicsMediaGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECCategory
        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/category/all 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/getallcategory.html </para>
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
                .CreateRequest(request, HttpMethod.Get, "channels", "ec", "category", "all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/detail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/getcategorydetail.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "category", "detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/availablesoncategories/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/getavailablesoncategories.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "category", "availablesoncategories", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryAvailableSonCategoriesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/add.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "category", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/audit/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/audit_get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "category", "audit", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryAuditGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/audit/cancel 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/cancelauditcategory.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "category", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/category/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/getavailablebizcat.html </para>
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
                .CreateRequest(request, HttpMethod.Get, "channels", "ec", "category", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECBrand
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/all 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/brand/all_get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "brand", "all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBrandAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/brand/add.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "brand", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBrandAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/brand/update.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "brand", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBrandUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/audit/cancel 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/brand/audit_cancel.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "brand", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBrandAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/brand/delete.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "brand", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBrandDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/brand/get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "brand", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBrandGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/brand/list_get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "brand", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECBrandListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECMerchant
        #region ECMerchant/FreightTemplate
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/getfreighttemplatelist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/deliverycompanylist_get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "getfreighttemplatelist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECMerchantGetFreightTemplateListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/getfreighttemplatedetail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/merchant/getfreighttemplatedetail.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "getfreighttemplatedetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECMerchantGetFreightTemplateDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/addfreighttemplate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/merchant/addfreighttemplate.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "addfreighttemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECMerchantAddFreightTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/updatefreighttemplate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/merchant/updatefreighttemplate.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "updatefreighttemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECMerchantUpdateFreightTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECMerchant/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/merchant/address/list.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECMerchantAddressListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/merchant/address/get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECMerchantAddressGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/merchant/address/add.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECMerchantAddressAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/merchant/address/update.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECMerchantAddressUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/merchant/address/delete.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECMerchantAddressDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region ECProduct
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/add.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/update.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/delete.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/list_get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/listing 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/listing.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "listing")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductListingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/delisting 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/delisting.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "delisting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductDelistingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/audit/cancel 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/audit_cancel.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/stock_update.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductStockUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/get_stock.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductStockGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ECProduct/LimitedDiscountTask
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/add.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductLimitedDiscountTaskAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/list_get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductLimitedDiscountTaskListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/stop 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/stop.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "stop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductLimitedDiscountTaskStopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/delete.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECProductLimitedDiscountTaskDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region ECOrder
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/search 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/search.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "order", "search")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECOrderSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/list_get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "order", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECOrderListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/price/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/price_update.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "order", "price", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECOrderPriceUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/merchantnotes/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/merchantnotes_update.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "order", "merchantnotes", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECOrderMerchantNotesUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/address/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/address_update.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "order", "address", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECOrderAddressUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ECOrder/Delivery
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/deliverycompanylist/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/deliverycompanylist_get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "order", "deliverycompanylist", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECOrderDeliveryCompanyListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/delivery/send 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/delivery_send.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "order", "delivery", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECOrderDeliverySendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region ECAftersale
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getaftersalelist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/aftersale/getaftersalelist.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getaftersalelist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECAftersaleGetAftersaleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getaftersaleorder 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/aftersale/getaftersaleorder.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getaftersaleorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECAftersaleGetAftersaleOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/acceptapply 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/aftersale/acceptapply.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "acceptapply")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECAftersaleAcceptApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/rejectapply 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/aftersale/rejectapply.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "rejectapply")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECAftersaleRejectApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/uploadrefundcertificate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/aftersale/uploadrefundcertificate.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "uploadrefundcertificate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECAftersaleUploadRefundCertificateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ECAftersale/Complaint
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/addcomplaintmaterial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/complaint/addcomplaintmaterial.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "addcomplaintmaterial")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECAftersaleAddComplaintMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/addcomplaintproof 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/complaint/addcomplaintproof.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "addcomplaintproof")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECAftersaleAddComplaintProofResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getcomplaintorder 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/complaint/getcomplaintorder.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getcomplaintorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECAftersaleGetComplaintOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region ECCoupon
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/create 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/coupon/create.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCouponCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/coupon/update.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCouponUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/update_status 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/coupon/update_status.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "update_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCouponUpdateStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/coupon/get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCouponGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/coupon/get_list.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCouponGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get_user_coupon_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/coupon/get_user_coupon_list.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get_user_coupon_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCouponGetUserCouponListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get_user_coupon 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/coupon/get_user_coupon.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get_user_coupon")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCouponGetUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECWarehouse
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/create 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/create.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/get_list.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/detail/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/update_detail.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "detail", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseDetailUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Warehouse/CoverLocation
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/coverlocations/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/add_coverlocations.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "coverlocations", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseCoverLocationsAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/coverlocations/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/del_coverlocations.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "coverlocations", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseCoverLocationsDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Warehouse/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/address/prioritysort/set 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/set_prioritysort.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "address", "prioritysort", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseAddressPrioritySortSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/address/prioritysort/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/get_prioritysort.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "address", "prioritysort", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseAddressPrioritySortGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Warehouse/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/stock/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/update_stock.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "stock", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseStockUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/stock/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/warehouse/get_stock.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "stock", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWarehouseStockGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region ECSharer
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/bind 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/sharer/bindsharer.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerBindResponse> ExecuteChannelsECSharerBindAsync(this WechatApiClient client, Models.ChannelsECSharerBindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "bind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECSharerBindResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/unbind 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/sharer/unbindsharer.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerUnbindResponse> ExecuteChannelsECSharerUnbindAsync(this WechatApiClient client, Models.ChannelsECSharerUnbindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "unbind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECSharerUnbindResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/search_sharer 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/sharer/search_sharer.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerSearchSharerResponse> ExecuteChannelsECSharerSearchSharerAsync(this WechatApiClient client, Models.ChannelsECSharerSearchSharerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "search_sharer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECSharerSearchSharerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerGetSharerListResponse> ExecuteChannelsECSharerGetSharerListAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECSharerGetSharerListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_order_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_order_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerGetSharerOrderListResponse> ExecuteChannelsECSharerGetSharerOrderListAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_order_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECSharerGetSharerOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECFunds
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getbalance 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/funds/getbalance.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getbalance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECFundsGetBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ECFunds/BankAccount
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getbankacct 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/funds/getbankacct.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getbankacct")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECFundsGetBankAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/setbankacct 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/funds/setbankacct.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "funds", "setbankacct")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECFundsSetBankAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECFunds/Withdraw
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getwithdrawdetail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/funds/getwithdrawdetail.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getwithdrawdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECGetWithdrawDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getwithdrawlist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/funds/getwithdrawlist.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getwithdrawlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECGetWithdrawListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/submitwithdraw 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/funds/submitwithdraw.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "funds", "submitwithdraw")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECFundsSubmitWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region ECLeague
        #region ECLeague/Funds
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/funds/getfundsflowdetail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getfundsflowdetail.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "funds", "getfundsflowdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueFundsGetFundsFlowDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/funds/getfundsflowlist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getfundsflowlist.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "funds", "getfundsflowlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueFundsGetFundsFlowListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECLeague/Promoter
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_addpromoter.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeaguePromoterAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/upd 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_updpromoter.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeaguePromoterUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_deletepromoter.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeaguePromoterDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getpromoter.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeaguePromoterGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getpromoterlist.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeaguePromoterListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECLeague/Item
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/batchadd 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_batchadditem.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "batchadd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueItemBatchAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/upd 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_upditem.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueItemUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_deleteitem.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueItemDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getitem.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueItemGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getitemlist.htmll </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueItemListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECLeague/HeadSupplier
        #region ECLeague/HeadSupplier/Funds
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/funds/balance/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getbalance.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "funds", "balance", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierFundsBalanceGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/funds/flowdetail/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getfundsflowdeatail.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "funds", "flowdetail", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierFundsFlowDetailGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/funds/flowlist/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getfundsflowlist.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "funds", "flowlist", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierFundsFlowListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECLeague/HeadSupplier/Shop
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/shop/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getshoplist.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "shop", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierShopListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/shop/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getshop.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "shop", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierShopGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECLeague/HeadSupplier/Item
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/item/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getitemlist.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "item", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierItemListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/item/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getitem.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "item", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierItemGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECLeague/HeadSupplier/Order
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/order/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getorderlist.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "order", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierOrderListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/order/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getorder.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECLeague/HeadSupplier/Window
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/windowproduct/add.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/remove 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/removewindow.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "remove")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowRemoveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/getall 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getallwindow.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "getall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowGetAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/getdetail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getwindowdetail.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "getdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowGetDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/windowauth/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getauth.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "windowauth", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowAuthGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/windowauth/status/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getauthstatus.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "windowauth", "status", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowAuthStatusGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion
        #endregion

        #region ECWindow
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/windowproduct/add.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWindowProductAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/off 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/windowproduct/off.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "off")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWindowProductOffResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/windowproduct/get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWindowProductGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/list/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/windowproduct/list_get.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWindowProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Leads
        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_info_by_component_id 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_info_by_component_id.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_info_by_component_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsLeadsGetLeadsInfoByComponentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_info_by_request_id 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_info_by_request_id.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_info_by_request_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsLeadsGetLeadsInfoByRequestIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_request_id 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_request_id.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_request_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsLeadsGetLeadsRequestIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
