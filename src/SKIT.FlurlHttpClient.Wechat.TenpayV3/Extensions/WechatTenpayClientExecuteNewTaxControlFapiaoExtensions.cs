using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供电子发票相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteNewTaxControlFapiaoExtensions
    {
        #region CardTemplate
        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/card-template 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateNewTaxControlFapiaoCardTemplateResponse> ExecuteCreateNewTaxControlFapiaoCardTemplateAsync(this WechatTenpayClient client, Models.CreateNewTaxControlFapiaoCardTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "card-template");

            return await client.SendRequestWithJsonAsync<Models.CreateNewTaxControlFapiaoCardTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Merchant
        /// <summary>
        /// <para>异步调用 [PATCH] /new-tax-control-fapiao/merchant/development-config 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_18.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyNewTaxControlFapiaoMerchantDevelopmentConfigResponse> ExecuteModifyNewTaxControlFapiaoMerchantDevelopmentConfigAsync(this WechatTenpayClient client, Models.ModifyNewTaxControlFapiaoMerchantDevelopmentConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, new HttpMethod("PATCH"), "new-tax-control-fapiao", "merchant", "development-config");

            return await client.SendRequestWithJsonAsync<Models.ModifyNewTaxControlFapiaoMerchantDevelopmentConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/merchant/development-config 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_18.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetNewTaxControlFapiaoMerchantDevelopmentConfigResponse> ExecuteGetNewTaxControlFapiaoMerchantDevelopmentConfigAsync(this WechatTenpayClient client, Models.GetNewTaxControlFapiaoMerchantDevelopmentConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "merchant", "development-config");

            return await client.SendRequestWithJsonAsync<Models.GetNewTaxControlFapiaoMerchantDevelopmentConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/merchant/base-information 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetNewTaxControlFapiaoMerchantBaseInformationResponse> ExecuteGetNewTaxControlFapiaoMerchantBaseInformationAsync(this WechatTenpayClient client, Models.GetNewTaxControlFapiaoMerchantBaseInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "merchant", "base-information");

            return await client.SendRequestWithJsonAsync<Models.GetNewTaxControlFapiaoMerchantBaseInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/merchant/tax-codes 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryNewTaxControlFapiaoMerchantTaxCodesResponse> ExecuteQueryNewTaxControlFapiaoMerchantTaxCodesAsync(this WechatTenpayClient client, Models.QueryNewTaxControlFapiaoMerchantTaxCodesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "merchant", "tax-codes")
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendRequestWithJsonAsync<Models.QueryNewTaxControlFapiaoMerchantTaxCodesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region UserTitle
        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/user-title/title-url 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetNewTaxControlFapiaoUserTitleUrlResponse> ExecuteGetNewTaxControlFapiaoUserTitleUrlAsync(this WechatTenpayClient client, Models.GetNewTaxControlFapiaoUserTitleUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "user-title", "title-url")
                .SetQueryParam("fapiao_apply_id", request.FapiaoApplyId)
                .SetQueryParam("source", request.Source)
                .SetQueryParam("total_amount", request.TotalAmount)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("openid", request.OpenId);

            if (request.SellerName != null)
                flurlReq.SetQueryParam("seller_name", request.SellerName);

            if (request.RequireShowMobileCell != null)
                flurlReq.SetQueryParam("show_phone_cell", request.RequireShowMobileCell.Value ? "true" : "false");

            if (request.RequireMustInputMobile != null)
                flurlReq.SetQueryParam("must_input_phone", request.RequireMustInputMobile.Value ? "true" : "false");

            if (request.RequireShowEmailCell != null)
                flurlReq.SetQueryParam("show_email_cell", request.RequireShowEmailCell.Value ? "true" : "false");

            if (request.RequireMustInputEmail != null)
                flurlReq.SetQueryParam("must_input_email", request.RequireMustInputEmail.Value ? "true" : "false");

            return await client.SendRequestWithJsonAsync<Models.GetNewTaxControlFapiaoUserTitleUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/user-title 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetNewTaxControlFapiaoUserTitleResponse> ExecuteGetNewTaxControlFapiaoUserTitleAsync(this WechatTenpayClient client, Models.GetNewTaxControlFapiaoUserTitleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "user-title")
                .SetQueryParam("fapiao_apply_id", request.FapiaoApplyId)
                .SetQueryParam("scene", request.Scene);

            return await client.SendRequestWithJsonAsync<Models.GetNewTaxControlFapiaoUserTitleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region FapiaoApplication
        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateNewTaxControlFapiaoApplicationResponse> ExecuteCreateNewTaxControlFapiaoApplicationAsync(this WechatTenpayClient client, Models.CreateNewTaxControlFapiaoApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications");

            return await client.SendRequestWithJsonAsync<Models.CreateNewTaxControlFapiaoApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/reverse 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_10.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseNewTaxControlFapiaoApplicationResponse> ExecuteReverseNewTaxControlFapiaoApplicationAsync(this WechatTenpayClient client, Models.ReverseNewTaxControlFapiaoApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId, "reverse");

            return await client.SendRequestWithJsonAsync<Models.ReverseNewTaxControlFapiaoApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse> ExecuteGetNewTaxControlFapiaoApplicationByFapiaoApplyIdAsync(this WechatTenpayClient client, Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId);

            if (request.FapiaoId != null)
                flurlReq.SetQueryParam("fapiao_id", request.FapiaoId);

            return await client.SendRequestWithJsonAsync<Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/fapiao-files 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetNewTaxControlFapiaoApplicationFilesResponse> ExecuteGetNewTaxControlFapiaoApplicationFilesAsync(this WechatTenpayClient client, Models.GetNewTaxControlFapiaoApplicationFilesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId, "fapiao-files");

            if (request.FapiaoId != null)
                flurlReq.SetQueryParam("fapiao_id", request.FapiaoId);

            return await client.SendRequestWithJsonAsync<Models.GetNewTaxControlFapiaoApplicationFilesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{download_url} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_21.shtml </para>
        /// <para><i>（请注意此接口不受构造 <see cref="WechatTenpayClient" /> 时指定的 <see cref="WechatTenpayClientOptions.Endpoint"/> 参数控制。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadNewTaxControlFapiaoApplicationFileResponse> ExecuteDownloadNewTaxControlFapiaoApplicationFileAsync(this WechatTenpayClient client, Models.DownloadNewTaxControlFapiaoApplicationFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, request.DownloadUrl)
                .WithUrl(request.DownloadUrl)
                .SetQueryParam("mchid", request.MerchantId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("fapiao_id", request.FapiaoId)
                .SetQueryParam("invoice_code", request.FapiaoCode)
                .SetQueryParam("invoice_no", request.FapiaoNumber);

            return await client.SendRequestWithJsonAsync<Models.DownloadNewTaxControlFapiaoApplicationFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/upload-fapiao-file 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_14.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadNewTaxControlFapiaoApplicationFapiaoFileResponse> ExecuteUploadNewTaxControlFapiaoApplicationFapiaoFileAsync(this WechatTenpayClient client, Models.UploadNewTaxControlFapiaoApplicationFapiaoFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications", "upload-fapiao-file");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "file.pdf", fileBytes: request.FileBytes, fileContentType: "application/pdf", fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendRequestAsync<Models.UploadNewTaxControlFapiaoApplicationFapiaoFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/insert-cards 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter4_8_15.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateNewTaxControlFapiaoApplicationCardResponse> ExecuteCreateNewTaxControlFapiaoApplicationCardAsync(this WechatTenpayClient client, Models.CreateNewTaxControlFapiaoApplicationCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId, "insert-cards");

            return await client.SendRequestWithJsonAsync<Models.CreateNewTaxControlFapiaoApplicationCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
