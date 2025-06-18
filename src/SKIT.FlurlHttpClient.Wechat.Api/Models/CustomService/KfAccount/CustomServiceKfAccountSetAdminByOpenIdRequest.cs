namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /customservice/kfaccount/setadmin 接口的请求。</para>
    /// </summary>
    public class CustomServiceKfAccountSetAdminByOpenIdRequest : WechatApiRequest, IInferable<CustomServiceKfAccountSetAdminByOpenIdRequest, CustomServiceKfAccountSetAdminByOpenIdResponse>
    {
        /// <summary>
        /// 获取或设置客服 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;
    }
}
