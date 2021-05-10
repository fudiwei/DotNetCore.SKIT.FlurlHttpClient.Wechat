using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/fund/withdraw/out-request-no/{out_request_no} 接口的请求。</para>
    /// </summary>
    public class GetMerchantFundWithdrawByOutRequestNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutRequestNumber { get; set; } = string.Empty;
    }
}
