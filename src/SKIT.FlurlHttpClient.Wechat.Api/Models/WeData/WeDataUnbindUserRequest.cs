namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wedata/wedata_unbind_user 接口的请求。</para>
    /// </summary>
    public class WeDataUnbindUserRequest : WechatApiRequest, IInferable<WeDataUnbindUserRequest, WeDataUnbindUserResponse>
    {
        /// <summary>
        /// 获取或设置用户在服务商系统的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string UserId { get; set; } = string.Empty;
    }
}
