using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/transactions/codepay 接口的请求。</para>
    /// </summary>
    public class CreatePayTransactionCodePayRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Payer
            {
                /// <summary>
                /// 获取或设置授权码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_code")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_code")]
                public string AuthCode { get; set; } = string.Empty;
            }

            public class Amount : CreatePayTransactionAppRequest.Types.Amount
            {
            }

            public class Detail
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        /// <summary>
                        /// 获取或设置商户侧商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_goods_id")]
                        public string MerchantGoodsId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置微信侧商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wxpay_goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("wxpay_goods_id")]
                        public string? WechatpayGoodsId { get; set; }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                        public string? GoodsName { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; }

                        /// <summary>
                        /// 获取或设置商品单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit_price")]
                        public int UnitPrice { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单原价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cost_price")]
                [System.Text.Json.Serialization.JsonPropertyName("cost_price")]
                public int? CostPrice { get; set; }

                /// <summary>
                /// 获取或设置商品小票 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoice_id")]
                [System.Text.Json.Serialization.JsonPropertyName("invoice_id")]
                public string? InvoiceId { get; set; }

                /// <summary>
                /// 获取或设置单品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                public List<Types.GoodsDetail>? GoodsList { get; set; }
            }

            public class Scene : CreatePayTransactionAppRequest.Types.Scene
            {
                public static new class Types
                {
                    public class Store : CreatePayTransactionAppRequest.Types.Scene.Types.Store
                    {
                    }
                }
            }

            public class Settlement : CreatePayTransactionAppRequest.Types.Settlement
            {
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

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
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = new Types.Payer();

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = new Types.Amount();

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
        public Types.Scene? Scene { get; set; }

        /// <summary>
        /// 获取或设置结算信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_info")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
        public Types.Settlement? Settlement { get; set; }
    }
}
