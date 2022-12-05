namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/report_access_data 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceReportAccessDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AccessData : CgibinOpenHardwareDeviceReportAccessDataRequest.Types.AccessData
            {
            }
        }

        /// <summary>
        /// 获取或设置上报失败的门禁通行据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public Types.AccessData[]? FailedAccessDataList { get; set; }
    }
}
