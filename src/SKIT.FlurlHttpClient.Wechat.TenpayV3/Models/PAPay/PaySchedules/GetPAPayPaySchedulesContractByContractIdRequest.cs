namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/pay/schedules/contract-id/{contract_id} 接口的请求。</para>
    /// </summary>
    public class GetPAPayPaySchedulesContractByContractIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置委托代扣签约协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ContractId { get; set; } = string.Empty;
    }
}
