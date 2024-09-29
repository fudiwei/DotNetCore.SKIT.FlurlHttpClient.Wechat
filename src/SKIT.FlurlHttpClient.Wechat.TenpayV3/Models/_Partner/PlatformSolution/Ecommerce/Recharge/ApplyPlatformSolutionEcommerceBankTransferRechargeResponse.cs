namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/bank-transfer-recharges/apply 接口的响应。</para>
    /// </summary>
    public class ApplyPlatformSolutionEcommerceBankTransferRechargeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TransferInAccount : ApplyBankTransferRechargeResponse.Types.TransferInAccount
            {
            }
        }

        /// <summary>
        /// 获取或设置商户充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_recharge_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_recharge_no")]
        public string OutRechargeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_id")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_id")]
        public string RechargeId { get; set; } = default!;

        /// <summary>
        /// 获取或设置充值目标账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_in_account")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_in_account")]
        public Types.TransferInAccount TransferInAccount { get; set; } = default!;
    }
}
