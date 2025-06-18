﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/acceptapply 接口的请求。</para>
    /// </summary>
    public class ProductOrderAcceptApplyRequest : WechatApiRequest, IInferable<ProductOrderAcceptApplyRequest, ProductOrderAcceptApplyResponse>
    {
        /// <summary>
        /// 获取或设置售后单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long AftersaleOrderId { get; set; }
    }
}
