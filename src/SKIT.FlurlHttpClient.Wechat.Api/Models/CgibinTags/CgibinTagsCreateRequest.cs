using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tags/create 接口的请求。</para>
    /// </summary>
    public class CgibinTagsCreateRequest : WechatApiRequest, ISendRequest<CgibinTagsCreateResponse>
    {
        public static class Types
        {
            public class Tag
            {
                /// <summary>
                /// 获取或设置标签名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置标签数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public Types.Tag Tag { get; set; } = new Types.Tag();

        public Task<CgibinTagsCreateResponse> Send(WechatApiClient client, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return client.ExecuteCgibinTagsCreateAsync(this, cancellationToken);
        }
    }
}
