using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteTaxiInvoiceExtensions
    {
        #region TaxiCompany
        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/taxi-company/create-taxi-company 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/taxi-company/create-taxi-company.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTaxiInvoiceTaxiCompanyResponse> ExecuteCreateTaxiInvoiceTaxiCompanyAsync(this WechatTenpayClient client, Models.CreateTaxiInvoiceTaxiCompanyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "taxi-invoice", "taxi-company", "create-taxi-company");

            return await client.SendRequestWithJsonAsync<Models.CreateTaxiInvoiceTaxiCompanyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /taxi-invoice/taxi-companies/{company_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/taxi-company/query-taxi-company.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTaxiInvoiceTaxiCompanyResponse> ExecuteGetTaxiInvoiceTaxiCompanyAsync(this WechatTenpayClient client, Models.GetTaxiInvoiceTaxiCompanyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "taxi-invoice", "taxi-companies", request.CompanyMerchantId)
                .SetQueryParam("region_id", request.RegionId);

            return await client.SendRequestWithJsonAsync<Models.GetTaxiInvoiceTaxiCompanyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Taxi
        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/taxi/update-taxi 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/taxi/update-taxi.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateTaxiInvoiceTaxiResponse> ExecuteUpdateTaxiInvoiceTaxiAsync(this WechatTenpayClient client, Models.UpdateTaxiInvoiceTaxiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "taxi-invoice", "taxi", "update-taxi");

            return await client.SendRequestWithJsonAsync<Models.UpdateTaxiInvoiceTaxiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /taxi-invoice/taxies/{plate_number} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/taxi/query-taxi.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTaxiInvoiceTaxiResponse> ExecuteGetTaxiInvoiceTaxiAsync(this WechatTenpayClient client, Models.GetTaxiInvoiceTaxiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "taxi-invoice", "taxies", request.PlateNumber)
                .SetQueryParam("region_id", request.RegionId);

            return await client.SendRequestWithJsonAsync<Models.GetTaxiInvoiceTaxiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Driver
        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/driver/update-driver 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/driver/update-driver.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateTaxiInvoiceDriverResponse> ExecuteUpdateTaxiInvoiceDriverAsync(this WechatTenpayClient client, Models.UpdateTaxiInvoiceDriverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "taxi-invoice", "driver", "update-driver");

            return await client.SendRequestWithJsonAsync<Models.UpdateTaxiInvoiceDriverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /taxi-invoice/drivers/{driver_license} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/driver/query-driver.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTaxiInvoiceDriverResponse> ExecuteGetTaxiInvoiceDriverAsync(this WechatTenpayClient client, Models.GetTaxiInvoiceDriverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "taxi-invoice", "drivers", request.DriverLicenseNumber)
                .SetQueryParam("region_id", request.RegionId);

            return await client.SendRequestWithJsonAsync<Models.GetTaxiInvoiceDriverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Attendance
        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/attendance/punch 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/attendance/punch-attendance.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTaxiInvoicePunchAttendanceResponse> ExecuteCreateTaxiInvoicePunchAttendanceAsync(this WechatTenpayClient client, Models.CreateTaxiInvoicePunchAttendanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "taxi-invoice", "attendance", "punch");

            return await client.SendRequestWithJsonAsync<Models.CreateTaxiInvoicePunchAttendanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region UserTaxiOrder
        /// <summary>
        /// <para>异步调用 [GET] /taxi-invoice/user-taxi-order/find-by-token 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/user-taxi-order/query-user-taxi-order-by-token.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTaxiInvoiceUserTaxiOrderByTokenResponse> ExecuteGetTaxiInvoiceUserTaxiOrderByTokenAsync(this WechatTenpayClient client, Models.GetTaxiInvoiceUserTaxiOrderByTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "taxi-invoice", "user-taxi-order", "find-by-token")
                .SetQueryParam("token", request.Token)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("auth_mode", request.AuthMode)
                .SetQueryParam("region_id", request.RegionId);

            return await client.SendRequestWithJsonAsync<Models.GetTaxiInvoiceUserTaxiOrderByTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Card
        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/cards/upload-file 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/taxi-invoice-card/upload-taxi-invoice-card-file.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadTaxiInvoiceCardFileResponse> ExecuteUploadTaxiInvoiceCardFileAsync(this WechatTenpayClient client, Models.UploadTaxiInvoiceCardFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "taxi-invoice", "cards", "upload-file");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "file.pdf", fileBytes: request.FileBytes, fileContentType: "application/pdf", fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendRequestAsync<Models.UploadTaxiInvoiceCardFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/cards 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/taxi-fapiao/taxi-invoice-card/create-taxi-invoice-card.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTaxiInvoiceCardResponse> ExecuteCreateTaxiInvoiceCardAsync(this WechatTenpayClient client, Models.CreateTaxiInvoiceCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "taxi-invoice", "cards");

            return await client.SendRequestWithJsonAsync<Models.CreateTaxiInvoiceCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
