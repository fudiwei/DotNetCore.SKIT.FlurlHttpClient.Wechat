namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/get 接口的请求。</para>
    /// </summary>
    public class CardGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;
    }
}
