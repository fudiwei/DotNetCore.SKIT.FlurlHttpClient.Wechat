using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /catering/orders/sync-status 接口的请求。</para>
    /// </summary>
    public class SyncCateringOrderStatusRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Dish
            {
                /// <summary>
                /// 获取或设置商户菜品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_dish_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_dish_no")]
                public string OutDishNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置菜品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置菜品单价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置菜品单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unit")]
                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                public string Unit { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置菜品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public decimal Count { get; set; }

                /// <summary>
                /// 获取或设置菜品折扣（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount")]
                [System.Text.Json.Serialization.JsonPropertyName("discount")]
                public int? DiscountRate { get; set; }

                /// <summary>
                /// 获取或设置菜品分类。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置菜品顺序。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("priority")]
                [System.Text.Json.Serialization.JsonPropertyName("priority")]
                public int? Priority { get; set; }

                /// <summary>
                /// 获取或设置菜品属性字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("properties")]
                [System.Text.Json.Serialization.JsonPropertyName("properties")]
                public IDictionary<string, string>? Properties { get; set; }
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
        /// 获取或设置商户旗下门店的唯一编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_shop_no")]
        public string OutShopNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户在子商户下的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置登录凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("login_token")]
        [System.Text.Json.Serialization.JsonPropertyName("login_token")]
        public string LoginToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置点餐入口。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_entry")]
        [System.Text.Json.Serialization.JsonPropertyName("order_entry")]
        public string OrderEntryPath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置总价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置优惠金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
        public int DiscountAmount { get; set; }

        /// <summary>
        /// 获取或设置实际支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("user_amount")]
        public int UserAmount { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("action_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ActionTime { get; set; }

        /// <summary>
        /// 获取或设置支付时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? PayTime { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户桌台号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_table_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_table_no")]
        public string? OutTableNumber { get; set; }

        /// <summary>
        /// 获取或设置消费人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("people_count")]
        [System.Text.Json.Serialization.JsonPropertyName("people_count")]
        public int? PeopleCount { get; set; }

        /// <summary>
        /// 获取或设置菜品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dish_list")]
        [System.Text.Json.Serialization.JsonPropertyName("dish_list")]
        public IList<Types.Dish>? DishList { get; set; }
    }
}
