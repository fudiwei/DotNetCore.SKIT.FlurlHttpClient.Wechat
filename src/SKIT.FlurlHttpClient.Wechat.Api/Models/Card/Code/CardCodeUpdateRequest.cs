namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/code/update 接口的请求。</para>
    /// </summary>
    public class CardCodeUpdateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置原卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string OldCardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_code")]
        [System.Text.Json.Serialization.JsonPropertyName("new_code")]
        public string NewCardCode { get; set; } = string.Empty;
    }
}
