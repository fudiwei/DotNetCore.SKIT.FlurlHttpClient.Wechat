namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/contracts/miniprogram-pre-entrust-sign 接口的响应。</para>
    /// </summary>
    public class PresignHKPAPPayContractEntrustMiniProgramResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置委托代扣会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_id")]
        [System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string SessionId { get; set; } = default!;
    }
}
