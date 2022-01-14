namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/limiteddiscount/get_list 接口的请求。</para>
    /// </summary>
    public class ProductLimitedDiscountGetListRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置指定抢购任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }
    }
}
