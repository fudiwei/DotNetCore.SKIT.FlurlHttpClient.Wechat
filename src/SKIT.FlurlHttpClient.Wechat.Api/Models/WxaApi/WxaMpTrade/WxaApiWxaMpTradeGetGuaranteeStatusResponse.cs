namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/wxamptrade/get_guarantee_status 接口的响应。</para>
    /// </summary>
    public class WxaApiWxaMpTradeGetGuaranteeStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否激活交易保障。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isActived")]
        [System.Text.Json.Serialization.JsonPropertyName("isActived")]
        public bool IsActived { get; set; }

        /// <summary>
        /// 获取或设置保障标状态相关信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Message { get; set; }

        /// <summary>
        /// 获取或设置未能开通保障标的原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasons")]
        [System.Text.Json.Serialization.JsonPropertyName("reasons")]
        public string[]? ReasonList { get; set; }
    }
}
