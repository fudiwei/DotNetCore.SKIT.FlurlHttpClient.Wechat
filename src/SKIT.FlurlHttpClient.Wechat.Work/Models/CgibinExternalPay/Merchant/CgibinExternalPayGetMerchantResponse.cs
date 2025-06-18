namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalpay/getmerchant 接口的响应。</para>
    /// </summary>
    public class CgibinExternalPayGetMerchantResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class UseScope
            {
                /// <summary>
                /// 获取或设置成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user")]
                [System.Text.Json.Serialization.JsonPropertyName("user")]
                public string[]? UserIdList { get; set; }

                /// <summary>
                /// 获取或设置部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partyid")]
                [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                public long[]? DepartmentIdList { get; set; }

                /// <summary>
                /// 获取或设置标签 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tagid")]
                [System.Text.Json.Serialization.JsonPropertyName("tagid")]
                public int[]? TagIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置绑定状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_status")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
        public int BindStatus { get; set; }

        /// <summary>
        /// 获取或设置微信支付商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付商户号全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; } = default!;

        /// <summary>
        /// 获取或设置使用范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_use_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_use_scope")]
        public Types.UseScope? UseScope { get; set; }
    }
}
