namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/partner/transactions/codepay 接口的请求。</para>
    /// </summary>
    public class CreatePayPartnerTransactionCodePayRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Amount : CreatePayTransactionCodePayRequest.Types.Amount
            {
            }

            public class Payer : CreatePayTransactionCodePayRequest.Types.Payer
            {
            }

            public class Detail : CreatePayTransactionCodePayRequest.Types.Detail
            {
            }

            public class Scene : CreatePayTransactionCodePayRequest.Types.Scene
            {
            }

            public class Settlement : CreatePayTransactionCodePayRequest.Types.Settlement
            {
            }
        }

        /// <summary>
        /// 获取或设置服务商商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置订单优惠标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
        public string? GoodsTag { get; set; }

        /// <summary>
        /// 获取或设置是否支持开票。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("support_fapiao")]
        [System.Text.Json.Serialization.JsonPropertyName("support_fapiao")]
        public bool? IsSupportFapiao { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = new Types.Amount();

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = new Types.Payer();

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Detail? Detail { get; set; }

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene Scene { get; set; } = new Types.Scene();

        /// <summary>
        /// 获取或设置结算信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_info")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
        public Types.Settlement? Settlement { get; set; }
    }
}
