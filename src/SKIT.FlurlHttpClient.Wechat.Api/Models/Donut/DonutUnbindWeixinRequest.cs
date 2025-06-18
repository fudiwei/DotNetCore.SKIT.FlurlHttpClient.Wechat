namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /donut/unbindweixin 接口的请求。</para>
    /// </summary>
    public class DonutUnbindWeixinRequest : WechatApiRequest, IInferable<DonutUnbindWeixinRequest, DonutUnbindWeixinResponse>
    {
        /// <summary>
        /// 获取或设置多端用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }
}
