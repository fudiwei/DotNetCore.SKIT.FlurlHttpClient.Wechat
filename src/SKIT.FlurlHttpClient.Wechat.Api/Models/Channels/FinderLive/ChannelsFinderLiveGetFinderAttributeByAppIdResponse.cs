namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/finderlive/get_finder_attr_by_appid 接口的响应。</para>
    /// </summary>
    public class ChannelsFinderLiveGetFinderAttributeByAppIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class FinderAttribute
            {
                /// <summary>
                /// 获取或设置视频号唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uniq_id")]
                [System.Text.Json.Serialization.JsonPropertyName("uniq_id")]
                public string UniqueId { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频号昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string NickName { get; set; } = default!;

                /// <summary>
                /// 获取或设置粉丝数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fans_count")]
                [System.Text.Json.Serialization.JsonPropertyName("fans_count")]
                public int FansCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置视频号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_attr")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_attr")]
        public Types.FinderAttribute FinderAttribute { get; set; } = default!;
    }
}
