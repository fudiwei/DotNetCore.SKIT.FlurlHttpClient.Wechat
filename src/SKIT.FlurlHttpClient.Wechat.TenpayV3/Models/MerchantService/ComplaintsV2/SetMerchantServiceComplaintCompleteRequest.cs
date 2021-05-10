using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-service/complaints-v2/{complaint_id}/complete 接口的请求。</para>
    /// </summary>
    public class SetMerchantServiceComplaintCompleteRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置投诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComplaintId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置被诉商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complainted_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("complainted_mchid")]
        public string? ComplaintedMerchantId { get; set; }
    }
}
