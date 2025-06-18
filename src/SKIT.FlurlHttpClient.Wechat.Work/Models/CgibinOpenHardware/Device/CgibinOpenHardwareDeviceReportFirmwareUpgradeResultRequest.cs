namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/report_firmware_upgrade_result 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceReportFirmwareUpgradeResultRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置操作 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oper_id")]
        [System.Text.Json.Serialization.JsonPropertyName("oper_id")]
        public string OperationId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置升级结果错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取或设置升级结果错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置当前固件版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cur_version")]
        [System.Text.Json.Serialization.JsonPropertyName("cur_version")]
        public string? CurrentVersion { get; set; }
    }
}
