using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/batch/invite 接口的响应。</para>
    /// </summary>
    public class CgibinBatchInviteResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置非法成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invaliduser")]
        [System.Text.Json.Serialization.JsonPropertyName("invaliduser")]
        public string[]? InvalidUserIdList { get; set; }

        /// <summary>
        /// 获取或设置非法部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidparty")]
        [System.Text.Json.Serialization.JsonPropertyName("invalidparty")]
        public int[]? InvalidDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置非法标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidtag")]
        [System.Text.Json.Serialization.JsonPropertyName("invalidtag")]
        public int[]? InvalidTagIdList { get; set; }
    }
}
