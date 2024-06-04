namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 表示微信智能对话 API 请求的基类。
    /// </summary>
    public abstract class WechatOpenAIRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置微信智能对话 API 接口访问令牌。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置微信智能对话 API 请求唯一标识。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? RequestId { get; set; }
    }
}
