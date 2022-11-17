namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductGetRequest : WechatApiRequest, IInferable<ChannelsECProductGetRequest, ChannelsECProductGetResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置数据类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_type")]
        [System.Text.Json.Serialization.JsonPropertyName("data_type")]
        public int? DataType { get; set; }
    }
}
