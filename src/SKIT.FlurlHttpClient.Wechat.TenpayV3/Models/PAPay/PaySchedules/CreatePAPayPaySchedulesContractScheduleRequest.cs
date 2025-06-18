namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/pay/schedules/contract-id/{contract_id}/schedule 接口的请求。</para>
    /// </summary>
    public class CreatePAPayPaySchedulesContractScheduleRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Amount : PresignPAPayScheduledDeductSignContractEntrustAppRequest.Types.DeductSchedule.Types.Amount
            {
            }
        }

        /// <summary>
        /// 获取或设置委托代扣签约协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ContractId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预约的金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_amount")]
        public Types.Amount ScheduledAmount { get; set; } = new Types.Amount();
    }
}
