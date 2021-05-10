using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /refund/domestic/refunds/{out_refund_no} 接口的请求。</para>
    /// </summary>
    public class GetRefundDomesticRefundByOutRefundNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子单子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutRefundNumber { get; set; } = string.Empty;
    }
}
