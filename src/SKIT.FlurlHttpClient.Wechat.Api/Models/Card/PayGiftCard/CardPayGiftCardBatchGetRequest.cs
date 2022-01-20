namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/paygiftcard/batchget 接口的请求。</para>
    /// </summary>
    public class CardPayGiftCardBatchGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置营销规则类型。
        /// <para>默认值：RULE_TYPE_PAY_MEMBER_CARD</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "RULE_TYPE_PAY_MEMBER_CARD";

        /// <summary>
        /// 获取或设置是否仅查询生效的规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effective")]
        [System.Text.Json.Serialization.JsonPropertyName("effective")]
        public bool OnlyEffective { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Limit { get; set; } = 10;
    }
}
