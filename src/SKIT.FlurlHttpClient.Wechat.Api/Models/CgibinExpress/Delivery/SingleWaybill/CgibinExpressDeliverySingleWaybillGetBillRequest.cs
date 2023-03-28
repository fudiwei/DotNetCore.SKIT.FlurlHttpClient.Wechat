namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/single_waybill/get_bill 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliverySingleWaybillGetBillRequest : WechatApiRequest, IInferable<CgibinExpressDeliverySingleWaybillGetBillRequest, CgibinExpressDeliverySingleWaybillGetBillResponse>
    {
        /// <summary>
        /// 获取或设置日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string DateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账单类型。
        /// <para>默认值：ALL</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string BillType { get; set; } = "ALL";
    }
}
