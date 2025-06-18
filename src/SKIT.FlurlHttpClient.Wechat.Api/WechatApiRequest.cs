namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 表示微信 API 请求的基类。
    /// </summary>
    public abstract class WechatApiRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置微信 AccessToken。
        /// <para>
        /// 注意：部分开放平台的接口中该字段表示授权方的 AuthorizerAccessToken。
        /// </para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
