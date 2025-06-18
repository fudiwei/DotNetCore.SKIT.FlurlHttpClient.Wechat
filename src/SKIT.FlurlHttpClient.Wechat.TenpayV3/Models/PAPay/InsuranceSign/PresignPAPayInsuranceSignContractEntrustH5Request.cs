using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/insurance-sign/contracts/pre-entrust-sign/h5 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class PresignPAPayInsuranceSignContractEntrustH5Request : WechatTenpayRequest
    {
        public static class Types
        {
            public class Amount : PresignPAPayInsuranceSignContractEntrustJsapiRequest.Types.Amount
            {
            }

            public class PolicyPeriod : PresignPAPayInsuranceSignContractEntrustJsapiRequest.Types.PolicyPeriod
            {
            }

            public class RealIdentity : PresignPAPayInsuranceSignContractEntrustJsapiRequest.Types.RealIdentity
            {
            }

            public class JumpControl
            {
                /// <summary>
                /// 获取或设置跳转应用的 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jump_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("jump_appid")]
                public string JumpAppId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 获取或设置商户签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置被保人的展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insured_display_name")]
        [System.Text.Json.Serialization.JsonPropertyName("insured_display_name")]
        public string InsuredDisplayAccount { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置签约结果回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_notify_url")]
        public string ContractNotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户侧用户标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_user_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_user_code")]
        public string? OutUserCode { get; set; }

        /// <summary>
        /// 获取或设置保险保单的开始日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_start_date")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_start_date")]
        public string PolicyStartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保险保单的结束日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_end_date")]
        public string PolicyEndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保险保单的扣费周期列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_periods")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_periods")]
        public IList<Types.PolicyPeriod>? PolicyPeriodList { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置扣费金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount? Amount { get; set; }

        /// <summary>
        /// 获取或设置支付结果回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_notify_url")]
        public string? TransactionNotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置订单优惠标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
        public string? GoodsTag { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置是否自动续保。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("can_auto_insure")]
        [System.Text.Json.Serialization.JsonPropertyName("can_auto_insure")]
        public bool? CanAutoInsure { get; set; }

        /// <summary>
        /// 获取或设置是否自动重新投保。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("can_auto_reinsure")]
        [System.Text.Json.Serialization.JsonPropertyName("can_auto_reinsure")]
        public bool? CanAutoReinsure { get; set; }

        /// <summary>
        /// 获取或设置用户实名信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("real_identity")]
        [System.Text.Json.Serialization.JsonPropertyName("real_identity")]
        public Types.RealIdentity? RealIdentity { get; set; }

        /// <summary>
        /// 获取或设置跳转控制信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jump_control")]
        [System.Text.Json.Serialization.JsonPropertyName("jump_control")]
        public Types.JumpControl? JumpControl { get; set; }
    }
}
