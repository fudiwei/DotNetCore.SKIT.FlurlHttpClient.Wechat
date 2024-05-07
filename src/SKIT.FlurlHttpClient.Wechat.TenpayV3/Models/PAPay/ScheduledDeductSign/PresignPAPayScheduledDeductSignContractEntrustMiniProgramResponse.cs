namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/scheduled-deduct-sign/contracts/pre-entrust-sign/mini-program 接口的响应。</para>
    /// </summary>
    public class PresignPAPayScheduledDeductSignContractEntrustMiniProgramResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预签约会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_entrustweb_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_entrustweb_id")]
        public string PresignSessionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置跳转小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_appid")]
        public string RedirectAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置跳转小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_path")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_path")]
        public string RedirectPagePath { get; set; } = default!;
    }
}
