namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbaggregate 接口的响应。</para>
    /// </summary>
    public class ComponentTCBDbAggregateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置查询数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string[]? Data { get; set; }
    }
}
