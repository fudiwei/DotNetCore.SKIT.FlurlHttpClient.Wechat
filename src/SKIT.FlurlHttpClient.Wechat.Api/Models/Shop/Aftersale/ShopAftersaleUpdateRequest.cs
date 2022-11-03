namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/aftersale/update 接口的请求。</para>
    /// </summary>
    public class ShopAftersaleUpdateRequest : WechatApiRequest, IInferable<ShopAftersaleUpdateRequest, ShopAftersaleUpdateResponse>
    {
        /// <summary>
        /// 获取或设置商家自定义订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家自定义售后单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_aftersale_id")]
        public string OutAftersaleOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置售后状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置是否处理完成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_all_aftersale")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("finish_all_aftersale")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsFinishAll { get; set; }
    }
}
