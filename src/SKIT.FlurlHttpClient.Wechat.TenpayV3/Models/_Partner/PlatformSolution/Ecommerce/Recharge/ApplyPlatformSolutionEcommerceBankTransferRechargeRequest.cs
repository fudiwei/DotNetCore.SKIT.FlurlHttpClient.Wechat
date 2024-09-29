namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/bank-transfer-recharges/apply 接口的请求。</para>
    /// </summary>
    public class ApplyPlatformSolutionEcommerceBankTransferRechargeRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class RechargeAmount : ApplyBankTransferRechargeRequest.Types.RechargeAmount
            {
            }
        }

        /// <summary>
        /// 获取或设置商户充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_recharge_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_recharge_no")]
        public string OutRechargeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置充值场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_scene")]
        public string RechargeScene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置充值入账账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string AccountType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置充值金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_amount")]
        public Types.RechargeAmount RechargeAmount { get; set; } = new Types.RechargeAmount();
    }
}
