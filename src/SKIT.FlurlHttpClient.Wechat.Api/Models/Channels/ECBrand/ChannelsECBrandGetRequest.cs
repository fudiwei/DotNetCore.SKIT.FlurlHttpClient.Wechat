namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECBrandGetRequest : WechatApiRequest, IInferable<ChannelsECBrandGetRequest, ChannelsECBrandGetResponse>
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public long BrandId { get; set; }
    }
}
