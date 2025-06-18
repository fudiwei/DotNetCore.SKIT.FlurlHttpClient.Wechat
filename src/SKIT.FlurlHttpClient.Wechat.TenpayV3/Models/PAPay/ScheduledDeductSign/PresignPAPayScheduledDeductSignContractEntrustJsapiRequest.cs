namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/scheduled-deduct-sign/contracts/pre-entrust-sign/jsapi 接口的请求。</para>
    /// </summary>
    public class PresignPAPayScheduledDeductSignContractEntrustJsapiRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class DeductSchedule : PresignPAPayScheduledDeductSignContractEntrustAppRequest.Types.DeductSchedule
            {
                public static new class Types
                {
                    public class Amount : PresignPAPayScheduledDeductSignContractEntrustAppRequest.Types.DeductSchedule.Types.Amount
                    {
                    }
                }
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
        /// 获取或设置用户账户展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_display_account")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_display_account")]
        public string ContractDisplayAccount { get; set; } = string.Empty;

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
        /// 获取或设置预约信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_schedule")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_schedule")]
        public Types.DeductSchedule? DeductSchedule { get; set; }
    }
}
