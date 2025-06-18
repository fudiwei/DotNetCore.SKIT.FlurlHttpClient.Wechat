namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/profitsharing/receivers/delete 接口的响应。</para>
    /// </summary>
    public class DeleteEcommerceProfitSharingReceiverResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置接收方类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置接收方账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        public string Account { get; set; } = default!;
    }
}
