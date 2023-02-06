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
