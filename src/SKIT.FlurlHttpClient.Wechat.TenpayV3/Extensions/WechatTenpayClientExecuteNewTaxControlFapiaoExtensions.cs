using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteNewTaxControlFapiaoExtensions
    {
        #region CardTemplate
        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/card-template 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-card-template/create-fapiao-card-template.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-card-template/create-fapiao-card-template.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "card-template");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateNewTaxControlFapiaoCardTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Merchant
        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/merchant/{sub_mchid}/check 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-merchant/check-merchant-status.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CheckNewTaxControlFapiaoMerchantResponse> ExecuteCheckNewTaxControlFapiaoMerchantAsync(this WechatTenpayClient client, Models.CheckNewTaxControlFapiaoMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "merchant", request.SubMerchantId, "check");

            return await client.SendFlurlRequestAsJsonAsync<Models.CheckNewTaxControlFapiaoMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /new-tax-control-fapiao/merchant/development-config 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-merchant/update-development-config.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-merchant/update-development-config.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "new-tax-control-fapiao", "merchant", "development-config");

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifyNewTaxControlFapiaoMerchantDevelopmentConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/merchant/development-config 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-merchant/query-development-config.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-merchant/query-development-config.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "merchant", "development-config");

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mch_code", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoMerchantDevelopmentConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/merchant/base-information 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-merchant/get-merchant-info.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-merchant/get-merchant-info.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "merchant", "base-information");

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoMerchantBaseInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/merchant/tax-codes 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-merchant/list-merchant-tax-codes.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-merchant/list-merchant-tax-codes.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "merchant", "tax-codes")
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryNewTaxControlFapiaoMerchantTaxCodesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region UserTitle
        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/user-title/title-url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/user-title/acquire-fapiao-title-url.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/user-title/acquire-fapiao-title-url.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "user-title", "title-url")
                .SetQueryParam("fapiao_apply_id", request.FapiaoApplyId)
                .SetQueryParam("source", request.Source)
                .SetQueryParam("total_amount", request.TotalAmount)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("openid", request.OpenId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.SellerName is not null)
                flurlReq.SetQueryParam("seller_name", request.SellerName);

            if (request.RequireShowMobileCell is not null)
                flurlReq.SetQueryParam("show_phone_cell", request.RequireShowMobileCell.Value ? "true" : "false");

            if (request.RequireMustInputMobile is not null)
                flurlReq.SetQueryParam("must_input_phone", request.RequireMustInputMobile.Value ? "true" : "false");

            if (request.RequireShowEmailCell is not null)
                flurlReq.SetQueryParam("show_email_cell", request.RequireShowEmailCell.Value ? "true" : "false");

            if (request.RequireMustInputEmail is not null)
                flurlReq.SetQueryParam("must_input_email", request.RequireMustInputEmail.Value ? "true" : "false");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoUserTitleUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/user-title 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/user-title/get-user-title.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/user-title/get-user-title.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "user-title")
                .SetQueryParam("fapiao_apply_id", request.FapiaoApplyId)
                .SetQueryParam("scene", request.Scene);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoUserTitleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region FapiaoApplication
        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/issue-fapiao-applications.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-applications/issue-fapiao-applications.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateNewTaxControlFapiaoApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/reverse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/reverse-fapiao-applications.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-applications/reverse-fapiao-applications.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId, "reverse");

            return await client.SendFlurlRequestAsJsonAsync<Models.ReverseNewTaxControlFapiaoApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/get-fapiao-applications.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-applications/get-fapiao-applications.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId);

            if (request.FapiaoId is not null)
                flurlReq.SetQueryParam("fapiao_id", request.FapiaoId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/fapiao-files 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/get-fapiao-file-download-info.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-applications/get-fapiao-file-download-info.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId, "fapiao-files");

            if (request.FapiaoId is not null)
                flurlReq.SetQueryParam("fapiao_id", request.FapiaoId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoApplicationFilesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{download_url} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/download-invoice-file.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-applications/download-invoice-file.html ]]>
        /// </para>
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

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, request.DownloadUrl)
                .WithUrl(request.DownloadUrl)
                .SetQueryParam("mchid", request.MerchantId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("fapiao_id", request.FapiaoId)
                .SetQueryParam("invoice_code", request.FapiaoCode)
                .SetQueryParam("invoice_no", request.FapiaoNumber);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.DownloadNewTaxControlFapiaoApplicationFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/upload-fapiao-file 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/upload-fapiao-file.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-applications/upload-fapiao-file.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications", "upload-fapiao-file");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "file.pdf", fileBytes: request.FileBytes, fileContentType: "application/pdf", fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendFlurlRequestAsync<Models.UploadNewTaxControlFapiaoApplicationFapiaoFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/insert-cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/insert-cards.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/fapiao/fapiao-applications/insert-cards.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId, "insert-cards");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateNewTaxControlFapiaoApplicationCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
