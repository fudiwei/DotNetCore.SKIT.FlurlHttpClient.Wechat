using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCardInvoiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/getauthurl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceGetAuthUrlResponse> ExecuteCardInvoiceGetAuthUrlAsync(this WechatApiClient client, Models.CardInvoiceGetAuthUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Timestamp == null)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "getauthurl")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceGetAuthUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/getauthdata 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#7 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#2.4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceGetAuthDataResponse> ExecuteCardInvoiceGetAuthDataAsync(this WechatApiClient client, Models.CardInvoiceGetAuthDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "getauthdata")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceGetAuthDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/rejectinsert 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#8 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#2.5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceRejectInsertResponse> ExecuteCardInvoiceRejectInsertAsync(this WechatApiClient client, Models.CardInvoiceRejectInsertRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "rejectinsert")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceRejectInsertResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/makeoutinvoice 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#14 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceMakeOutInvoiceResponse> ExecuteCardInvoiceMakeOutInvoiceAsync(this WechatApiClient client, Models.CardInvoiceMakeOutInvoiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "makeoutinvoice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceMakeOutInvoiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/clearoutinvoice 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#15 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceClearOutInvoiceResponse> ExecuteCardInvoiceClearOutInvoiceAsync(this WechatApiClient client, Models.CardInvoiceClearOutInvoiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "clearoutinvoice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceClearOutInvoiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/queryinvoceinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#16 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceQueryInvoiceInfoResponse> ExecuteCardInvoiceQueryInvoiceInfoAsync(this WechatApiClient client, Models.CardInvoiceQueryInvoiceInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "queryinvoceinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceQueryInvoiceInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/seturl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Invoicing_Platform_API_List.html#1 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#3.1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceSetUrlResponse> ExecuteCardInvoiceSetUrlAsync(this WechatApiClient client, Models.CardInvoiceSetUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "seturl")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceSetUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/insert 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Invoicing_Platform_API_List.html#5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceInsertResponse> ExecuteCardInvoiceInsertAsync(this WechatApiClient client, Models.CardInvoiceInsertRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.CardExtra != null && request.CardExtra.Nonce == null)
                request.CardExtra.Nonce = Guid.NewGuid().ToString("N");

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "insert")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceInsertResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region SetBusinessAttribute
        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/setbizattr?action=set_pay_mch 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#11 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceSetPayMerchantResponse> ExecuteCardInvoiceSetPayMerchantAsync(this WechatApiClient client, Models.CardInvoiceSetPayMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "setbizattr")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("action", "set_pay_mch");

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceSetPayMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/setbizattr?action=get_pay_mch 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#12 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceGetPayMerchantResponse> ExecuteCardInvoiceGetPayMerchantAsync(this WechatApiClient client, Models.CardInvoiceGetPayMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "setbizattr")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("action", "get_pay_mch");

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceGetPayMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/setbizattr?action=set_contact 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#17 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceSetContactResponse> ExecuteCardInvoiceSetContactAsync(this WechatApiClient client, Models.CardInvoiceSetContactRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "setbizattr")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("action", "set_contact");

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceSetContactResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/setbizattr?action=get_contact 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#18 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceGetContactResponse> ExecuteCardInvoiceGetContactAsync(this WechatApiClient client, Models.CardInvoiceGetContactRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "setbizattr")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("action", "get_contact");

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceGetContactResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/setbizattr?action=set_auth_field 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#9 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceSetAuthFieldResponse> ExecuteCardInvoiceSetAuthFieldAsync(this WechatApiClient client, Models.CardInvoiceSetAuthFieldRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "setbizattr")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("action", "set_auth_field");

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceSetAuthFieldResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/setbizattr?action=get_auth_field 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#10 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceGetAuthFieldResponse> ExecuteCardInvoiceGetAuthFieldAsync(this WechatApiClient client, Models.CardInvoiceGetAuthFieldRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "setbizattr")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("action", "get_auth_field");

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceGetAuthFieldResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Platform
        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/platform/createcard 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Invoicing_Platform_API_List.html#2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoicePlatformCreateCardResponse> ExecuteCardInvoicePlatformCreateCardAsync(this WechatApiClient client, Models.CardInvoicePlatformCreateCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "platform", "createcard")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoicePlatformCreateCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/platform/setpdf 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Invoicing_Platform_API_List.html#3 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#3.3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoicePlatformSetPdfResponse> ExecuteCardInvoicePlatformSetPdfAsync(this WechatApiClient client, Models.CardInvoicePlatformSetPdfRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "platform", "setpdf")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "invoice.pdf", fileBytes: request.FileBytes, fileContentType: "application/pdf", formDataName: "pdf");
            return await client.SendRequestAsync<Models.CardInvoicePlatformSetPdfResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/platform/getpdf 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Invoicing_Platform_API_List.html#4 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#3.4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoicePlatformGetPdfResponse> ExecuteCardInvoicePlatformGetPdfAsync(this WechatApiClient client, Models.CardInvoicePlatformGetPdfRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            request.Action = "get_url";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "platform", "getpdf")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoicePlatformGetPdfResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/platform/updatestatus 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Invoicing_Platform_API_List.html#6 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#3.7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoicePlatformUpdateStatusResponse> ExecuteCardInvoicePlatformUpdateStatusAsync(this WechatApiClient client, Models.CardInvoicePlatformUpdateStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "platform", "updatestatus")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoicePlatformUpdateStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Reimburse
        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/reimburse/getinvoiceinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Reimburser_API_List.html#5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceReimburseGetInvoiceInfoResponse> ExecuteCardInvoiceReimburseGetInvoiceInfoAsync(this WechatApiClient client, Models.CardInvoiceReimburseGetInvoiceInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "reimburse", "getinvoiceinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceReimburseGetInvoiceInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/reimburse/getinvoicebatch 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Reimburser_API_List.html#6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceReimburseGetInvoiceBatchResponse> ExecuteCardInvoiceReimburseGetInvoiceBatchAsync(this WechatApiClient client, Models.CardInvoiceReimburseGetInvoiceBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "reimburse", "getinvoicebatch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceReimburseGetInvoiceBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/reimburse/updatestatusbatch 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Reimburser_API_List.html#8 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceReimburseUpdateStatusBatchResponse> ExecuteCardInvoiceReimburseUpdateStatusBatchAsync(this WechatApiClient client, Models.CardInvoiceReimburseUpdateStatusBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "reimburse", "updatestatusbatch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceReimburseUpdateStatusBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/reimburse/updateinvoicestatus 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Reimburser_API_List.html#7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceReimburseUpdateInvoiceStatusResponse> ExecuteCardInvoiceReimburseUpdateInvoiceStatusAsync(this WechatApiClient client, Models.CardInvoiceReimburseUpdateInvoiceStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "reimburse", "updateinvoicestatus")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceReimburseUpdateInvoiceStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Quick
        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/biz/getusertitleurl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Quick_issuing/Interface_Instructions.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceBusinessGetUserTitleUrlResponse> ExecuteCardInvoiceBusinessGetUserTitleUrlAsync(this WechatApiClient client, Models.CardInvoiceBusinessGetUserTitleUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "biz", "getusertitleurl")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceBusinessGetUserTitleUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/biz/getselecttitleurl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Quick_issuing/Interface_Instructions.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceBusinessGetSelectTitleUrlResponse> ExecuteCardInvoiceBusinessGetSelectTitleUrlAsync(this WechatApiClient client, Models.CardInvoiceBusinessGetSelectTitleUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "biz", "getselecttitleurl")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceBusinessGetSelectTitleUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /card/invoice/scantitle 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Quick_issuing/Interface_Instructions.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CardInvoiceBusinessScanTitleResponse> ExecuteCardInvoiceBusinessScanTitleAsync(this WechatApiClient client, Models.CardInvoiceBusinessScanTitleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "card", "invoice", "scantitle")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CardInvoiceBusinessScanTitleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
