using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayClientExecuteNewTaxControlFapiaoExtensions
    {
        #region CardTemplate
        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/card-template 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012529382 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474026 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792562 ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateNewTaxControlFapiaoCardTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region FapiaoApplications
        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012538301 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474060 ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateNewTaxControlFapiaoApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/issue-general 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792574 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateNewTaxControlFapiaoApplicationIssueGeneralResponse> ExecuteCreateNewTaxControlFapiaoApplicationIssueGeneralAsync(this WechatTenpayClient client, Models.CreateNewTaxControlFapiaoApplicationIssueGeneralRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications", "issue-general");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateNewTaxControlFapiaoApplicationIssueGeneralResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/real-estate-leasing 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015941740 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateNewTaxControlFapiaoApplicationRealEstateLeasingResponse> ExecuteCreateNewTaxControlFapiaoApplicationRealEstateLeasingAsync(this WechatTenpayClient client, Models.CreateNewTaxControlFapiaoApplicationRealEstateLeasingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications", "real-estate-leasing");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateNewTaxControlFapiaoApplicationRealEstateLeasingResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/reverse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012538327 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474062 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792575 ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.ReverseNewTaxControlFapiaoApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012531753 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012489258 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792567 ]]>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("fapiao_id", request.FapiaoId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/fapiao-files 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012538335 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474067 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792576 ]]>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "fapiao-applications", request.FapiaoApplyId, "fapiao-files")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("fapiao_id", request.FapiaoId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoApplicationFilesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{download_url} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012286040 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012071750 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792569 ]]>
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
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("fapiao_id", request.FapiaoId)
                .SetQueryParam("invoice_code", request.FapiaoCode)
                .SetQueryParam("invoice_no", request.FapiaoNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.DownloadNewTaxControlFapiaoApplicationFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/upload-fapiao-file 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012556605 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012696830 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792580 ]]>
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

            if (request.FileHashAlgorithm is null)
            {
                request.FileHashAlgorithm = "SM3";
            }

            if (request.FileHash is null)
            {
                switch (request.FileHashAlgorithm)
                {
                    case "SM3":
                        request.FileHash = EncodedString.ToHexString(Utilities.SM3Utility.Hash(request.FileBytes)).Value!.ToLower();
                        break;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "fapiao-applications", "upload-fapiao-file");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "file.pdf", fileBytes: request.FileBytes, fileContentType: "application/pdf", fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendFlurlRequestAsync<Models.UploadNewTaxControlFapiaoApplicationFapiaoFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/insert-cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012538365 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474078 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792579 ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateNewTaxControlFapiaoApplicationCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region FapiaoMerchant
        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/fapiaomerchant/getspinviteurl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015941495 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetNewTaxControlFapiaoMerchantServicePartnerInviteUrlResponse> ExecuteGetNewTaxControlFapiaoMerchantServicePartnerInviteUrlAsync(this WechatTenpayClient client, Models.GetNewTaxControlFapiaoMerchantServicePartnerInviteUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "fapiaomerchant", "getspinviteurl")
                .SetQueryParam("operation_type", request.OperationType)
                .SetQueryParam("operate_user", request.OperateUser)
                .SetQueryParam("fapiao_mode", request.FapiaoMode)
                .SetQueryParam("fapiao_ability_type_list", request.FapiaoAbilityTypeList is not null ? string.Join(",", request.FapiaoAbilityTypeList) : null)
                .SetQueryParam("invite_channel", request.InviteChannel)
                .SetQueryParam("invite_code", request.InviteCode)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoMerchantServicePartnerInviteUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/fapiaomerchant/listspinvitemchinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015941524 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryNewTaxControlFapiaoMerchantServicePartnerInvitedMerchantsResponse> ExecuteQueryNewTaxControlFapiaoMerchantServicePartnerInvitedMerchantsAsync(this WechatTenpayClient client, Models.QueryNewTaxControlFapiaoMerchantServicePartnerInvitedMerchantsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "fapiaomerchant", "getspinviteurl")
                .SetQueryParam("query_time_start", request.QueryStartTime.HasValue ? request.QueryStartTime.Value.ToString("yyyy-MM-dd'T'HH:mm:sszzz") : null)
                .SetQueryParam("query_time_end", request.QueryEndTime.HasValue ? request.QueryEndTime.Value.ToString("yyyy-MM-dd'T'HH:mm:sszzz") : null)
                .SetQueryParam("invite_code", request.InviteCode)
                .SetQueryParam("mch_invite_status", request.InviteCode)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryNewTaxControlFapiaoMerchantServicePartnerInvitedMerchantsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Merchant
        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/merchant/{sub_mchid}/check 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474022 ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CheckNewTaxControlFapiaoMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /new-tax-control-fapiao/merchant/{sub_mchid}/check-status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792561 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CheckNewTaxControlFapiaoMerchantStatusResponse> ExecuteCheckNewTaxControlFapiaoMerchantStatusAsync(this WechatTenpayClient client, Models.CheckNewTaxControlFapiaoMerchantStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "new-tax-control-fapiao", "merchant", request.SubMerchantId, "check-status");

            return await client.SendFlurlRequestAsJsonAsync<Models.CheckNewTaxControlFapiaoMerchantStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /new-tax-control-fapiao/merchant/development-config 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012529457 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474031 ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifyNewTaxControlFapiaoMerchantDevelopmentConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/merchant/development-config 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012529526 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474033 ]]>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "merchant", "development-config")
                .SetQueryParam("sub_mch_code", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoMerchantDevelopmentConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/merchant/base-information 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012538180 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474053 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015792563 ]]>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "new-tax-control-fapiao", "merchant", "base-information")
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoMerchantBaseInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/merchant/tax-codes 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012538236 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474057 ]]>
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
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryNewTaxControlFapiaoMerchantTaxCodesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region UserTitle
        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/user-title/title-url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012538106 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474040 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015770776 ]]>
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
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("fapiao_apply_id", request.FapiaoApplyId)
                .SetQueryParam("source", request.Source)
                .SetQueryParam("total_amount", request.TotalAmount)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("seller_name", request.SellerName)
                .SetQueryParam("show_phone_cell", request.RequireShowMobileCell.HasValue ? request.RequireShowMobileCell.Value ? "true" : "false" : null)
                .SetQueryParam("must_input_phone", request.RequireMustInputMobile.HasValue ? request.RequireMustInputMobile.Value ? "true" : "false" : null)
                .SetQueryParam("show_email_cell", request.RequireShowEmailCell.HasValue ? request.RequireShowEmailCell.Value ? "true" : "false" : null)
                .SetQueryParam("must_input_email", request.RequireMustInputEmail.HasValue ? request.RequireMustInputEmail.Value ? "true" : "false" : null);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoUserTitleUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /new-tax-control-fapiao/user-title 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012538112 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474048 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015784260 ]]>
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
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("fapiao_apply_id", request.FapiaoApplyId)
                .SetQueryParam("scene", request.Scene);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetNewTaxControlFapiaoUserTitleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
