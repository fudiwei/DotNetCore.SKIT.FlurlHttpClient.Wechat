namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/getinfo 接口的响应。</para>
    /// </summary>
    public class CityServiceFaceIdentifyGetInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置认证结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identify_ret")]
        [System.Text.Json.Serialization.JsonPropertyName("identify_ret")]
        public int IdentifyResult { get; set; }

        /// <summary>
        /// 获取或设置认证时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identify_time")]
        [System.Text.Json.Serialization.JsonPropertyName("identify_time")]
        public long IdentifyTimestamp { get; set; }

        /// <summary>
        /// 获取或设置验证数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validate_data")]
        [System.Text.Json.Serialization.JsonPropertyName("validate_data")]
        public string? ValidateData { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置后台交互凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id_key")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id_key")]
        public string? UserIdKey { get; set; }

        /// <summary>
        /// 获取或设置姓名的 MD5 值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name_utf8_md5")]
        [System.Text.Json.Serialization.JsonPropertyName("name_utf8_md5")]
        public string? NameMd5 { get; set; }

        /// <summary>
        /// 获取或设置身份证号码的 MD5 值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_number_md5")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_number_md5")]
        public string? IdCardNumberMd5 { get; set; }

        /// <summary>
        /// 获取或设置认证结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_time")]
        [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
        public long? FinishTimestamp { get; set; }
    }
}
