namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/getverifyid 接口的响应。</para>
    /// </summary>
    public class CityServiceFaceIdentifyGetVerifyIdResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置人脸核身会话唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_id")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_id")]
        public string VerifyId { get; set; } = default!;

        /// <summary>
        /// 获取或设置人脸核身会话唯一标识有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
