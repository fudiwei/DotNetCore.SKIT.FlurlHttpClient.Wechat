using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/coupons/associate 接口的请求。</para>
    /// </summary>
    public class AssociateMarketingBusifavorCouponRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string CouponCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置关联的商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;
    }
}
