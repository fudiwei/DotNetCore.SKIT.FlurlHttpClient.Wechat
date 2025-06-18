namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_bind_sharer_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetBindSharerListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Sharer
            {
                /// <summary>
                /// 获取或设置推客的微信电商平台注册的身份标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sharer_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
                public string SharerAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置推客昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置推客头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_img_url")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置绑定时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_time")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_time")]
                public long BindTimestamp { get; set; }

                /// <summary>
                /// 获取或设置分佣类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_type")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_type")]
                public int CommissionType { get; set; }

                /// <summary>
                /// 获取或设置分佣比例（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_ratio")]
                public int CommissionRatio { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置推客列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_info_list")]
        public Types.Sharer[] SharerList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
