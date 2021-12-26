using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/tags/get 接口的请求。</para>
    /// </summary>
    public class CgibinTagsGetRequest : WechatApiRequest, ISendRequest<CgibinTagsGetResponse>
    {
        public Task<CgibinTagsGetResponse> Send(WechatApiClient client, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return client.ExecuteCgibinTagsGetAsync(this, cancellationToken);
        }
    }
}
