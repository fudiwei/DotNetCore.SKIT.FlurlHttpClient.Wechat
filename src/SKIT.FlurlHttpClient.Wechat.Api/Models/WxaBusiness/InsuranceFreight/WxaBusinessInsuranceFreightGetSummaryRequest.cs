namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/getsummary 接口的请求。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightGetSummaryRequest : WechatApiRequest, IInferable<WxaBusinessInsuranceFreightGetSummaryRequest, WxaBusinessInsuranceFreightGetSummaryResponse>
    {
        /// <summary>
        /// 获取或设置查询开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }
    }
}
