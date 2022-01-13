namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/resident/get_order_list 接口的响应。</para>
    /// </summary>
    public class CgibinReportResidentGetOrderListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class WorkOrder : CgibinReportPatrolGetOrderListResponse.Types.WorkOrder
            {
                /// <summary>
                /// 获取或设置上报人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reporter_name")]
                [System.Text.Json.Serialization.JsonPropertyName("reporter_name")]
                public string ReporterName { get; set; } = default!;

                /// <summary>
                /// 获取或设置上报人手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reporter_mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("reporter_mobile")]
                public string ReporterMobileNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置上报人 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? ReporterUnionId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置工单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.WorkOrder[] WorkOrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
