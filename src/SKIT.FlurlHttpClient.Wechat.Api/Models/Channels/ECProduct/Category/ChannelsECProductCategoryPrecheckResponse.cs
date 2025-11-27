namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/categoryprecheck 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductCategoryPrecheckResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否类目全部校验通过。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("all_pass")]
        [System.Text.Json.Serialization.JsonPropertyName("all_pass")]
        public bool IsAllPass { get; set; }

        /// <summary>
        /// 获取或设置校验不通过的原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reasons")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reasons")]
        public string[]? FailReasonList { get; set; }
    }
}
