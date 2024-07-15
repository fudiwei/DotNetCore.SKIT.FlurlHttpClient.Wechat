namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/get_bill_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECVoucherGetBillListRequest : WechatApiRequest, IInferable<ChannelsECVoucherGetBillListRequest, ChannelsECVoucherGetBillListResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_date")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_date")]
        public string BillDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_ctx")]
        [System.Text.Json.Serialization.JsonPropertyName("page_ctx")]
        public string? Cursor { get; set; }
    }
}
