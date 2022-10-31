namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/list_order_account 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseListOrderAccountResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Account
            {
                /// <summary>
                /// 获取或设置帐号激活码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_code")]
                [System.Text.Json.Serialization.JsonPropertyName("active_code")]
                public string ActiveCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置成员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置帐号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_list")]
        [System.Text.Json.Serialization.JsonPropertyName("account_list")]
        public Types.Account[] AccountList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
