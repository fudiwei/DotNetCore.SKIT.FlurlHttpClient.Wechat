namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/service/product/getcardinfo 接口的请求。</para>
    /// </summary>
    public class ChannelsECServiceProductGetCardInfoRequest : WechatApiRequest, IInferable<ChannelsECServiceProductGetCardInfoRequest, ChannelsECServiceProductGetCardInfoResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置文章类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_type")]
        [System.Text.Json.Serialization.JsonPropertyName("article_type")]
        public string? ArticleType { get; set; }

        /// <summary>
        /// 获取或设置卡片类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
        public int CardType { get; set; }
    }
}
