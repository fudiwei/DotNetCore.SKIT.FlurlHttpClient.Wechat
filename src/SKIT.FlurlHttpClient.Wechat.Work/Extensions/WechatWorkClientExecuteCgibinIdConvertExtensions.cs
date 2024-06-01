using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinIdConvertExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/unionid_to_external_userid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95926 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertUnionIdToExternalUserIdResponse> ExecuteCgibinIdConvertUnionIdToExternalUserIdAsync(this WechatWorkClient client, Models.CgibinIdConvertUnionIdToExternalUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "unionid_to_external_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinIdConvertUnionIdToExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/batch/external_userid_to_pending_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95926 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95900 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertBatchExternalUserIdToPendingIdResponse> ExecuteCgibinIdConvertBatchExternalUserIdToPendingIdAsync(this WechatWorkClient client, Models.CgibinIdConvertBatchExternalUserIdToPendingIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "batch", "external_userid_to_pending_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinIdConvertBatchExternalUserIdToPendingIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/external_tagid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95926 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/96169 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertExternalTagIdResponse> ExecuteCgibinIdConvertExternalTagIdAsync(this WechatWorkClient client, Models.CgibinIdConvertExternalTagIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "external_tagid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinIdConvertExternalTagIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/open_kfid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97064 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/96169 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertOpenKfIdResponse> ExecuteCgibinIdConvertOpenKfIdAsync(this WechatWorkClient client, Models.CgibinIdConvertOpenKfIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "open_kfid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinIdConvertOpenKfIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/convert_tmp_external_userid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98729 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertConvertTempExternalUserIdResponse> ExecuteCgibinIdConvertConvertTempExternalUserIdAsync(this WechatWorkClient client, Models.CgibinIdConvertConvertTempExternalUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "convert_tmp_external_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinIdConvertConvertTempExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/apply_to_upgrade_chatid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99601 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertApplyToUpgradeChatIdResponse> ExecuteCgibinIdConvertApplyToUpgradeChatIdAsync(this WechatWorkClient client, Models.CgibinIdConvertApplyToUpgradeChatIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "apply_to_upgrade_chatid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinIdConvertApplyToUpgradeChatIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/chatid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99601 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertChatIdResponse> ExecuteCgibinIdConvertChatIdAsync(this WechatWorkClient client, Models.CgibinIdConvertChatIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "chatid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinIdConvertChatIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/upgrade_chatid_for_new_corp 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99601 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertUpgradeChatIdForNewCorpResponse> ExecuteCgibinIdConvertUpgradeChatIdForNewCorpAsync(this WechatWorkClient client, Models.CgibinIdConvertUpgradeChatIdForNewCorpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "upgrade_chatid_for_new_corp")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinIdConvertUpgradeChatIdForNewCorpResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
