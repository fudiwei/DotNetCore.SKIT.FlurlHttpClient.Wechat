using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/msgaudit/check_single_agree 接口的响应。</para>
    /// </summary>
    public class CgibinMessageAuditCheckSingleAgreeResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置外部联系人的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exteranalopenid")]
                [System.Text.Json.Serialization.JsonPropertyName("exteranalopenid")]
                public string ExternalOpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置同意状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agree_status")]
                [System.Text.Json.Serialization.JsonPropertyName("agree_status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态改变的时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status_change_time")]
                [System.Text.Json.Serialization.JsonPropertyName("status_change_time")]
                public long StatusChangedTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会话同意情况列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agreeinfo")]
        [System.Text.Json.Serialization.JsonPropertyName("agreeinfo")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
