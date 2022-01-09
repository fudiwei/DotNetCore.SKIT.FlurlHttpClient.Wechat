using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tags/delete 接口的请求。</para>
    /// </summary>
    public class CgibinTagsDeleteRequest : WechatApiRequest, IMapResponse<CgibinTagsDeleteRequest, CgibinTagsDeleteResponse>
    {
        public static class Types
        {
            public class Tag
            {
                /// <summary>
                /// 获取或设置标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置标签数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public Types.Tag Tag { get; set; } = new Types.Tag();
    }
}
