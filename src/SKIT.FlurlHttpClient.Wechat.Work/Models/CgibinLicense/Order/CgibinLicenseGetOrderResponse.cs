namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/get_order 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseGetOrderResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Order : CgibinLicenseListOrderResponse.Types.Order
            {
                public static class Types
                {
                    public class AccountCount
                    {
                        /// <summary>
                        /// 获取或设置基础账号个数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("base_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("base_count")]
                        public int BaseCount { get; set; }

                        /// <summary>
                        /// 获取或设置互通账号个数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_contact_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_contact_count")]
                        public int ExternalContactCount { get; set; }
                    }

                    public class AccountDuration
                    {
                        /// <summary>
                        /// 获取或设置购买的月数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("months")]
                        [System.Text.Json.Serialization.JsonPropertyName("months")]
                        public int? Months { get; set; }

                        /// <summary>
                        /// 获取或设置购买的天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("days")]
                        [System.Text.Json.Serialization.JsonPropertyName("days")]
                        public int? Days { get; set; }

                        /// <summary>
                        /// 获取或设置新过期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_expire_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_expire_time")]
                        public long? NewExpireTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置客户企业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string CorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置账号个数信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_count")]
                [System.Text.Json.Serialization.JsonPropertyName("account_count")]
                public Types.AccountCount AccountCount { get; set; } = default!;

                /// <summary>
                /// 获取或设置账号时长信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("account_duration")]
                public Types.AccountDuration AccountDuration { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long? PayTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order Order { get; set; } = default!;
    }
}
