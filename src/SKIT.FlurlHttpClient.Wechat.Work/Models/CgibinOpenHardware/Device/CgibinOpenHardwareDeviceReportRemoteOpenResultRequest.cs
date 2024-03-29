﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/report_remote_open_result 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceReportRemoteOpenResultRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置操作 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oper_id")]
        [System.Text.Json.Serialization.JsonPropertyName("oper_id")]
        public string OperationId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上报类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置识别结果错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取或设置识别结果错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public string? ErrorMessage { get; set; }
    }
}
