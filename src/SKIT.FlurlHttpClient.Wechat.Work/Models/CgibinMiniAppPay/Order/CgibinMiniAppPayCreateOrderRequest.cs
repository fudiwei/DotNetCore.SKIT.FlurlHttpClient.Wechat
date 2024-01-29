using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/miniapppay/create_order 接口的请求。</para>
    /// </summary>
    public class CgibinMiniAppPayCreateOrderRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Amount
            {
                /// <summary>
                /// 获取或设置订单总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }

                /// <summary>
                /// 获取或设置币种。
                /// <para>默认值：CNY</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string Currency { get; set; } = "CNY";
            }

            public class Payer
            {
                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = string.Empty;
            }

            public class Scene
            {
                public static class Types
                {
                    public class Store
                    {
                        /// <summary>
                        /// 获取或设置门店编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置门店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置地区编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("area_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("area_code")]
                        public string? AreaCode { get; set; }

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户终端 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_client_ip")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_client_ip")]
                public string ClientIp { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户端设备号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_id")]
                [System.Text.Json.Serialization.JsonPropertyName("device_id")]
                public string? DeviceId { get; set; }

                /// <summary>
                /// 获取或设置商户门店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_info")]
                [System.Text.Json.Serialization.JsonPropertyName("store_info")]
                public Types.Store? Store { get; set; }
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
                        [Newtonsoft.Json.JsonProperty("wechatpay_goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("wechatpay_goods_id")]
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
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下单场景 Key。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scenekey")]
        [System.Text.Json.Serialization.JsonPropertyName("scenekey")]
        public string? SceneKey { get; set; }

        /// <summary>
        /// 获取或设置订单金额信息。
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
        /// 获取或设置交易结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_expire")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_expire")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

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
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene Scene { get; set; } = new Types.Scene();

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Detail? Detail { get; set; }
    }
}
