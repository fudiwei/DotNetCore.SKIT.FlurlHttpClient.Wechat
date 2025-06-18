namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/kfaccount/del 接口的请求。</para>
    /// </summary>
    public class CustomServiceKfAccountDeleteRequest : WechatApiRequest, IInferable<CustomServiceKfAccountDeleteRequest, CustomServiceKfAccountDeleteResponse>
    {
        /// <summary>
        /// 获取或设置客服账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kf_account")]
        [System.Text.Json.Serialization.JsonPropertyName("kf_account")]
        public string KfAccount { get; set; } = string.Empty;
    }
}
