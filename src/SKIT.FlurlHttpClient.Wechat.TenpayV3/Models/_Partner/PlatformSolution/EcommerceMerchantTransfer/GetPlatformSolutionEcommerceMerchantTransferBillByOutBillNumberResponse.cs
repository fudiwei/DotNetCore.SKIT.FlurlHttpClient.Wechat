using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/ecommerce/mch-transfer/transfer-bills/out-bill-no/{out_bill_no} 接口的响应。</para>
    /// </summary>
    public class GetPlatformSolutionEcommerceMerchantTransferBillByOutBillNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class ReceiverDetail
            {
                public static class Types
                {
                    public class Receiver
                    {
                        public static class Types
                        {
                            public class MerchantInfo
                            {
                                /// <summary>
                                /// 获取或设置转账接收方商户号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mchid")]
                                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                                public string? MerchantId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置转账接收方类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string? Type { get; set; }

                        /// <summary>
                        /// 获取或设置转账接收方商户信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mch_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("mch_info")]
                        public Types.MerchantInfo? MerchantInfo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置赔付用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver")]
                public Types.Receiver Receiver { get; set; } = default!;
            }

            public class CloseInfo
            {
                /// <summary>
                /// 获取或设置关闭原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("close_reason")]
                public string CloseReason { get; set; } = default!;

                /// <summary>
                /// 获取或设置关闭时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("close_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CloseTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public string BusinessType { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_bill_no")]
        public string OutBillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_id")]
        public string BillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置转账接收方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_detail")]
        public Types.ReceiverDetail ReceiverDetail { get; set; } = default!;

        /// <summary>
        /// 获取或设置赔付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置付款状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置赔付原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_remark")]
        public string TransferRemark { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款方备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_remark")]
        public string? ReceiverRemark { get; set; }

        /// <summary>
        /// 获取或设置出资商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sponsor_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sponsor_mchid")]
        public string? SponsorMerchantId { get; set; }

        /// <summary>
        /// 获取或设置受理时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("accept_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AcceptTime { get; set; }

        /// <summary>
        /// 获取或设置成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置关闭信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("close_info")]
        [System.Text.Json.Serialization.JsonPropertyName("close_info")]
        public Types.CloseInfo? CloseInfo { get; set; }
    }
}
