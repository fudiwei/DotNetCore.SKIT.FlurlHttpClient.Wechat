namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /donut/unbindapple 接口的请求。</para>
    /// </summary>
    public class DonutUnbindAppleRequest : WechatApiRequest, IInferable<DonutUnbindAppleRequest, DonutUnbindAppleResponse>
    {
        /// <summary>
        /// 获取或设置多端用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }
}
