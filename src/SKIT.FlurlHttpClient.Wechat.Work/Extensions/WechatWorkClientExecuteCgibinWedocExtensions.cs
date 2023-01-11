using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinWedocExtensions
    {
        #region Document
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/create_doc 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97460 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocCreateDocumentResponse> ExecuteCgibinWedocCreateDocumentAsync(this WechatWorkClient client, Models.CgibinWedocCreateDocumentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "create_doc")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocCreateDocumentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/rename_doc 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97736 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocRenameDocumentResponse> ExecuteCgibinWedocRenameDocumentAsync(this WechatWorkClient client, Models.CgibinWedocRenameDocumentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "rename_doc")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocRenameDocumentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/del_doc 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97735 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocDeleteDocumentResponse> ExecuteCgibinWedocDeleteDocumentAsync(this WechatWorkClient client, Models.CgibinWedocDeleteDocumentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "del_doc")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocDeleteDocumentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/get_doc_base_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97734 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocGetDocumentBaseInfoResponse> ExecuteCgibinWedocGetDocumentBaseInfoAsync(this WechatWorkClient client, Models.CgibinWedocGetDocumentBaseInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "get_doc_base_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocGetDocumentBaseInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/doc_share 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97733 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocDocumentShareResponse> ExecuteCgibinWedocDocumentShareAsync(this WechatWorkClient client, Models.CgibinWedocDocumentShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "doc_share")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocDocumentShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/doc_get_auth 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97733 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocDocumentGetAuthResponse> ExecuteCgibinWedocDocumentGetAuthAsync(this WechatWorkClient client, Models.CgibinWedocDocumentGetAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "doc_get_auth")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocDocumentGetAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/mod_doc_join_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97733 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocModifyDocumentJoinRuleResponse> ExecuteCgibinWedocModifyDocumentJoinRuleAsync(this WechatWorkClient client, Models.CgibinWedocModifyDocumentJoinRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "mod_doc_join_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocModifyDocumentJoinRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/mod_doc_member 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97733 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocModifyDocumentMemberResponse> ExecuteCgibinWedocModifyDocumentMemberAsync(this WechatWorkClient client, Models.CgibinWedocModifyDocumentMemberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "mod_doc_member")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocModifyDocumentMemberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/mod_doc_safty_setting 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97782 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocModifyDocumentSafeSettingResponse> ExecuteCgibinWedocModifyDocumentSafeSettingAsync(this WechatWorkClient client, Models.CgibinWedocModifyDocumentSafeSettingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "mod_doc_safty_setting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocModifyDocumentSafeSettingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/document/batch_update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97626 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocDocumentBatchUpdateResponse> ExecuteCgibinWedocDocumentBatchUpdateAsync(this WechatWorkClient client, Models.CgibinWedocDocumentBatchUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "document", "batch_update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocDocumentBatchUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Form
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/create_form 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97462 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocCreateFormResponse> ExecuteCgibinWedocCreateFormAsync(this WechatWorkClient client, Models.CgibinWedocCreateFormRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "create_form")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocCreateFormResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/modify_form 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97462 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocModifyFormResponse> ExecuteCgibinWedocModifyFormAsync(this WechatWorkClient client, Models.CgibinWedocModifyFormRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "modify_form")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocModifyFormResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/get_form_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97817 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocGetFormInfoResponse> ExecuteCgibinWedocGetFormInfoAsync(this WechatWorkClient client, Models.CgibinWedocGetFormInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "get_form_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocGetFormInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/get_form_statistic 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97818 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocGetFormStatisticResponse> ExecuteCgibinWedocGetFormStatisticAsync(this WechatWorkClient client, Models.CgibinWedocGetFormStatisticRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "get_form_statistic")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocGetFormStatisticResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/get_form_answer 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97818 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocGetFormAnswerResponse> ExecuteCgibinWedocGetFormAnswerAsync(this WechatWorkClient client, Models.CgibinWedocGetFormAnswerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "get_form_answer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocGetFormAnswerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region SpreadSheet
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/spreadsheet/batch_update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97628 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocSpreadSheetBatchUpdateResponse> ExecuteCgibinWedocSpreadSheetBatchUpdateAsync(this WechatWorkClient client, Models.CgibinWedocSpreadSheetBatchUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "spreadsheet", "batch_update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocSpreadSheetBatchUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/spreadsheet/get_sheet_properties 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97711 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocSpreadSheetGetSheetPropertiesResponse> ExecuteCgibinWedocSpreadSheetGetSheetPropertiesAsync(this WechatWorkClient client, Models.CgibinWedocSpreadSheetGetSheetPropertiesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "spreadsheet", "get_sheet_properties")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocSpreadSheetGetSheetPropertiesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedoc/spreadsheet/get_sheet_range_data 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97661 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedocSpreadSheetGetSheetRangeDataResponse> ExecuteCgibinWedocSpreadSheetGetSheetRangeDataAsync(this WechatWorkClient client, Models.CgibinWedocSpreadSheetGetSheetRangeDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedoc", "spreadsheet", "get_sheet_range_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedocSpreadSheetGetSheetRangeDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
