using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/mark_tag 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactMarkTagRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string ExternalUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置要添加的企业标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("add_tag")]
        public IList<string>? AddTagIdList { get; set; }

        /// <summary>
        /// 获取或设置要移除的企业标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remove_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("remove_tag")]
        public IList<string>? RemoveTagIdList { get; set; }
    }
}
