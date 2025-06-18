namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/set_public_key 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataSetPublicKeyRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置公钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_key")]
        [System.Text.Json.Serialization.JsonPropertyName("public_key")]
        public string PublicKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公钥版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_key_ver")]
        [System.Text.Json.Serialization.JsonPropertyName("public_key_ver")]
        public int PublicKeyVersion { get; set; }
    }
}
