namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-open/cards/{card_id}/permission-tokens 接口的请求。</para>
    /// </summary>
    public class CreateMarketingMemberCardOpenCardPermissionTokenRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置激活类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activate_type")]
        [System.Text.Json.Serialization.JsonPropertyName("activate_type")]
        public string ActivateType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否在用户在开卡完成后返回拉起开卡组件的商家页面。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("navigate_back_previous_page")]
        [System.Text.Json.Serialization.JsonPropertyName("navigate_back_previous_page")]
        public bool? RequireNavigateBackPreviousPage { get; set; }

        /// <summary>
        /// 获取或设置激活跳转 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activate_url")]
        [System.Text.Json.Serialization.JsonPropertyName("activate_url")]
        public string? ActivateUrl { get; set; }

        /// <summary>
        /// 获取或设置激活跳转小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activate_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("activate_appid")]
        public string? ActivateMiniProgramAppId { get; set; }

        /// <summary>
        /// 获取或设置激活跳转小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activate_path")]
        [System.Text.Json.Serialization.JsonPropertyName("activate_path")]
        public string ActivateMiniProgramPath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outer_str")]
        [System.Text.Json.Serialization.JsonPropertyName("outer_str")]
        public string? OuterString { get; set; }
    }
}
