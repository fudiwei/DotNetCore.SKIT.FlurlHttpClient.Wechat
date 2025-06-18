namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/report_checkin_data 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceReportCheckinDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CheckinData : CgibinOpenHardwareDeviceReportCheckinDataRequest.Types.CheckinData
            {
            }
        }

        /// <summary>
        /// 获取或设置上报失败的打卡数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public Types.CheckinData[]? FailedCheckinDataList { get; set; }
    }
}
