namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/resident/get_order_list 接口的响应。</para>
    /// </summary>
    public class CgibinReportResidentGetOrderListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public abstract class __zz__WorkOrder : CgibinReportPatrolGetOrderListResponse.Types.__zz__WorkOrder
            {
                /// <summary>
                /// 获取或设置上报人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reporter_name")]
                [System.Text.Json.Serialization.JsonPropertyName("reporter_name")]
                public string? ReporterName { get; set; }

                /// <summary>
                /// 获取或设置上报人手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reporter_mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("reporter_mobile")]
                public string? ReporterMobileNumber { get; set; }

                /// <summary>
                /// 获取或设置上报人 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? ReporterUnionId { get; set; }
            }

            public class WorkOrder : __zz__WorkOrder
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
        /// 获取或设置工单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public List<Types.WorkOrder>? WorkOrderList { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
