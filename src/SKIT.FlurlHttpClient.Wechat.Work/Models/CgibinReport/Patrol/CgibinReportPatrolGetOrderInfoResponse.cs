namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/patrol/get_order_info 接口的响应。</para>
    /// </summary>
    public class CgibinReportPatrolGetOrderInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class WorkOrder : CgibinReportPatrolGetOrderListResponse.Types.__zz__WorkOrder
            {
                public static class Types
                {
                    public class Location : CgibinReportPatrolGetOrderListResponse.Types.WorkOrder.Types.Location
                    {
                    }

                    public class ProcessRecord : CgibinReportPatrolGetOrderListResponse.Types.WorkOrder.Types.ProcessRecord
                    {
                    }
                }

                /// <summary>
                /// 获取或设置位置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Types.Location? Location { get; set; }

                /// <summary>
                /// 获取或设置处理记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("process_list")]
                [System.Text.Json.Serialization.JsonPropertyName("process_list")]
                public List<Types.ProcessRecord>? ProcessRecordList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置工单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public Types.WorkOrder? WorkOrder { get; set; }
    }
}
