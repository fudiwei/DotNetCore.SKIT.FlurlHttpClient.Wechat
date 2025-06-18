namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/profitsharing/returnorders 接口的请求。</para>
    /// </summary>
    public class CreateBrandProfitSharingReturnOrderRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户分账单号。与字段 <see cref="OrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string? OutOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置微信分账单号。与字段 <see cref="OutOrderNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置商户回退单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_return_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_return_no")]
        public string OutReturnNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回退商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("return_mchid")]
        public string ReturnMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回退金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置回退描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }
}
