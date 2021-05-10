using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Resources
{
    /// <summary>
    /// <para>表示 COMPLAINT.CREATE 通知的数据。</para>
    /// <para>表示 COMPLAINT.STATE_CHANGE 通知的数据。</para>
    /// </summary>
    public class ComplaintResource : WechatTenpayCallback.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置投诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_id")]
        public string ComplaintId { get; set; } = default!;

        /// <summary>
        /// 获取或设置动作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_type")]
        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
        public string ActionType { get; set; } = default!;
    }
}
