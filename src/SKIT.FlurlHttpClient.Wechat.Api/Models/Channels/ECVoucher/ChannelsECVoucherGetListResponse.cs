namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/get_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECVoucherGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Voucher
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_type")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_type")]
                public int VoucherType { get; set; }

                /// <summary>
                /// 获取或设置券售卖价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_buy_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_buy_amount")]
                public int VoucherBuyAmount { get; set; }

                /// <summary>
                /// 获取或设置券市场金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_actual_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_actual_amount")]
                public int VoucherActualAmount { get; set; }

                /// <summary>
                /// 获取或设置券码类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_type")]
                [System.Text.Json.Serialization.JsonPropertyName("code_type")]
                public int CodeType { get; set; }

                /// <summary>
                /// 获取或设置券码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string Code { get; set; } = default!;

                /// <summary>
                /// 获取或设置券状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置发放时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_time")]
                [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                public long SendTimestamp { get; set; }

                /// <summary>
                /// 获取或设置有效期开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置有效期结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置核销时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consume_time")]
                [System.Text.Json.Serialization.JsonPropertyName("consume_time")]
                public long? ConsumeTimestamp { get; set; }

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
                /// 获取或设置退款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_time")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_time")]
                public long? RefundTimestamp { get; set; }

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("union_id")]
                [System.Text.Json.Serialization.JsonPropertyName("union_id")]
                public string? UnionId { get; set; }

                /// <summary>
                /// 获取或设置用户的手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("telphone_no")]
                [System.Text.Json.Serialization.JsonPropertyName("telphone_no")]
                public string? TelephoneNumber { get; set; }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置结算状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_settle_status")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_settle_status")]
                public int? VoucherSettleStatus { get; set; }

                /// <summary>
                /// 获取或设置最后一次成功发起核销的核销单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("last_consume_no")]
                [System.Text.Json.Serialization.JsonPropertyName("last_consume_no")]
                public string? LastConsumeNumber { get; set; }

                /// <summary>
                /// 获取或设置最后一次成功发起撤销核销的撤销核销单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("last_withdraw_consume_no")]
                [System.Text.Json.Serialization.JsonPropertyName("last_withdraw_consume_no")]
                public string? LastWithdrawConsumeNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置团购优惠券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_list")]
        [System.Text.Json.Serialization.JsonPropertyName("voucher_list")]
        public Types.Voucher[] VoucherList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_ctx")]
        [System.Text.Json.Serialization.JsonPropertyName("page_ctx")]
        public string? NextCursor { get; set; }
    }
}
