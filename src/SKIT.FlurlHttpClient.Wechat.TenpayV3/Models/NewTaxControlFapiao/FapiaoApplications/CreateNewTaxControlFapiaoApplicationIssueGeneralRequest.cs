using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /new-tax-control-fapiao/fapiao-applications/issue-general 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateNewTaxControlFapiaoApplicationIssueGeneralRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Buyer : CreateNewTaxControlFapiaoApplicationRequest.Types.Buyer
            {
            }

            public class FapiaoInfo
            {
                public static class Types
                {
                    public class Item : CreateNewTaxControlFapiaoApplicationRequest.Types.Fapiao.Types.Item
                    {
                        /// <summary>
                        /// 获取或设置优惠政策标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("preferential_policy_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("preferential_policy_code")]
                        public int? PreferentialPolicyCode { get; set; }
                    }

                    public class Transaction
                    {
                        /// <summary>
                        /// 获取或设置支付渠道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_channel")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_channel")]
                        public string PayChannel { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置微信支付交易单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                        public string? TransactionId { get; set; }

                        /// <summary>
                        /// 获取或设置商户订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_trade_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                        public string? OutTradeNumber { get; set; }

                        /// <summary>
                        /// 获取或设置交易金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商户发票单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_id")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_id")]
                public string FapiaoId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置总价税合计（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置发票行列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public IList<Types.Item>? ItemList { get; set; }

                /// <summary>
                /// 获取或设置交易信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_information")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_information")]
                public IList<Types.Transaction>? TransactionList { get; set; }

                /// <summary>
                /// 获取或设置出口业务适用政策代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("export_business_policy_code")]
                [System.Text.Json.Serialization.JsonPropertyName("export_business_policy_code")]
                public int? ExportBusinessPolicyCode { get; set; }

                /// <summary>
                /// 获取或设置增值税即征即退代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vat_refund_levy_code")]
                [System.Text.Json.Serialization.JsonPropertyName("vat_refund_levy_code")]
                public int? VATRefundLevyCode { get; set; }

                /// <summary>
                /// 获取或设置开票人 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("billing_person_id")]
                [System.Text.Json.Serialization.JsonPropertyName("billing_person_id")]
                public string BillingPersonId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开票人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("billing_person")]
                [System.Text.Json.Serialization.JsonPropertyName("billing_person")]
                public string? BillingPersonName { get; set; }

                /// <summary>
                /// 获取或设置开具发票类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_bill_type")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_bill_type")]
                public string? FapiaoBillType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置备注信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置发票申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_apply_id")]
        public string FapiaoApplyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置购买方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_information")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_information")]
        public Types.Buyer Buyer { get; set; } = new Types.Buyer();

        /// <summary>
        /// 获取或设置电子发票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_information")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_information")]
        public Types.FapiaoInfo FapiaoInfo { get; set; } = new Types.FapiaoInfo();
    }
}
