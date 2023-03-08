namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance
{
    /// <summary>
    /// 表示企业微信会话内容存档 API 请求的基类。
    /// </summary>
    public abstract class WechatWorkFinanceRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="WechatWorkFinanceClient"/> 时的 <see cref="WechatWorkFinanceClientOptions.Timeout"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }
    }
}
