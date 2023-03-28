namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/single_waybill/fee 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliverySingleWaybillFeeRequest : WechatApiRequest, IInferable<CgibinExpressDeliverySingleWaybillFeeRequest, CgibinExpressDeliverySingleWaybillFeeResponse>
    {
        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置支付方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_pay")]
        [System.Text.Json.Serialization.JsonPropertyName("need_pay")]
        public int PayType { get; set; }

        /// <summary>
        /// 获取或设置总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee")]
        [System.Text.Json.Serialization.JsonPropertyName("fee")]
        public int Fee { get; set; }

        /// <summary>
        /// 获取或设置原价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("original_fee")]
        public int OriginalFee { get; set; }

        /// <summary>
        /// 获取或设置基础运费（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("base_fee")]
        public int BaseFee { get; set; }

        /// <summary>
        /// 获取或设置保价费用（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insured_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("insured_fee")]
        public int InsuredFee { get; set; }

        /// <summary>
        /// 获取或设置其他费用（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("other_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("other_fee")]
        public int OtherFee { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置商品名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_goods_name")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_goods_name")]
        public string? PayGoodsName { get; set; }
    }
}
