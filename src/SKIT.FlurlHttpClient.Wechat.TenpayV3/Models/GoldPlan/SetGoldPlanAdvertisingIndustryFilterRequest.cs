namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /goldplan/merchants/set-advertising-industry-filter 接口的请求。</para>
    /// </summary>
    public class SetGoldPlanAdvertisingIndustryFilterRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置同业过滤标签值列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertising_industry_filters")]
        [System.Text.Json.Serialization.JsonPropertyName("advertising_industry_filters")]
        public List<string>? AdvertisingIndustryFilterList { get; set; }
    }
}
