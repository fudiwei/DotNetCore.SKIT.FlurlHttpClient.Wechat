namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/unifiedorder 接口的响应。</para>
    /// </summary>
    public class NontaxUnifiedOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MiniProgram
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pagepath")]
                [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query_string")]
                [System.Text.Json.Serialization.JsonPropertyName("query_string")]
                public string PageQuery { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序业务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_type")]
                [System.Text.Json.Serialization.JsonPropertyName("business_type")]
                public string BusinessType { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置 H5 支付链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_url")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_url")]
        public string? PayUrl { get; set; }

        /// <summary>
        /// 获取或设置	小程序唤起参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
        public Types.MiniProgram MiniProgram { get; set; } = default!;
    }
}
