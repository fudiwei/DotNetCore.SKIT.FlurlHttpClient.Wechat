using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/transfer_result 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactTransferResultRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置原成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("handover_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("handover_userid")]
        public string HandoverUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接替成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("takeover_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("takeover_userid")]
        public string TakeoverUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? NextCursor { get; set; }
    }
}
