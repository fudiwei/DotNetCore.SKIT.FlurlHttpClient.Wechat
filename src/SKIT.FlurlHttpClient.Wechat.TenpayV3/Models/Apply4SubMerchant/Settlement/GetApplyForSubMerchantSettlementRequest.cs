using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /apply4sub/sub_merchants/{sub_mchid}/settlement 接口的请求。</para>
    /// </summary>
    public class GetApplyForSubMerchantSettlementRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
