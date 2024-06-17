namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/getmedrealname 接口的响应。</para>
    /// </summary>
    public class CityServiceGetMedicalRealNameResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置业务方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置实名信息加密密钥版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key_version")]
        [System.Text.Json.Serialization.JsonPropertyName("key_version")]
        public int KeyVersion { get; set; }

        /// <summary>
        /// 获取或设置加密后的实名信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cipher_real_name")]
        [System.Text.Json.Serialization.JsonPropertyName("cipher_real_name")]
        public string CipherRealName { get; set; } = default!;

        /// <summary>
        /// 获取或设置加密算法。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cipher_algorithm")]
        [System.Text.Json.Serialization.JsonPropertyName("cipher_algorithm")]
        public string CipherAlgorithm { get; set; } = default!;
    }
}
