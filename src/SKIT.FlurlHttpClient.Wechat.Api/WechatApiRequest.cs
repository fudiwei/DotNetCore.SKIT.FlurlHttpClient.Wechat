namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 表示微信 API 请求的基类。
    /// </summary>
    public abstract class WechatApiRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置微信 AccessToken。
        /// </summary>
        /// <remarks>
        /// （注意：该属性在部分开放平台的接口中表示授权方的 AuthorizerAccessToken。）
        /// </remarks>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
