namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/getrealname 接口的响应。</para>
    /// </summary>
    public class NontaxGetRealNameResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置密钥的非对称加密算法。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key_encrypt_type")]
        [System.Text.Json.Serialization.JsonPropertyName("key_encrypt_type")]
        public string KeyEncryptType { get; set; } = default!;

        /// <summary>
        /// 获取或设置经过加密的密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key")]
        [System.Text.Json.Serialization.JsonPropertyName("key")]
        public string EncryptedKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置数据的非对称加密算法。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_encrypt_type")]
        [System.Text.Json.Serialization.JsonPropertyName("data_encrypt_type")]
        public string DataEncryptType { get; set; } = default!;

        /// <summary>
        /// 获取或设置经过加密的数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string EncryptedData { get; set; } = default!;
    }
}
