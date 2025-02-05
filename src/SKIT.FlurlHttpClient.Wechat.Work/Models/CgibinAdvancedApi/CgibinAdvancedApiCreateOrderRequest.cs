namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_api/create_order 接口的请求。</para>
    /// </summary>
    public class CgibinAdvancedApiCreateOrderRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class ChatArchiveApi
            {
                public static class Types
                {
                    public class EditionInfo
                    {
                        /// <summary>
                        /// 获取或设置开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                        public long BeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置目标版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edition")]
                [System.Text.Json.Serialization.JsonPropertyName("edition")]
                public int TargetEdition { get; set; }

                /// <summary>
                /// 获取或设置目标版本生效信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("target_edition_info")]
                [System.Text.Json.Serialization.JsonPropertyName("target_edition_info")]
                public Types.EditionInfo? TargetEditionInfo { get; set; }

                /// <summary>
                /// 获取或设置旧版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("old_edition")]
                [System.Text.Json.Serialization.JsonPropertyName("old_edition")]
                public int? OldEdition { get; set; }

                /// <summary>
                /// 获取或设置旧版本生效信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("old_edition_info")]
                [System.Text.Json.Serialization.JsonPropertyName("old_edition_info")]
                public Types.EditionInfo? OldEditionInfo { get; set; }

                /// <summary>
                /// 获取或设置购买数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("purchase_count")]
                [System.Text.Json.Serialization.JsonPropertyName("purchase_count")]
                public int? PurchaseCount { get; set; }

                /// <summary>
                /// 获取或设置生效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("take_effect_time")]
                [System.Text.Json.Serialization.JsonPropertyName("take_effect_time")]
                public long? TakeEffectTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置购买的高级接口类型。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advanced_api_type")]
        [System.Text.Json.Serialization.JsonPropertyName("advanced_api_type")]
        public int AdvancedApiType { get; set; } = 1;

        /// <summary>
        /// 获取或设置客户企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_corpid")]
        public string CustomCorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下单人成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_userid")]
        public string BuyerUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int? OrderType { get; set; }

        /// <summary>
        /// 获取或设置会话内容数据接口订单相关信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_archive_api")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_archive_api")]
        public Types.ChatArchiveApi? ChatArchiveApi { get; set; }
    }
}
