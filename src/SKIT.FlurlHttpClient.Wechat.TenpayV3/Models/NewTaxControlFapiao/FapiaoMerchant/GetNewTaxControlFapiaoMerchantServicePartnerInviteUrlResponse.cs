namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /new-tax-control-fapiao/fapiaomerchant/getspinviteurl 接口的响应。</para>
    /// </summary>
    public class GetNewTaxControlFapiaoMerchantServicePartnerInviteUrlResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置邀请开通二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invite_url")]
        [System.Text.Json.Serialization.JsonPropertyName("invite_url")]
        public string InviteUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置开通小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_appid")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置开通小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_path")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_path")]
        public string MiniProgramPagePath { get; set; } = default!;
    }
}
