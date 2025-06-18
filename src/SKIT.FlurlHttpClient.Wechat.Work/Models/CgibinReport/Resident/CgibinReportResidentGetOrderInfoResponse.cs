namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/resident/get_order_info 接口的响应。</para>
    /// </summary>
    public class CgibinReportResidentGetOrderInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class WorkOrder : CgibinReportResidentGetOrderListResponse.Types.WorkOrder
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
