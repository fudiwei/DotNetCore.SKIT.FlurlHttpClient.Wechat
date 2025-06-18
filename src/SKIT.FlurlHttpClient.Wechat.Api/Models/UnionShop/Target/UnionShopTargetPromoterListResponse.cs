namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/shop/target/promoter_list 接口的响应。</para>
    /// </summary>
    public class UnionShopTargetPromoterListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Promoter
            {
                /// <summary>
                /// 获取或设置微信 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoterType")]
                [System.Text.Json.Serialization.JsonPropertyName("promoterType")]
                public string PromoterType { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyTime")]
                [System.Text.Json.Serialization.JsonPropertyName("applyTime")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过审状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoterStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("promoterStatus")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置通过时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("joinTime")]
                [System.Text.Json.Serialization.JsonPropertyName("joinTime")]
                public long? Joinimestamp { get; set; }

                /// <summary>
                /// 获取或设置申请理由。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyReason")]
                [System.Text.Json.Serialization.JsonPropertyName("applyReason")]
                public string? ApplyReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置推客列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoterList")]
        [System.Text.Json.Serialization.JsonPropertyName("promoterList")]
        public Types.Promoter[] PromoterList { get; set; } = default!;
    }
}
