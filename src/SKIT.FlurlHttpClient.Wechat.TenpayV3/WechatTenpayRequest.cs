namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 表示微信支付 API 请求的基类。
    /// </summary>
    public abstract class WechatTenpayRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置微信请求使用的微信支付平台证书或公钥 ID，用于敏感数据字段加密。
        /// <para>如果启用了 <see cref="WechatTenpayClientOptions.AutoEncryptRequestSensitiveProperty"/> 参数，将由系统自动生成。</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? WechatpaySerialNumber { get; set; }

        /// <summary>
        /// 设置当前请求的微信支付平台证书或公钥 ID。
        /// </summary>
        /// <param name="wechatpaySerialNumber"></param>
        public void WithWechatpaySerialNumber(string? wechatpaySerialNumber)
        {
            WechatpaySerialNumber = wechatpaySerialNumber;
        }
    }
}
