namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/productdetail/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierProductDetailGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierProductDetailGetRequest, ChannelsECLeagueHeadSupplierProductDetailGetResponse>
    {
        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置计划类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_type")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        public int? PlanType { get; set; }
    }
}
