using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/getorder 接口的响应。</para>
    /// </summary>
    public class NontaxGetOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BillItem : NontaxUnifiedOrderRequest.Types.BillItem
            {
            }

            public class Refund
            {
                /// <summary>
                /// 获取或设置退款外部单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_out_id")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_out_id")]
                public string RefundOutId { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_order_id")]
                public string RefundOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_fee")]
                public int RefundFee { get; set; }

                /// <summary>
                /// 获取或设置退款原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
                public string RefundReason { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_status")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                public string RefundStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款完成时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_finish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_finish_time")]
                public long? RefundFinishTimestamp { get; set; }
            }

            public class NotifyHistory
            {
                public static class Types
                {
                    public class Notification
                    {
                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("errcode")]
                        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("errmsg")]
                        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                        public string? ErrorMessage { get; set; }

                        /// <summary>
                        /// 获取或设置返回码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ret")]
                        [System.Text.Json.Serialization.JsonPropertyName("ret")]
                        public int ReturnCode { get; set; }

                        /// <summary>
                        /// 获取或设置返回信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ret_errmsg")]
                        [System.Text.Json.Serialization.JsonPropertyName("ret_errmsg")]
                        public string? ReturnMessage { get; set; }

                        /// <summary>
                        /// 获取或设置接收请求的 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置随机字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wxnontaxstr")]
                        [System.Text.Json.Serialization.JsonPropertyName("wxnontaxstr")]
                        public string Nonce { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置通知状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置耗时（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cost_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cost_time")]
                        public int CostTime { get; set; }

                        /// <summary>
                        /// 获取或设置通知时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("notify_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("notify_time")]
                        public long NotifyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置第三方的返回值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_resp")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_resp")]
                        public string? ThirdPartyResponse { get; set; }

                        /// <summary>
                        /// 获取或设置第三方的返回数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_resp_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_resp_data")]
                        public string? ThirdPartyResponseData { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置微信 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置第三方 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置通知列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notify_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("notify_detail")]
                public Types.Notification[] NotificationList { get; set; } = default!;

                /// <summary>
                /// 获取或设置通知次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notify_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("notify_cnt")]
                public int NotificationCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置币种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("fee_type")]
        public int FeeType { get; set; }

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee")]
        [System.Text.Json.Serialization.JsonPropertyName("fee")]
        public int Fee { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置微信支付交易单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trans_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置银行 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_id")]
        public string? BankId { get; set; }

        /// <summary>
        /// 获取或设置银行名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string? BankName { get; set; }

        /// <summary>
        /// 获取或设置银行帐号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
        public string? BankAccount { get; set; }

        /// <summary>
        /// 获取或设置退款外部编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_out_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_out_id")]
        public string? RefundOutId { get; set; }

        /// <summary>
        /// 获取或设置退款订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_order_id")]
        public string? RefundOrderId { get; set; }

        /// <summary>
        /// 获取或设置退款原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
        public string? RefundReason { get; set; }

        /// <summary>
        /// 获取或设置退款完成时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_finish_time")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_finish_time")]
        public long? RefundFinishTimestamp { get; set; }

        /// <summary>
        /// 获取或设置退款列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partial_refund_info")]
        [System.Text.Json.Serialization.JsonPropertyName("partial_refund_info")]
        public Types.Refund[]? RefundList { get; set; }

        /// <summary>
        /// 获取或设置订单外部编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("order_no")]
        public string? OrderOutId { get; set; }

        /// <summary>
        /// 获取或设置执收单位编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_code")]
        [System.Text.Json.Serialization.JsonPropertyName("department_code")]
        public string? DepartmentCode { get; set; }

        /// <summary>
        /// 获取或设置执收单位名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_name")]
        [System.Text.Json.Serialization.JsonPropertyName("department_name")]
        public string DepartmentName { get; set; } = default!;

        /// <summary>
        /// 获取或设置缴费通知书类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_notice_type")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_notice_type")]
        public int? PaymentNoticeType { get; set; }

        /// <summary>
        /// 获取或设置缴费通知书编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_notice_no")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_notice_no")]
        public string? PaymentNoticeNumber { get; set; }

        /// <summary>
        /// 获取或设置应收款信息来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_info_source")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_info_source")]
        public int PaymentInfoType { get; set; }

        /// <summary>
        /// 获取或设置票据类型编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_type_code")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_type_code")]
        public string? BillTypeCode { get; set; }

        /// <summary>
        /// 获取或设置票据号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string? BillNumber { get; set; }

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_code")]
        [System.Text.Json.Serialization.JsonPropertyName("region_code")]
        public string RegionCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = default!;

        /// <summary>
        /// 获取或设置缴费子项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.BillItem[] BillItemList { get; set; } = default!;

        /// <summary>
        /// 获取或设置通知历史列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_history")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_history")]
        public Types.NotifyHistory[] NotifyHistoryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单支付成功时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_finish_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_finish_time")]
        public long? PayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置订单创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTimestamp { get; set; }
    }
}
