namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/contracts/app-pre-entrust-sign 接口的响应。</para>
    /// </summary>
    public class PresignPAPPayContractEntrustAppResponse : WechatTenpayGlobalResponse
    {
        /// <summary>
        /// 获取或设置委托代扣签约会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_id")]
        [System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string SessionId { get; set; } = default!;
    }
}
