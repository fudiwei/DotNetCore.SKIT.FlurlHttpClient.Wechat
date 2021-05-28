using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/audit 接口的响应。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsAuditResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditId")]
        [System.Text.Json.Serialization.JsonPropertyName("auditId")]
        public long AuditId { get; set; }
    }
}
