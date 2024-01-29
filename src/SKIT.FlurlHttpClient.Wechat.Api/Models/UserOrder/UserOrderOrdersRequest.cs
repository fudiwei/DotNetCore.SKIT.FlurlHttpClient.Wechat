using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /user-order/orders 接口的请求。</para>
    /// </summary>
    public class UserOrderOrdersRequest : WechatApiRequest, IInferable<UserOrderOrdersRequest, UserOrderOrdersResponse>
    {
        public static class Types
        {
            public class OrderKey
            {
                /// <summary>
                /// 获取或设置订单单号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_number_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_number_type")]
                public int OrderNumberType { get; set; }

                /// <summary>
                /// 获取或设置支付下单商户的商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置原支付交易的商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string? OutTradeNumber { get; set; }

                /// <summary>
                /// 获取或设置原支付交易的微信订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string? TransactionId { get; set; }
            }

            public class Order
            {
                public static class Types
                {
                    public class JumpLink
                    {
                        /// <summary>
                        /// 获取或设置链接类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? AppId { get; set; }

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string? PagePath { get; set; }

                        /// <summary>
                        /// 获取或设置链接地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }
                    }

                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置商户侧商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_item_id")]
                        public string MerchantItemId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置商品单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit_price")]
                        public int UnitPrice { get; set; }

                        /// <summary>
                        /// 获取或设置购买数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; }

                        /// <summary>
                        /// 获取或设置商品图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                        public IList<string> ImageUrlList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置商户交易商品详情页链接信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_detail_jump_link")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_detail_jump_link")]
                        public JumpLink? ItemDetailJumpLink { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商户交易订单编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_order_no")]
                public string MerchantOrderNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户交易订单详情页链接信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_detail_jump_link")]
                [System.Text.Json.Serialization.JsonPropertyName("order_detail_jump_link")]
                public Types.JumpLink? OrderDetailJumpLink { get; set; }

                /// <summary>
                /// 获取或设置订单购买的商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_list")]
                [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                public IList<Types.Item> ItemList { get; set; } = new List<Types.Item>();
            }

            public class Payer
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置订单标识信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_key")]
        [System.Text.Json.Serialization.JsonPropertyName("order_key")]
        public Types.OrderKey OrderKey { get; set; } = new Types.OrderKey();

        /// <summary>
        /// 获取或设置购物详情列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = new Types.Payer();

        /// <summary>
        /// 获取或设置物流形式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_type")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_type")]
        public string? LogisticsType { get; set; }

        /// <summary>
        /// 获取或设置上传时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("upload_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UploadTime { get; set; }
    }
}
