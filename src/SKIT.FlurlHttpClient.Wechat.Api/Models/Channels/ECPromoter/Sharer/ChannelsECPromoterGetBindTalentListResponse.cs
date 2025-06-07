namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_bind_talent_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetBindTalentListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Talent
            {
                /// <summary>
                /// 获取或设置达人平台 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("talent_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
                public string TalentAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置达人平台昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("talent_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("talent_nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置达人平台头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("talent_head_img")]
                [System.Text.Json.Serialization.JsonPropertyName("talent_head_img")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置绑定时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_time")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_time")]
                public long BindTimestamp { get; set; }

                /// <summary>
                /// 获取或设置关联的视频号导出名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("related_finder_exportname_list")]
                [System.Text.Json.Serialization.JsonPropertyName("related_finder_exportname_list")]
                public string[] RelatedFinderExportUserameList { get; set; } = default!;

                /// <summary>
                /// 获取或设置关联的公众号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("related_mp_biz_appid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("related_mp_biz_appid_list")]
                public string[] RelatedMpAppIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置达人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_list")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_list")]
        public Types.Talent[] TalentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
