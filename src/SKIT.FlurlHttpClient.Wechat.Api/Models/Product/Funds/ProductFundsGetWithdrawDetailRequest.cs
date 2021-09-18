using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/funds/getwithdrawdetail 接口的请求。</para>
    /// </summary>
    public class ProductFundsGetWithdrawDetailRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置商户提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;
    }
}
