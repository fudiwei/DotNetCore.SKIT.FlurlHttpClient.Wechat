namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/getimage 接口的请求。</para>
    /// </summary>
    public class CityServiceFaceIdentifyGetImageRequest : WechatApiRequest, IInferable<CityServiceFaceIdentifyGetImageRequest, CityServiceFaceIdentifyGetImageResponse>
    {
        /// <summary>
        /// 获取或设置人脸验证结果加密数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_result")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_result")]
        public string VerifyResult { get; set; } = string.Empty;
    }
}
