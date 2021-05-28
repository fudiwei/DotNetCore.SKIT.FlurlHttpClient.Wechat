using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /publisher/stat?action=publisher_adpos_general 接口的请求。</para>
    /// </summary>
    public class PublisherStatAdposGeneralRequest : PublisherStatSettlementRequest
    {
        /// <summary>
        /// 获取或设置广告位类型名称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AdSlotName { get; set; }
    }
}
