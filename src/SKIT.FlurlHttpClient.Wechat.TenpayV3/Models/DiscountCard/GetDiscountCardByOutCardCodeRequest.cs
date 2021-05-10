using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /discount-card/cards/{out_card_code} 接口的请求。</para>
    /// </summary>
    public class GetDiscountCardByOutCardCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户领卡号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutCardCode { get; set; } = string.Empty;
    }
}
