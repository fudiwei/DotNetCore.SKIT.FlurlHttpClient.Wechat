using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/batch/invite 接口的请求。</para>
    /// </summary>
    public class CgibinBatchInviteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user")]
        [System.Text.Json.Serialization.JsonPropertyName("user")]
        public IList<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("party")]
        [System.Text.Json.Serialization.JsonPropertyName("party")]
        public IList<int>? DepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public IList<int>? TagIdList { get; set; }
    }
}
