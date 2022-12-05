namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 表示企业微信 API 请求的基类。
    /// </summary>
    public abstract class WechatWorkRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// 获取或设置企业微信的 AccessToken。
        /// <para>注意：部分第三方应用开发或服务商代开发的接口中该字段表示第三方应用的 SuiteAccessToken。</para>
        /// <para>注意：部分智慧硬件开发的接口中该字段表示设备的 DeviceAccessToken。</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
