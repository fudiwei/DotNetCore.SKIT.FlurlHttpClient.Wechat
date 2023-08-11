namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /taxi-invoice/drivers/{driver_license} 接口的请求。</para>
    /// </summary>
    public class GetTaxiInvoiceDriverRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置司机资格证号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DriverLicenseNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RegionId { get; set; }
    }
}
