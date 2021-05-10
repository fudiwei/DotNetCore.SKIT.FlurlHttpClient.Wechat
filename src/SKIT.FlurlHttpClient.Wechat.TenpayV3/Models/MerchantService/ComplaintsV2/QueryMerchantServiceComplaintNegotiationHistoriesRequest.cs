using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant-service/complaints-v2/{complaint_id}/negotiation-historys 接口的请求。</para>
    /// </summary>
    public class QueryMerchantServiceComplaintNegotiationHistoriesRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置投诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComplaintId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Offset { get; set; }
    }
}
