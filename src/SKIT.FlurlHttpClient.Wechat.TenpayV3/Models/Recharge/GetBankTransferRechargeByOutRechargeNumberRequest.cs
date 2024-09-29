namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /recharge/bank-transfer-recharges/out-recharge-no/{out_recharge_no} 接口的请求。</para>
    /// </summary>
    public class GetBankTransferRechargeByOutRechargeNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutRechargeNumber { get; set; } = string.Empty;
    }
}
