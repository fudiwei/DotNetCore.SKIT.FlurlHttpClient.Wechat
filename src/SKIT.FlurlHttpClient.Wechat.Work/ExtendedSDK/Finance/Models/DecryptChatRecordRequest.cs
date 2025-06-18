namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Models
{
    /// <summary>
    /// <para>表示会话内容存档之解密会话记录数据接口的请求。</para>
    /// </summary>
    public class DecryptChatRecordRequest : WechatWorkFinanceRequest
    {
        /// <summary>
        /// 获取或设置消息加解密公钥版本号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PublicKeyVersion { get; set; }

        /// <summary>
        /// 获取或设置经过加密的随机密钥。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EncryptedRandomKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置经过加密的聊天内容。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EncryptedChatMessage { get; set; } = string.Empty;
    }
}
