namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_to_headsupplier 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponToHeadSupplierRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetCouponToHeadSupplierRequest, ChannelsECPromoterGetCouponToHeadSupplierResponse>
    {
        /// <summary>
        /// 获取或设置接收的机构 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_head_supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("to_head_supplier_appid")]
        public string ToHeadSupplierAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_context")]
        [System.Text.Json.Serialization.JsonPropertyName("page_context")]
        public string? Cursor { get; set; }
    }
}
