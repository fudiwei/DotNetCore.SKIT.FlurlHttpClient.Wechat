using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_user_behavior_data 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGetUserBehaviorDataRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置数据起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置数据结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public IList<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置指定部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partyid")]
        [System.Text.Json.Serialization.JsonPropertyName("partyid")]
        public IList<int>? DepartmentIdList { get; set; }
    }
}
