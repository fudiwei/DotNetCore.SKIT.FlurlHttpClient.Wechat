namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /customservice/kfsession/getsessionlist 接口的请求。</para>
    /// </summary>
    public class CustomServiceKfSessionGetSessionListRequest : WechatApiRequest, IMapResponse<CustomServiceKfSessionGetSessionListRequest, CustomServiceKfSessionGetSessionListResponse>
    {
        /// <summary>
        /// 获取或设置客服帐号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string KfAccount { get; set; } = string.Empty;
    }
}
