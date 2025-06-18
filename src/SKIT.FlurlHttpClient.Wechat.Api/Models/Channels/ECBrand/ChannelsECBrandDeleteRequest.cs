namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/delete 接口的请求。</para>
    /// </summary>
    public class ChannelsECBrandDeleteRequest : WechatApiRequest, IInferable<ChannelsECBrandDeleteRequest, ChannelsECBrandDeleteResponse>
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public long BrandId { get; set; }
    }
}
