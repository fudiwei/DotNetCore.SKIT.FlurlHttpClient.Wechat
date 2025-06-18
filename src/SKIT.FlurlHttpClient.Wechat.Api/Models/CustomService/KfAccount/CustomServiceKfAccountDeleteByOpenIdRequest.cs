namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /customservice/kfaccount/del 接口的请求。</para>
    /// </summary>
    public class CustomServiceKfAccountDeleteByOpenIdRequest : WechatApiRequest, IInferable<CustomServiceKfAccountDeleteByOpenIdRequest, CustomServiceKfAccountDeleteByOpenIdResponse>
    {
        /// <summary>
        /// 获取或设置客服 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;
    }
}
