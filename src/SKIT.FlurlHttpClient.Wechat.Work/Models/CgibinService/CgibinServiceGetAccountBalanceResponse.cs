namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/service/get_account_balance 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetAccountBalanceResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置充值账户余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }
    }
}
