using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /combine-transactions/out-trade-no/{combine_out_trade_no} 接口的请求。</para>
    /// </summary>
    public class GetCombineTransactionByCombineOutTradeNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置合单商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CombineOutTradeNumber { get; set; } = string.Empty;
    }
}
