namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /smartguide/guides 接口的响应。</para>
    /// </summary>
    public class CreateSmartGuideResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置服务人员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_id")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_id")]
        public string GuideId { get; set; } = default!;
    }
}
