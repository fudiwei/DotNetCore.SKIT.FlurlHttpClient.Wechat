namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getpaidunionid 接口的响应。</para>
    /// </summary>
    public class WxaGetPaidUnionIdResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用户全局标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string UnionId { get; set; } = default!;
    }
}
