﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tags/create 接口的请求。</para>
    /// </summary>
    public class CgibinTagsCreateRequest : WechatApiRequest, IInferable<CgibinTagsCreateRequest, CgibinTagsCreateResponse>
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
    }
}
