using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinMessageExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/message/send 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90236 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90372 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90854 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageSendResponse> ExecuteCgibinMessageSendAsync(this WechatWorkClient client, Models.CgibinMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "message", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/message/update_taskcard 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91579 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91585 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageUpdateTaskCardResponse> ExecuteCgibinMessageUpdateTaskCardAsync(this WechatWorkClient client, Models.CgibinMessageUpdateTaskCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "message", "update_taskcard")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageUpdateTaskCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/message/update_template_card 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94888 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94888 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageUpdateTemplateCardResponse> ExecuteCgibinMessageUpdateTemplateCardAsync(this WechatWorkClient client, Models.CgibinMessageUpdateTemplateCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "message", "update_template_card")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageUpdateTemplateCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/message/get_statistics 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92369 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageGetStatisticsResponse> ExecuteCgibinMessageGetStatisticsAsync(this WechatWorkClient client, Models.CgibinMessageGetStatisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "message", "get_statistics")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageGetStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/message/recall 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94867 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94867 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageRecallResponse> ExecuteCgibinMessageRecallAsync(this WechatWorkClient client, Models.CgibinMessageRecallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "message", "recall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageRecallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
