namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalpay/get_bill_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalPayGetBillListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Bill
            {
                public static class Types
                {
                    public class Commodity
                    {
                        /// <summary>
                        /// 获取或设置商品描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int? Count { get; set; }
                    }

                    public class Refund
                    {
                        /// <summary>
                        /// 获取或设置商户退款单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_refund_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
                        public string OutRefundNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款发起人成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_userid")]
                        public string RefundUserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_comment")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_comment")]
                        public string RefundComment { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款发起时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_reqtime")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_reqtime")]
                        public long RefundRequestTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置退款状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                        public int RefundStatus { get; set; }

                        /// <summary>
                        /// 获取或设置退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_fee")]
                        public int RefundFee { get; set; }
                    }

                    public class Contact
                    {
                        /// <summary>
                        /// 获取或设置姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone")]
                        public string? PhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置微信支付商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_id")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置交易单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string TransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置交易状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_state")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_state")]
                public int TradeState { get; set; }

                /// <summary>
                /// 获取或设置付款人外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string PayerExternalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置收款人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payee_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("payee_userid")]
                public string PayeeUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("total_fee")]
                public int TotalFee { get; set; }

                /// <summary>
                /// 获取或设置已退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_refund_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("total_refund_fee")]
                public int RefundFee { get; set; }

                /// <summary>
                /// 获取或设置收款方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_type")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_type")]
                public int PaymentType { get; set; }

                /// <summary>
                /// 获取或设置交易时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string Remark { get; set; } = default!;

                /// <summary>
                /// 获取或设置联系人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_info")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_info")]
                public Types.Contact? Contact { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commodity_list")]
                [System.Text.Json.Serialization.JsonPropertyName("commodity_list")]
                public Types.Commodity[]? CommodityList { get; set; }

                /// <summary>
                /// 获取或设置退款列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_list")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_list")]
                public Types.Refund[]? RefundList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置交易单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_list")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_list")]
        public Types.Bill[] BillList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
