using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/service/getuserinfo3rd 接口的响应。</para>
    /// </summary>
    public class CgibinServiceUserInfo3rdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置用户所属企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("CorpId")]
        public string? CorpId { get; set; }

        /// <summary>
        /// 获取或设置用户所在企业内的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UserId")]
        [System.Text.Json.Serialization.JsonPropertyName("UserId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenId")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenId")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置设备号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DeviceId")]
        [System.Text.Json.Serialization.JsonPropertyName("DeviceId")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// 获取或设置第三方成员唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
        public string? OpenUserId { get; set; }

        /// <summary>
        /// 获取或设置成员票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("user_ticket")]
        public string? UserTicket { get; set; }

        /// <summary>
        /// 获取或设置成员票据有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }
    }
}
