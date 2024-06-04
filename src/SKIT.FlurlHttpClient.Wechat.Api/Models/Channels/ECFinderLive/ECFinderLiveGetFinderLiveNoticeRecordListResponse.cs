namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/finderlive/getfinderlivenoticerecordlist 接口的响应。</para>
    /// </summary>
    public class ECFinderLiveGetFinderLiveNoticeRecordListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Notice
            {
                /// <summary>
                /// 获取或设置直播预告 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notice_id")]
                [System.Text.Json.Serialization.JsonPropertyName("notice_id")]
                public string NoticeId { get; set; } = default!;

                /// <summary>
                /// 获取或设置预约状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置预约状态文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status_wording")]
                [System.Text.Json.Serialization.JsonPropertyName("status_wording")]
                public string StatusText { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置预约描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置开播视频号昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置开播视频号头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_url")]
                public string HeadImageUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置直播预告列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_notice_list")]
        [System.Text.Json.Serialization.JsonPropertyName("live_notice_list")]
        public Types.Notice[] NoticeList { get; set; } = default!;
    }
}
