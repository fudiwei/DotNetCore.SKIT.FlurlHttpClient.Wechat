using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/get_living_share_info 接口的响应。</para>
    /// </summary>
    public class CgibinLivingGetLivingShareInfoResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("livingid")]
        [System.Text.Json.Serialization.JsonPropertyName("livingid")]
        public string LivingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置观众的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("viewer_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("viewer_userid")]
        public string? ViewerUserId { get; set; }

        /// <summary>
        /// 获取或设置观众的外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("viewer_external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("viewer_external_userid")]
        public string? ViewerExternalUserId { get; set; }

        /// <summary>
        /// 获取或设置邀请人的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invitor_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("invitor_userid")]
        public string? InvitorUserId { get; set; }

        /// <summary>
        /// 获取或设置邀请人的外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invitor_external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("invitor_external_userid")]
        public string? InvitorExternalUserId { get; set; }
    }
}
