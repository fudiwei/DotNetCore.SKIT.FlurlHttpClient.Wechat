namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/limiteddiscount/update_status 接口的请求。</para>
    /// </summary>
    public class ProductLimitedDiscountUpdateStatusRequest : WechatApiRequest, IInferable<ProductLimitedDiscountUpdateStatusRequest, ProductLimitedDiscountUpdateStatusResponse>
    {
        /// <summary>
        /// 获取或设置抢购任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int TaskId { get; set; }

        /// <summary>
        /// 获取或设置抢购任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
