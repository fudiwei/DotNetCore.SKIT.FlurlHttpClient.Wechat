namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/getuseridkey 接口的响应。</para>
    /// </summary>
    public class CityServiceFaceIdentifyGetUserIdKeyResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置后台交互凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id_key")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id_key")]
        public string UserIdKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置后台交互凭证有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
