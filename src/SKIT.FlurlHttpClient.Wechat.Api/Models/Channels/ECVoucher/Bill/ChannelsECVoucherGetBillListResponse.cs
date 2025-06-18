namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/get_bill_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECVoucherGetBillListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class VoucherBill
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置券名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_name")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_name")]
                public string VoucherName { get; set; } = default!;

                /// <summary>
                /// 获取或设置券码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string VoucherCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置券售卖价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_buy_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_buy_amount")]
                public int VoucherBuyAmount { get; set; }

                /// <summary>
                /// 获取或设置用户支付金额金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_pay_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_pay_amount")]
                public int VoucherPayAmount { get; set; }

                /// <summary>
                /// 获取或设置商家优惠减价金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_favor_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_favor_amount")]
                public int MerchantFavorAmount { get; set; }

                /// <summary>
                /// 获取或设置平台优惠减价金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_favor_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_favor_amount")]
                public int PlatformFavorAmount { get; set; }

                /// <summary>
                /// 获取或设置商家已结算金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_settle_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_settle_amount")]
                public int MerchantSettleAmount { get; set; }

                /// <summary>
                /// 获取或设置达人已结算金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_settle_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_settle_amount")]
                public int FinderSettleAmount { get; set; }

                /// <summary>
                /// 获取或设置购买时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_buy_time")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_buy_time")]
                public long BuyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置核销时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consume_time")]
                [System.Text.Json.Serialization.JsonPropertyName("consume_time")]
                public long ConsumeTimestamp { get; set; }

                /// <summary>
                /// 获取或设置核销门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consume_store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("consume_store_name")]
                public string? ConsumeStoreName { get; set; }

                /// <summary>
                /// 获取或设置核销门店外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_store_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_store_id")]
                public string? OutStoreId { get; set; }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置次卡序号标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_index")]
                [System.Text.Json.Serialization.JsonPropertyName("time_index")]
                public int? TimeIndex { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置团购优惠券账单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_list")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_list")]
        public Types.VoucherBill[] VoucherBillList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_ctx")]
        [System.Text.Json.Serialization.JsonPropertyName("page_ctx")]
        public string? NextCursor { get; set; }
    }
}
