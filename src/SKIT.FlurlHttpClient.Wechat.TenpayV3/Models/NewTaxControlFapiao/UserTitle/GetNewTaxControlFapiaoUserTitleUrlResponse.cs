namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /new-tax-control-fapiao/user-title/title-url 接口的响应。</para>
    /// </summary>
    public class GetNewTaxControlFapiaoUserTitleUrlResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_appid")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_path")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_path")]
        public string MiniProgramPagePath { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序用户名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_user_name")]
        public string? MiniProgramUsername { get; set; } = default!;
    }
}
