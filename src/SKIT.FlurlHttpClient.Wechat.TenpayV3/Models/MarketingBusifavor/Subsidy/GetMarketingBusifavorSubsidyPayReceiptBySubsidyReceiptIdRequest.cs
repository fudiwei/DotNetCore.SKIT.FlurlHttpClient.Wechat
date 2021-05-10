using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/busifavor/subsidy/pay-receipts/{subsidy_receipt_id} 接口的请求。</para>
    /// </summary>
    public class GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置补差付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubsidyReceiptId { get; set; } = string.Empty;
    }
}
