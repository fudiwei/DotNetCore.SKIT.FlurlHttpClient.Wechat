using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/profitsharing/returnorders 接口的请求。</para>
    /// </summary>
    public class GetEcommerceProfitSharingReturnOrderByOrderIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户回退单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutReturnNumber { get; set; } = string.Empty;
    }
}
