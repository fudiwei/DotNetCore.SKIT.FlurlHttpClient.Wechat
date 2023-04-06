namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /apply4subject/applyment/merchants/{sub_mchid}/state 接口的响应。</para>
    /// </summary>
    public class GetApplyForSubjectApplymentMerchantStateResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_state")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_state")]
        public string AuthorizeState { get; set; } = default!;
    }
}
