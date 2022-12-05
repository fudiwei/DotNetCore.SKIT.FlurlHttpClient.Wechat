namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/security/getorderpathinfo 接口的请求。</para>
    /// </summary>
    public class WxaSecurityGetOrderPathInfoRequest : WechatApiRequest, IInferable<WxaSecurityGetOrderPathInfoRequest, WxaSecurityGetOrderPathInfoResponse>
    {
        /// <summary>
        /// 获取或设置小程序版本信息类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int InfoType { get; set; }
    }
}
