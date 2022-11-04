namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/checkmobile 接口的响应。</para>
    /// </summary>
    public class TCBCheckMobileResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否绑定了手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("has_mobile")]
        public bool HasMobile { get; set; }
    }
}
