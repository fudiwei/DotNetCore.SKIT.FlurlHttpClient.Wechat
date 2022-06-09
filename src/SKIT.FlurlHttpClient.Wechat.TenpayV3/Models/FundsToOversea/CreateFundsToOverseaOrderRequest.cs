using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /funds-to-oversea/orders 接口的请求。</para>
    /// </summary>
    public class CreateFundsToOverseaOrderRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Goods
            {
                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_name")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                public string GoodsName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品类目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_category")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_category")]
                public string? GoodsCategory { get; set; }

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_quantity")]
                public int Quantity { get; set; }

                /// <summary>
                /// 获取或设置商品单价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_unit_price")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_unit_price")]
                public int UnitPrice { get; set; }
            }

            public class Seller
            {
                /// <summary>
                /// 获取或设置境外卖家经营主体名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("oversea_business_name")]
                [System.Text.Json.Serialization.JsonPropertyName("oversea_business_name")]
                public string OverseaBusinessName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置境外卖家店铺名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("oversea_shop_name")]
                [System.Text.Json.Serialization.JsonPropertyName("oversea_shop_name")]
                public string OverseaShopName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置卖家 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_id")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_id")]
                public string SellerId { get; set; } = string.Empty;
            }

            public class Express
            {
                /// <summary>
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("courier_number")]
                [System.Text.Json.Serialization.JsonPropertyName("courier_number")]
                public string CourierNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置物流商名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express_company_name")]
                [System.Text.Json.Serialization.JsonPropertyName("express_company_name")]
                public string ExpressCompanyName { get; set; } = string.Empty;
            }

            public class Payee
            {
                /// <summary>
                /// 获取或设置付款人 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payee_id")]
                [System.Text.Json.Serialization.JsonPropertyName("payee_id")]
                public string PayeeId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户出境单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置出境金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置境外收款币种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("foreign_currency")]
        [System.Text.Json.Serialization.JsonPropertyName("foreign_currency")]
        public string ForeignCurrency { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_info")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_info")]
        public IList<Types.Goods>? GoodsList { get; set; }

        /// <summary>
        /// 获取或设置卖家信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_info")]
        [System.Text.Json.Serialization.JsonPropertyName("seller_info")]
        public Types.Seller Seller { get; set; } = new Types.Seller();

        /// <summary>
        /// 获取或设置物流信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("express_info")]
        [System.Text.Json.Serialization.JsonPropertyName("express_info")]
        public Types.Express Express { get; set; } = new Types.Express();

        /// <summary>
        /// 获取或设置付款人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_info")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_info")]
        public Types.Payee Payee { get; set; } = new Types.Payee();
    }
}
