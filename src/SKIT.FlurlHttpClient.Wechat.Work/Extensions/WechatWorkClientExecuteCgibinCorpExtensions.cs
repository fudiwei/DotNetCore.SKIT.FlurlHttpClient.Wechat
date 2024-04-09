using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinCorpExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/corp/get_join_qrcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91039 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGetJoinQrcodeResponse> ExecuteCgibinCorpGetJoinQrcodeAsync(this WechatWorkClient client, Models.CgibinCorpGetJoinQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "corp", "get_join_qrcode")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.SizeType is not null)
                flurlReq.SetQueryParam("size_type", request.SizeType.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCorpGetJoinQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corp/getopenapprovaldata 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90269 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/93798 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91188 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGetOpenApprovalDataResponse> ExecuteCgibinCorpGetOpenApprovalDataAsync(this WechatWorkClient client, Models.CgibinCorpGetOpenApprovalDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "corp", "getopenapprovaldata")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCorpGetOpenApprovalDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corp/apply_mass_call_ticket 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/96168 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/96250 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpApplyMassCallTicketResponse> ExecuteCgibinCorpApplyMassCallTicketAsync(this WechatWorkClient client, Models.CgibinCorpApplyMassCallTicketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "corp", "apply_mass_call_ticket")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCorpApplyMassCallTicketResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
