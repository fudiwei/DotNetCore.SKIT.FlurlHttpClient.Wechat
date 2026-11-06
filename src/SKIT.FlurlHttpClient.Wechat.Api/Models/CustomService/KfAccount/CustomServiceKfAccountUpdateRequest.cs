namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/kfaccount/update 接口的请求。</para>
    /// </summary>
    public class CustomServiceKfAccountUpdateRequest : WechatApiRequest, IInferable<CustomServiceKfAccountUpdateRequest, CustomServiceKfAccountUpdateResponse>
    {
        /// <summary>
        /// 获取或设置客服账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kf_account")]
        [System.Text.Json.Serialization.JsonPropertyName("kf_account")]
        public string? KfAccount { get; set; }

        /// <summary>
        /// 获取或设置客服昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }
    }
}
