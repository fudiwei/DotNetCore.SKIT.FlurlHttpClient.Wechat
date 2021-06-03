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
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageSendResponse> ExecuteCgibinMessageSendAsync(this WechatWorkClient client, Models.CgibinMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (!request.AgentId.HasValue)
                request.AgentId = client.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "message", "send")
                .SetOptions(request);

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

            if (!request.AgentId.HasValue)
                request.AgentId = client.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "message", "update_taskcard")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageUpdateTaskCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "message", "get_statistics")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageGetStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
