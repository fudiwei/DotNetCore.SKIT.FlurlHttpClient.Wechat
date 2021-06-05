using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/patrol/get_order_info 接口的请求。</para>
    /// </summary>
    public class CgibinReportPatrolGetOrderInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置工单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string WorkOrderId { get; set; } = string.Empty;
    }
}
