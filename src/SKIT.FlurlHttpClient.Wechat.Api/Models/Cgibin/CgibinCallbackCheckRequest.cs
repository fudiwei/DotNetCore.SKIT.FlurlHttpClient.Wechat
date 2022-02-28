namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/callback/check 接口的请求。</para>
    /// </summary>
    public class CgibinCallbackCheckRequest : WechatApiRequest, IInferable<CgibinCallbackCheckRequest, CgibinCallbackCheckResponse>
    {
        /// <summary>
        /// 获取或设置执行的检测动作。
        /// <para>默认值：all</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "all";

        /// <summary>
        /// 获取或设置指定平台从某个运营商进行检测。
        /// <para>默认值：DEFAULT</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_operator")]
        [System.Text.Json.Serialization.JsonPropertyName("check_operator")]
        public string CheckOperator { get; set; } = "DEFAULT";
    }
}
