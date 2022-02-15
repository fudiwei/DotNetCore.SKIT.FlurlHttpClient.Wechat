using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/present 接口的请求。</para>
    /// </summary>
    public class CgibinMidasPresentRequest : CgibinMidasRequestBase, IMapResponse<CgibinMidasPresentRequest, CgibinMidasPresentResponse>
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置赠送游戏币的个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_counts")]
        [System.Text.Json.Serialization.JsonPropertyName("present_counts")]
        public int PresentAmount { get; set; }
    }
}
