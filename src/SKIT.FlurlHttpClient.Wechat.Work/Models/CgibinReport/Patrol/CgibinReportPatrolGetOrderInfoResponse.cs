using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/patrol/get_order_info 接口的响应。</para>
    /// </summary>
    public class CgibinReportPatrolGetOrderInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class WorkOrder : CgibinReportPatrolGetOrderListResponse.Types.WorkOrder
            {
            }
        }

        /// <summary>
        /// 获取或设置工单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public Types.WorkOrder WorkOrder { get; set; } = default!;
    }
}
