using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/target/apply_status 接口的请求。</para>
    /// </summary>
    public class UnionPromoterTargetApplyStatusRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置定向计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PlanId { get; set; } = string.Empty;
    }
}
