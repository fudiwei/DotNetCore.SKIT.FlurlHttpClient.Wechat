namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi
{
    /// <summary>
    /// 表示企业微信数据分析专区 API 请求的基类。
    /// </summary>
    public abstract class WechatWorkSpecialApiRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置企业微信数据分析专区的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AuthorizerCorpId { get; set; }
    }
}
