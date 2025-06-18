namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/finderlive/getfinderliverecordlist 接口的响应。</para>
    /// </summary>
    public class ECFinderLiveGetFinderLiveRecordListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Live
            {
                /// <summary>
                /// 获取或设置直播 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("export_id")]
                [System.Text.Json.Serialization.JsonPropertyName("export_id")]
                public string ExportId { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播封面 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cover_url")]
                [System.Text.Json.Serialization.JsonPropertyName("cover_url")]
                public string CoverUrl { get; set; } = default!;

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
        /// 获取或设置直播列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_list")]
        [System.Text.Json.Serialization.JsonPropertyName("live_list")]
        public Types.Live[] LiveList { get; set; } = default!;
    }
}
