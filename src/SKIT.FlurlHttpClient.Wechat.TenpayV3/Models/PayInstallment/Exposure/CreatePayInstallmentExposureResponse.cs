namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/instal/exposure 接口的响应。</para>
    /// </summary>
    public class CreatePayInstallmentExposureResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置是否建议曝光微信分付。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recommend_exposure")]
        [System.Text.Json.Serialization.JsonPropertyName("recommend_exposure")]
        public bool IsRecommendExposed { get; set; }
    }
}
