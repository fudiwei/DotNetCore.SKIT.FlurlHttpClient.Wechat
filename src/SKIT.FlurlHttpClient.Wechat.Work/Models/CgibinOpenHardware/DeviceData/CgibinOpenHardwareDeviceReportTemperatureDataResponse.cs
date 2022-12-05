namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/report_temperature_data 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceReportTemperatureDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class TemperatureData : CgibinOpenHardwareDeviceReportTemperatureDataRequest.Types.TemperatureData
            {
            }
        }

        /// <summary>
        /// 获取或设置上报失败的测温据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public Types.TemperatureData[]? FailedTemperatureDataList { get; set; }
    }
}
