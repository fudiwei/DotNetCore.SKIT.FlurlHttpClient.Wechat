using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/transfer_customer 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactTransferCustomerRequest : WechatWorkRequest
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
        /// 获取或设置外部联系人账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public IList<string> ExternalUserIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置转移成功后发给客户的消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_success_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_success_msg")]
        public string? TransferSuccessMessage { get; set; }
    }
}
