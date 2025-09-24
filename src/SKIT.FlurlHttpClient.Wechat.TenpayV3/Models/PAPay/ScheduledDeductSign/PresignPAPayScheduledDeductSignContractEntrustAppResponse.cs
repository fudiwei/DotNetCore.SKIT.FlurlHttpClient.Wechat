namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/scheduled-deduct-sign/contracts/pre-entrust-sign/app 接口的响应。</para>
    /// </summary>
    public class PresignPAPayScheduledDeductSignContractEntrustAppResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预签约会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_entrustweb_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_entrustweb_id")]
        public string PresignSessionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置跳转签约小程序的账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_username")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_username")]
        public string? MiniProgramUsername { get; set; }

        /// <summary>
        /// 获取或设置跳转签约小程序的页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_path")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_path")]
        public string? MiniProgramPagePath { get; set; }
    }
}
