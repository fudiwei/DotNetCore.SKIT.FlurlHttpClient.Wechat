namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/getinfo 接口的请求。</para>
    /// </summary>
    public class CityServiceFaceIdentifyGetInfoRequest : WechatApiRequest, IInferable<CityServiceFaceIdentifyGetInfoRequest, CityServiceFaceIdentifyGetInfoResponse>
    {
        /// <summary>
        /// 获取或设置人脸验证结果加密数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_result")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_result")]
        public string VerifyResult { get; set; } = string.Empty;
    }
}
