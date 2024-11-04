namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/cooperation/product/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECCooperationProductGetRequest : WechatApiRequest, IInferable<ChannelsECCooperationProductGetRequest, ChannelsECCooperationProductGetResponse>
    {
        /// <summary>
        /// 获取或设置店铺 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string ShopAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
