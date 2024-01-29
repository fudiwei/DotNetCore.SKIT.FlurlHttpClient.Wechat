namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    /// <summary>
    /// 表示微企付 API 请求的基类。
    /// </summary>
    public abstract class WechatTenpayBusinessRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求使用的微企付敏感字段加密参数。
        /// <para>如果启用了 <see cref="WechatTenpayBusinessClientOptions.AutoEncryptRequestSensitiveProperty"/> 参数，将由系统自动生成。</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual WechatTenpayBusinessRequestEncryption? WechatpayEncryption { get; set; }
    }

    public sealed class WechatTenpayBusinessRequestEncryption
    {
        /// <summary>
        /// 获取或设置加密后的密钥值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EncryptedKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 CBC IV。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string IV { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微企付证书序列号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置加密算法。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Algorithm { get; set; } = string.Empty;
    }
}
