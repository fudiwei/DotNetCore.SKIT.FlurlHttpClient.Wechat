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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460154 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "taxi-invoice", "taxi-company", "create-taxi-company");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateTaxiInvoiceTaxiCompanyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /taxi-invoice/taxi-companies/{company_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460161 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "taxi-invoice", "taxi-companies", request.CompanyMerchantId)
                .SetQueryParam("region_id", request.RegionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetTaxiInvoiceTaxiCompanyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Taxi
        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/taxi/update-taxi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460167 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "taxi-invoice", "taxi", "update-taxi");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateTaxiInvoiceTaxiResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /taxi-invoice/taxies/{plate_number} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460169 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "taxi-invoice", "taxies", request.PlateNumber)
                .SetQueryParam("region_id", request.RegionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetTaxiInvoiceTaxiResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Driver
        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/driver/update-driver 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460171 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "taxi-invoice", "driver", "update-driver");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateTaxiInvoiceDriverResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /taxi-invoice/drivers/{driver_license} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012461309 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "taxi-invoice", "drivers", request.DriverLicenseNumber)
                .SetQueryParam("region_id", request.RegionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetTaxiInvoiceDriverResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Attendance
        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/attendance/punch 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012461368 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "taxi-invoice", "attendance", "punch");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateTaxiInvoicePunchAttendanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region UserTaxiOrder
        /// <summary>
        /// <para>异步调用 [GET] /taxi-invoice/user-taxi-order/find-by-token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460180 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "taxi-invoice", "user-taxi-order", "find-by-token")
                .SetQueryParam("token", request.Token)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("auth_mode", request.AuthMode)
                .SetQueryParam("region_id", request.RegionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetTaxiInvoiceUserTaxiOrderByTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Card
        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/cards/upload-file 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012692904 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "taxi-invoice", "cards", "upload-file");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "file.pdf", fileBytes: request.FileBytes, fileContentType: "application/pdf", fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendFlurlRequestAsync<Models.UploadTaxiInvoiceCardFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /taxi-invoice/cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012461432 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "taxi-invoice", "cards");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateTaxiInvoiceCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
