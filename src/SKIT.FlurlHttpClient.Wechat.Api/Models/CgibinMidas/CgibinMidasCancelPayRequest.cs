using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/cancelpay 接口的请求。</para>
    /// </summary>
    public class CgibinMidasCancelPayRequest : CgibinMidasRequestBase
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置道具名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_item")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_item")]
        public string? PayItem { get; set; }
    }
}
