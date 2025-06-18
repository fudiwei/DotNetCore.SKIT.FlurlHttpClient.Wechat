namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /pay-devices/printers/{device_id}/print-orders/{print_order_no} 接口的请求。</para>
    /// </summary>
    public class GetPayDevicePrinterPrintOrderByPrintOrderNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置小票机设备号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DeviceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置打印单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PrintOrderNumber { get; set; } = string.Empty;
    }
}
