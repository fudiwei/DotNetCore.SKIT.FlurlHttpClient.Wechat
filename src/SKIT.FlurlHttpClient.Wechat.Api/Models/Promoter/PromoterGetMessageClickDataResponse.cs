namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getmsgclickdata 接口的响应。</para>
    /// </summary>
    public class PromoterGetMessageClickDataResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_type")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
                public int? MessageType { get; set; }

                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_id")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
                public string? MessageId { get; set; }

                /// <summary>
                /// 获取或设置消息发送时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_time")]
                [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                public long? SendTimestamp { get; set; }

                /// <summary>
                /// 获取或设置点击量 UV。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("click_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("click_uv")]
                public int ClickUV { get; set; }

                /// <summary>
                /// 获取或设置点击量 PV。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("click_pv")]
                [System.Text.Json.Serialization.JsonPropertyName("click_pv")]
                public int ClickPV { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置统计数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_list")]
        [System.Text.Json.Serialization.JsonPropertyName("data_list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
