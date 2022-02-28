namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/addtips 接口的请求。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderAddTipsRequest : CgibinExpressLocalBusinessRequestBase, IInferable<CgibinExpressLocalBusinessOrderAddTipsRequest, CgibinExpressLocalBusinessOrderAddTipsResponse>
    {
        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        public string ShopNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下单用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小费金额（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tips")]
        [System.Text.Json.Serialization.JsonPropertyName("tips")]
        public double TipValue { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string Remark { get; set; } = string.Empty;
    }
}
