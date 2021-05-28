using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getupstreammsg 接口的响应。</para>
    /// </summary>
    public class DataCubeGetUpstreamMessageResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置数据的日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public string RefDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_type")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
                public int MessageType { get; set; }

                /// <summary>
                /// 获取或设置上行发送了消息的用户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_user")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_user")]
                public int MessageUserCount { get; set; }

                /// <summary>
                /// 获取或设置上行发送了消息的消息总数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_count")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_count")]
                public int MesssageCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
