namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /password-exempt-contract/contracts/qs/pre-entrust-sign/mini-program 接口的响应。</para>
    /// </summary>
    public class PresignPasswordExemptContractQsEntrustMiniProgramResponse : WechatTenpayResponse
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
        [Newtonsoft.Json.JsonProperty("sign_mp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_mp_appid")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置跳转小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_mp_path")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_mp_path")]
        public string MiniProgramPagePath { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
        public string ServiceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = default!;
    }
}
