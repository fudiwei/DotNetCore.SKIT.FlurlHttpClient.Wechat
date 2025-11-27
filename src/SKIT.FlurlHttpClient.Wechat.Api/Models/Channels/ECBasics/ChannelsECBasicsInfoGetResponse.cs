namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/basics/info/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsInfoGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BasicInfo
            {
                /// <summary>
                /// 获取或设置店铺原始 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("username")]
                [System.Text.Json.Serialization.JsonPropertyName("username")]
                public string? Username { get; set; }

                /// <summary>
                /// 获取或设置店铺名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headimg_url")]
                [System.Text.Json.Serialization.JsonPropertyName("headimg_url")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject_type")]
                [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
                public string SubjectType { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否本地生活小店。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_local_life")]
                [System.Text.Json.Serialization.JsonPropertyName("is_local_life")]
                public bool IsLocalLife { get; set; }

                /// <summary>
                /// 获取或设置开店时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("open_timestamp")]
                public long? OpenTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置店铺基础信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.BasicInfo BasicInfo { get; set; } = default!;
    }
}
