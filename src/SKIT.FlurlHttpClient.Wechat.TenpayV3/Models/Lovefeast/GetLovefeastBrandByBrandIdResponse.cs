namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /lovefeast/brands/{brand_id} 接口的响应。</para>
    /// </summary>
    public class GetLovefeastBrandByBrandIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置捐赠数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("donate_count")]
        [System.Text.Json.Serialization.JsonPropertyName("donate_count")]
        public int DonateCount { get; set; }

        /// <summary>
        /// 获取或设置供餐数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consume_count")]
        [System.Text.Json.Serialization.JsonPropertyName("consume_count")]
        public int? ConsumeCount { get; set; }
    }
}
