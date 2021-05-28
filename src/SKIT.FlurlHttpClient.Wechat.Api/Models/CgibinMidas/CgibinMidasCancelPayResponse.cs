using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/cancelpay 接口的响应。</para>
    /// </summary>
    public class CgibinMidasCancelPayResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置扣除游戏币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = default!;
    }
}
