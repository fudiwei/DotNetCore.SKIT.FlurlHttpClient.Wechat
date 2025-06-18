﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getpressuretestreport 接口的请求。</para>
    /// </summary>
    public class TCBGetPressureTestReportRequest : WechatApiRequest, IInferable<TCBGetPressureTestReportRequest, TCBGetPressureTestReportResponse>
    {
        /// <summary>
        /// 获取或设置压测 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pressure_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pressure_id")]
        public int PressureId { get; set; }
    }
}
