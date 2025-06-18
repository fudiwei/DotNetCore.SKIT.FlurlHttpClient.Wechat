namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 表示企业微信 API 请求的基类。
    /// </summary>
    public abstract class WechatWorkRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置企业微信的 AccessToken。
        /// <para>
        /// 注意：部分第三方应用开发或服务商代开发的接口中该字段表示第三方应用的 SuiteAccessToken。
        /// </para>
        /// <para>
        /// 注意：部分智慧硬件开发的接口中该字段表示设备的 DeviceAccessToken。
        /// </para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
