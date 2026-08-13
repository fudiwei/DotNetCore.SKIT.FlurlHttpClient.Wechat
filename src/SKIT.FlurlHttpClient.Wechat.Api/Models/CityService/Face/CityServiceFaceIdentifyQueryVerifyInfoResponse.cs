namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/queryverifyinfo 接口的响应。</para>
    /// </summary>
    public class CityServiceFaceIdentifyQueryVerifyInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置人脸核身验证结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_ret")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_ret")]
        public int VerifyResult { get; set; }
    }
}
