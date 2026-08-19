namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/productbrandrecommend 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductBrandRecommendResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 获取或设置品牌商标中文名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_name_chinese")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_name_chinese")]
        public string BrandChineseName { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌商标英文名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_name_english")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_name_english")]
        public string BrandEnglishName { get; set; } = default!;
    }
}
