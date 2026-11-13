namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot
{
    /// <summary>
    /// 表示企业微信智能机器人 API 请求的基类。
    /// </summary>
    public abstract class WechatWorkAIBotRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置企业微信智能机器人的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
