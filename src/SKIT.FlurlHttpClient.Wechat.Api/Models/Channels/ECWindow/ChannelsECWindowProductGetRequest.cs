namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/window/product/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECWindowProductGetRequest : WechatApiRequest, IInferable<ChannelsECWindowProductGetRequest, ChannelsECWindowProductGetResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品来源小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否查询带货商品。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_cps_product")]
        [System.Text.Json.Serialization.JsonPropertyName("need_cps_product")]
        public bool? RequireCPSProduct { get; set; } 
    }
}
