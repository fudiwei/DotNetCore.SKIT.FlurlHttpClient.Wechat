namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/accounts/mse-pay/{platform_id}/bill 接口的请求。</para>
    /// </summary>
    public class GetMSEPayAccountBillRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置查询日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_date")]
        [System.Text.Json.Serialization.JsonPropertyName("query_date")]
        public string DateString { get; set; } = string.Empty;
    }
}
