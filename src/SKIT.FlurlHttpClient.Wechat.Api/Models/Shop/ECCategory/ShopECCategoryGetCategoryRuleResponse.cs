namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ec/category/getcategoryrule 接口的响应。</para>
    /// </summary>
    public class ShopECCategoryGetCategoryRuleResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Deliver
            {
                /// <summary>
                /// 获取或设置发货方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deliver_type")]
                [System.Text.Json.Serialization.JsonPropertyName("deliver_type")]
                public int DeliverType { get; set; }

                /// <summary>
                /// 获取或设置支持的账号类型列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("acct_type")]
                [System.Text.Json.Serialization.JsonPropertyName("acct_type")]
                public int[] AccountTypeList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置保证金（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deposit")]
        [System.Text.Json.Serialization.JsonPropertyName("deposit")]
        public int? Deposit { get; set; }

        /// <summary>
        /// 获取或设置发货方式列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Deliver[]? DeliverList { get; set; }
    }
}
