namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/weekly-discount/activities/{activity_id}/apply 接口的请求。</para>
    /// </summary>
    public class ApplyMarketingWeeklyDiscountActivityRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置报名商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applying_merchant_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalStringConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("applying_merchant_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
        public string ApplyingMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_id")]
        public int StoreId { get; set; }
    }
}
