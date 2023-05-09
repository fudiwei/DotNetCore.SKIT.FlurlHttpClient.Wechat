namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/getuseridkey 接口的请求。</para>
    /// </summary>
    public class CityServiceFaceIdentifyGetUserIdKeyRequest : WechatApiRequest, IInferable<CityServiceFaceIdentifyGetUserIdKeyRequest, CityServiceFaceIdentifyGetUserIdKeyResponse>
    {
        /// <summary>
        /// 获取或设置姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string CityName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置身份证号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_number")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
        public string IdCardNumber { get; set; } = string.Empty;
    }
}
