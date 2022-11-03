using System;
using System.Net.Http;
using System.Net.Http.Headers;
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

                string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
                using var httpContent = new MultipartFormDataContent(boundary);
                using var fileContent = new ByteArrayContent(request.ImageFileBytes ?? Array.Empty<byte>());
                httpContent.Add(fileContent, "\"media\"", "\"image.png\"");
                httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/png");
                fileContent.Headers.ContentLength = request.ImageFileBytes?.Length;

                return await client.SendRequestAsync<Models.ChannelsECBasicsImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
            }
        }
        #endregion

        #region ECCategory
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
    }
}
