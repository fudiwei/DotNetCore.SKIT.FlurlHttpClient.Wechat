using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteProductExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /product/img/upload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/register/uploadimg.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductImageUploadResponse> ExecuteProductImageUploadAsync(this WechatApiClient client, Models.ProductImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "img", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("resp_type", request.ResponseType);

            if (!string.IsNullOrEmpty(request.ImageUrl))
            {
                flurlReq.SetQueryParam("upload_type", 1)
                        .SetQueryParam("img_url", request.ImageUrl);

                return await client.SendRequestWithJsonAsync<Models.ProductImageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            }
            else
            {
                flurlReq.SetQueryParam("upload_type", 0)
                        .SetQueryParam("height", request.Height)
                        .SetQueryParam("width", request.Width);

                string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
                using var httpContent = new MultipartFormDataContent(boundary);
                using var fileContent = new ByteArrayContent(request.ImageFileBytes ?? new byte[0]);
                httpContent.Add(fileContent, "\"media\"", "\"image.png\"");
                httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/png");
                fileContent.Headers.ContentLength = request.ImageFileBytes?.Length;

                return await client.SendRequestAsync<Models.ProductImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
            }
        }

        #region Register
        /// <summary>
        /// <para>异步调用 [POST] /product/register/check_audit_status 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/register/check_audit_status.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductRegisterCheckAuditStatusResponse> ExecuteProductRegisterCheckAuditStatusAsync(this WechatApiClient client, Models.ProductRegisterCheckAuditStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "register", "check_audit_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductRegisterCheckAuditStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/register/register_shop 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/register/register_shop.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductRegisterRegisterShopResponse> ExecuteProductRegisterRegisterShopAsync(this WechatApiClient client, Models.ProductRegisterRegisterShopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "register", "register_shop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductRegisterRegisterShopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/register/submit_merchantinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/register/register_shop.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductRegisterSubmitMerchantInfoResponse> ExecuteProductRegisterSubmitMerchantInfoAsync(this WechatApiClient client, Models.ProductRegisterSubmitMerchantInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "register", "submit_merchantinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductRegisterSubmitMerchantInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/register/submit_basicinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/register/register_shop.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductRegisterSubmitBasicInfoResponse> ExecuteProductRegisterSubmitBasicInfoAsync(this WechatApiClient client, Models.ProductRegisterSubmitBasicInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "register", "submit_basicinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductRegisterSubmitBasicInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Service
        /// <summary>
        /// <para>异步调用 [POST] /product/service/check_auth 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/service/check_auth.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductServiceCheckAuthResponse> ExecuteProductServiceCheckAuthAsync(this WechatApiClient client, Models.ProductServiceCheckAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "service", "check_auth")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductServiceCheckAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/service/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/service/get_service_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductServiceGetListResponse> ExecuteProductServiceGetListAsync(this WechatApiClient client, Models.ProductServiceGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "service", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductServiceGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/service/get_order_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/service/get_service_order_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductServiceGetOrderListResponse> ExecuteProductServiceGetOrderListAsync(this WechatApiClient client, Models.ProductServiceGetOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "service", "get_order_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductServiceGetOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Decoration
        /// <summary>
        /// <para>异步调用 [POST] /product/decoration/decoration_service 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/service/decoration/decoration_service.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDecorationDecorationServiceResponse> ExecuteProductDecorationDecorationServiceAsync(this WechatApiClient client, Models.ProductDecorationDecorationServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "decoration", "decoration_service")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDecorationDecorationServiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/decoration/decoration_service_experience 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/service/decoration/decoration_service_experience.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDecorationDecorationServiceExperienceResponse> ExecuteProductDecorationDecorationServiceExperienceAsync(this WechatApiClient client, Models.ProductDecorationDecorationServiceExperienceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "decoration", "decoration_service_experience")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDecorationDecorationServiceExperienceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/decoration/wxaproduct_decoration_check_status 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/service/decoration/decoration_check_status.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDecorationWxaProductDecorationCheckStatusResponse> ExecuteProductDecorationWxaProductDecorationCheckStatusAsync(this WechatApiClient client, Models.ProductDecorationWxaProductDecorationCheckStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "decoration", "wxaproduct_decoration_check_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDecorationWxaProductDecorationCheckStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/decoration/wxaproduct_decoration_pressure_test 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/service/decoration/decoration_pressure_test.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDecorationWxaProductDecorationPressureTestResponse> ExecuteProductDecorationWxaProductDecorationPressureTestAsync(this WechatApiClient client, Models.ProductDecorationWxaProductDecorationPressureTestRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "decoration", "wxaproduct_decoration_pressure_test")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDecorationWxaProductDecorationPressureTestResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/decoration/wxaproduct_decoration_query_pressure_test_status 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/service/decoration/decoration_query_pressure_test_status.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDecorationWxaProductDecorationQueryPressureTestStatusResponse> ExecuteProductDecorationWxaProductDecorationQueryPressureTestStatusAsync(this WechatApiClient client, Models.ProductDecorationWxaProductDecorationQueryPressureTestStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "decoration", "wxaproduct_decoration_query_pressure_test_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDecorationWxaProductDecorationQueryPressureTestStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/decoration/wxaproduct_decoration_get_pressure_test_report 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/service/decoration/decoration_get_pressure_test_report.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDecorationWxaProductDecorationGetPressureTestReportResponse> ExecuteProductDecorationWxaProductDecorationGetPressureTestReportAsync(this WechatApiClient client, Models.ProductDecorationWxaProductDecorationGetPressureTestReportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "decoration", "wxaproduct_decoration_get_pressure_test_report")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDecorationWxaProductDecorationGetPressureTestReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Category
        /// <summary>
        /// <para>异步调用 [POST] /product/category/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/cat/get_cat_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCategoryGetResponse> ExecuteProductCategoryGetAsync(this WechatApiClient client, Models.ProductCategoryGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "category", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductCategoryGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Brand
        /// <summary>
        /// <para>异步调用 [POST] /product/brand/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/cat/get_brand.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductBrandGetResponse> ExecuteProductBrandGetAsync(this WechatApiClient client, Models.ProductBrandGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "brand", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductBrandGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Delivery
        /// <summary>
        /// <para>异步调用 [POST] /product/delivery/get_company_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/delivery/get_delivery_company_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDeliveryGetCompanyListResponse> ExecuteProductDeliveryGetCompanyListAsync(this WechatApiClient client, Models.ProductDeliveryGetCompanyListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "delivery", "get_company_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDeliveryGetCompanyListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/delivery/send 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/delivery/send_delivery.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDeliverySendResponse> ExecuteProductDeliverySendAsync(this WechatApiClient client, Models.ProductDeliverySendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "delivery", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDeliverySendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region DeliveryFreightTemplate
        /// <summary>
        /// <para>异步调用 [POST] /product/delivery/get_freight_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/cat/get_freight_template.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/freight/get_freight_template.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDeliveryGetFreightTemplateResponse> ExecuteProductDeliveryGetFreightTemplateAsync(this WechatApiClient client, Models.ProductDeliveryGetFreightTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "delivery", "get_freight_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDeliveryGetFreightTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/delivery/insert_freight_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/freight/insert_freight_template.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDeliveryInsertFreightTemplateResponse> ExecuteProductDeliveryInsertFreightTemplateAsync(this WechatApiClient client, Models.ProductDeliveryInsertFreightTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "delivery", "insert_freight_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDeliveryInsertFreightTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/delivery/update_freight_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/freight/update_freight_template.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDeliveryUpdateFreightTemplateResponse> ExecuteProductDeliveryUpdateFreightTemplateAsync(this WechatApiClient client, Models.ProductDeliveryUpdateFreightTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "delivery", "update_freight_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDeliveryUpdateFreightTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region ShipMethods
        /// <summary>
        /// <para>异步调用 [POST] /product/shipmethods/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/ship/get_shipping_methods.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductShipMethodsGetResponse> ExecuteProductShipMethodsGetAsync(this WechatApiClient client, Models.ProductShipMethodsGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "shipmethods", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductShipMethodsGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/shipmethods/set 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/ship/set_shipping_methods.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductShipMethodsSetResponse> ExecuteProductShipMethodsSetAsync(this WechatApiClient client, Models.ProductShipMethodsSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "shipmethods", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductShipMethodsSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Offline
        /// <summary>
        /// <para>异步调用 [POST] /product/offline/get_pickup_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/offline/get_pickup_template.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOfflineGetPickupTemplateResponse> ExecuteProductOfflineGetPickupTemplateAsync(this WechatApiClient client, Models.ProductOfflineGetPickupTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "offline", "get_pickup_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOfflineGetPickupTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/offline/update_pickup_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/offline/update_pickup_template.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOfflineUpdatePickupTemplateResponse> ExecuteProductOfflineUpdatePickupTemplateAsync(this WechatApiClient client, Models.ProductOfflineUpdatePickupTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "offline", "update_pickup_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOfflineUpdatePickupTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/offline/get_same_city_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/offline/get_same_city_template.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOfflineGetSameCityTemplateResponse> ExecuteProductOfflineGetSameCityTemplateAsync(this WechatApiClient client, Models.ProductOfflineGetSameCityTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "offline", "get_same_city_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOfflineGetSameCityTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/offline/update_same_city_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/offline/update_same_city_template.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOfflineUpdateSameCityTemplateResponse> ExecuteProductOfflineUpdateSameCityTemplateAsync(this WechatApiClient client, Models.ProductOfflineUpdateSameCityTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "offline", "update_same_city_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOfflineUpdateSameCityTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region SPU
        /// <summary>
        /// <para>异步调用 [POST] /product/spu/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/add_spu.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSPUAddResponse> ExecuteProductSPUAddAsync(this WechatApiClient client, Models.ProductSPUAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "spu", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSPUAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/spu/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/del_spu.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSPUDeleteResponse> ExecuteProductSPUDeleteAsync(this WechatApiClient client, Models.ProductSPUDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "spu", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSPUDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/spu/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/get_spu.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSPUGetResponse> ExecuteProductSPUGetAsync(this WechatApiClient client, Models.ProductSPUGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "spu", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSPUGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/spu/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/get_spu_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSPUGetListResponse> ExecuteProductSPUGetListAsync(this WechatApiClient client, Models.ProductSPUGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "spu", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSPUGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/spu/search 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/search_spu.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSPUSearchResponse> ExecuteProductSPUSearchAsync(this WechatApiClient client, Models.ProductSPUSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "spu", "search")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSPUSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/spu/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/up_spu.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSPUUpdateResponse> ExecuteProductSPUUpdateAsync(this WechatApiClient client, Models.ProductSPUUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "spu", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSPUUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/spu/listing 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/up_spu_listing.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSPUListingResponse> ExecuteProductSPUListingAsync(this WechatApiClient client, Models.ProductSPUListingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "spu", "listing")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSPUListingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/spu/delisting 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/up_spu_delisting.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSPUDelistingResponse> ExecuteProductSPUDelistingAsync(this WechatApiClient client, Models.ProductSPUDelistingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "spu", "delisting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSPUDelistingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region SKU
        /// <summary>
        /// <para>异步调用 [POST] /product/sku/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/sku/add_sku.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSKUAddResponse> ExecuteProductSKUAddAsync(this WechatApiClient client, Models.ProductSKUAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "sku", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSKUAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/sku/batch_add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/sku/batch_add_sku.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSKUBatchAddResponse> ExecuteProductSKUBatchAddAsync(this WechatApiClient client, Models.ProductSKUBatchAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "sku", "batch_add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSKUBatchAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/sku/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/sku/del_sku.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSKUDeleteResponse> ExecuteProductSKUDeleteAsync(this WechatApiClient client, Models.ProductSKUDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "sku", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSKUDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/sku/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/sku/get_sku.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSKUGetResponse> ExecuteProductSKUGetAsync(this WechatApiClient client, Models.ProductSKUGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "sku", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSKUGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/sku/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/sku/get_sku_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSKUGetListResponse> ExecuteProductSKUGetListAsync(this WechatApiClient client, Models.ProductSKUGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "sku", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSKUGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/sku/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/sku/up_sku.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSKUUpdateResponse> ExecuteProductSKUUpdateAsync(this WechatApiClient client, Models.ProductSKUUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "sku", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSKUUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/sku/update_price 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/sku/up_sku_price.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSKUUpdatePriceResponse> ExecuteProductSKUUpdatePriceAsync(this WechatApiClient client, Models.ProductSKUUpdatePriceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "sku", "update_price")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSKUUpdatePriceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region LimitedDiscount
        /// <summary>
        /// <para>异步调用 [POST] /product/limiteddiscount/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/add_limiteddiscount.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductLimitedDiscountAddResponse> ExecuteProductLimitedDiscountAddAsync(this WechatApiClient client, Models.ProductLimitedDiscountAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "limiteddiscount", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductLimitedDiscountAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/limiteddiscount/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/get_limiteddiscount_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductLimitedDiscountGetListResponse> ExecuteProductLimitedDiscountGetListAsync(this WechatApiClient client, Models.ProductLimitedDiscountGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "limiteddiscount", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductLimitedDiscountGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/limiteddiscount/update_status 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/spu/update_limiteddiscount_status.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductLimitedDiscountUpdateStatusResponse> ExecuteProductLimitedDiscountUpdateStatusAsync(this WechatApiClient client, Models.ProductLimitedDiscountUpdateStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "limiteddiscount", "update_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductLimitedDiscountUpdateStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Stock
        /// <summary>
        /// <para>异步调用 [POST] /product/stock/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/sku/get_stock.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductStockGetResponse> ExecuteProductStockGetAsync(this WechatApiClient client, Models.ProductStockGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "stock", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductStockGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/stock/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/sku/up_stock.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductStockUpdateResponse> ExecuteProductStockUpdateAsync(this WechatApiClient client, Models.ProductStockUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "stock", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductStockUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Store
        /// <summary>
        /// <para>异步调用 [POST] /product/store/get_shopcat 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/store/get_shopcat.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductStoreGetShopCategoryResponse> ExecuteProductStoreGetShopCategoryAsync(this WechatApiClient client, Models.ProductStoreGetShopCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "store", "get_shopcat")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductStoreGetShopCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/store/get_info 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/store/get_store_info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductStoreGetInfoResponse> ExecuteProductStoreGetInfoAsync(this WechatApiClient client, Models.ProductStoreGetInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "store", "get_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductStoreGetInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Address
        /// <summary>
        /// <para>异步调用 [POST] /product/address/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/address/add_address.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductAddressAddResponse> ExecuteProductAddressAddAsync(this WechatApiClient client, Models.ProductAddressAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "address", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductAddressAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/address/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/address/delete_address.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductAddressDeleteResponse> ExecuteProductAddressDeleteAsync(this WechatApiClient client, Models.ProductAddressDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "address", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductAddressDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/address/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/address/get_address.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductAddressGetResponse> ExecuteProductAddressGetAsync(this WechatApiClient client, Models.ProductAddressGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "address", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductAddressGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/address/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/address/update_address.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductAddressUpdateResponse> ExecuteProductAddressUpdateAsync(this WechatApiClient client, Models.ProductAddressUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "address", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductAddressUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /product/order/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/order/get_order_list.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/order/get_order_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOrderGetListResponse> ExecuteProductOrderGetListAsync(this WechatApiClient client, Models.ProductOrderGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "order", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOrderGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/order/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/order/get_order_detail.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/order/get_order_detail.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOrderGetResponse> ExecuteProductOrderGetAsync(this WechatApiClient client, Models.ProductOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/order/search 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/order/search_order.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/order/search_order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOrderSearchResponse> ExecuteProductOrderSearchAsync(this WechatApiClient client, Models.ProductOrderSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "order", "search")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOrderSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/order/change_order_price 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/order/change_order_price.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOrderChangeOrderPriceResponse> ExecuteProductOrderChangeOrderPriceAsync(this WechatApiClient client, Models.ProductOrderChangeOrderPriceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "order", "change_order_price")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOrderChangeOrderPriceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/order/change_merchant_notes 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/order/change_merchant_notes.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOrderChangeMerchantNotesResponse> ExecuteProductOrderChangeMerchantNotesAsync(this WechatApiClient client, Models.ProductOrderChangeMerchantNotesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "order", "change_merchant_notes")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOrderChangeMerchantNotesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Aftersale
        /// <summary>
        /// <para>异步调用 [POST] /product/order/batchgetaftersaleorder 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/order/batchgetaftersaleorder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOrderBatchGetAftersaleOrderResponse> ExecuteProductOrderBatchGetAftersaleOrderAsync(this WechatApiClient client, Models.ProductOrderBatchGetAftersaleOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "order", "batchgetaftersaleorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOrderBatchGetAftersaleOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /product/order/getaftersaleorder 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/order/getaftersaleorder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOrderGetAftersaleOrderResponse> ExecuteProductOrderGetAftersaleOrderAsync(this WechatApiClient client, Models.ProductOrderGetAftersaleOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "order", "getaftersaleorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOrderGetAftersaleOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/order/acceptapply 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/order/acceptapply.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOrderAcceptApplyResponse> ExecuteProductOrderAcceptApplyAsync(this WechatApiClient client, Models.ProductOrderAcceptApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "order", "acceptapply")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOrderAcceptApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/order/rejectrefund 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/order/rejectrefund.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductOrderRejectRefundResponse> ExecuteProductOrderRejectRefundAsync(this WechatApiClient client, Models.ProductOrderRejectRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "order", "rejectrefund")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductOrderRejectRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Coupon
        /// <summary>
        /// <para>异步调用 [POST] /product/coupon/create 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/coupon/create_coupon.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCouponCreateResponse> ExecuteProductCouponCreateAsync(this WechatApiClient client, Models.ProductCouponCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "coupon", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductCouponCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/coupon/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/coupon/update_coupon.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCouponUpdateResponse> ExecuteProductCouponUpdateAsync(this WechatApiClient client, Models.ProductCouponUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "coupon", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductCouponUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/coupon/update_status 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/coupon/update_coupon_status.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCouponUpdateStatusResponse> ExecuteProductCouponUpdateStatusAsync(this WechatApiClient client, Models.ProductCouponUpdateStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "coupon", "update_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductCouponUpdateStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/coupon/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/coupon/get.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCouponGetResponse> ExecuteProductCouponGetAsync(this WechatApiClient client, Models.ProductCouponGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "coupon", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductCouponGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/coupon/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/coupon/get_coupon.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCouponGetListResponse> ExecuteProductCouponGetListAsync(this WechatApiClient client, Models.ProductCouponGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "coupon", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductCouponGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/coupon/push 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/coupon/push_coupon.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCouponPushResponse> ExecuteProductCouponPushAsync(this WechatApiClient client, Models.ProductCouponPushRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "coupon", "push")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductCouponPushResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/coupon/get_user 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/coupon/get_user_coupon.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCouponGetUserResponse> ExecuteProductCouponGetUserAsync(this WechatApiClient client, Models.ProductCouponGetUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "coupon", "get_user")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductCouponGetUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Funds
        /// <summary>
        /// <para>异步调用 [POST] /product/funds/getbalance 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/funds/get_balance.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductFundsGetBalanceResponse> ExecuteProductFundsGetBalanceAsync(this WechatApiClient client, Models.ProductFundsGetBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "funds", "getbalance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductFundsGetBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/funds/scanorderflow 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/funds/scan_order_flow.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductFundsScanOrderFlowResponse> ExecuteProductFundsScanOrderFlowAsync(this WechatApiClient client, Models.ProductFundsScanOrderFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "funds", "scanorderflow")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductFundsScanOrderFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/funds/getorderflow 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/funds/get_order_flow.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductFundsGetOrderFlowResponse> ExecuteProductFundsGetOrderFlowAsync(this WechatApiClient client, Models.ProductFundsGetOrderFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "funds", "getorderflow")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductFundsGetOrderFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/funds/scanwithdraw 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/funds/scan_withdraw.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductFundsScanWithdrawResponse> ExecuteProductFundsScanWithdrawAsync(this WechatApiClient client, Models.ProductFundsScanWithdrawRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "funds", "scanwithdraw")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductFundsScanWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/funds/getwithdrawdetail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/funds/get_withdraw_detail.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductFundsGetWithdrawDetailResponse> ExecuteProductFundsGetWithdrawDetailAsync(this WechatApiClient client, Models.ProductFundsGetWithdrawDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "funds", "getwithdrawdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductFundsGetWithdrawDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/funds/setbankaccount 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent/API/funds/set_bank_account.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductFundsSetBankAccountResponse> ExecuteProductFundsSetBankAccountAsync(this WechatApiClient client, Models.ProductFundsSetBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "funds", "setbankaccount")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductFundsSetBankAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
