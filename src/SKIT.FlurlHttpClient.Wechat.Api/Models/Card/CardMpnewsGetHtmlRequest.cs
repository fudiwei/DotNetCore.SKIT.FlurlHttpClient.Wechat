namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/mpnews/gethtml 接口的请求。</para>
    /// </summary>
    public class CardMpnewsGetHtmlRequest : WechatApiRequest, IMapResponse<CardMpnewsGetHtmlRequest, CardMpnewsGetHtmlResponse>
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;
    }
}
