using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tag/addtagusers 接口的请求。</para>
    /// </summary>
    public class CgibinTagAddTagUsersRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid")]
        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
        public int TagId { get; set; }

        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userlist")]
        [System.Text.Json.Serialization.JsonPropertyName("userlist")]
        public IList<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partylist")]
        [System.Text.Json.Serialization.JsonPropertyName("partylist")]
        public IList<int>? DepartmentIdList { get; set; }
    }
}
