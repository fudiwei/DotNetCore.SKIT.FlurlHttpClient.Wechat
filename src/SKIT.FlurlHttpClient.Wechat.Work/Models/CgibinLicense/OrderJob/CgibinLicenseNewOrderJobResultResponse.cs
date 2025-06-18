namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/new_order_job_result 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseNewOrderJobResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class FailedCorp : CgibinLicenseCreateNewOrderJobResponse.Types.FailedCorp
            {
            }
        }

        /// <summary>
        /// 获取或设置订单创建结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置失败企业列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public Types.FailedCorp[]? FailedCorpList { get; set; }
    }
}
