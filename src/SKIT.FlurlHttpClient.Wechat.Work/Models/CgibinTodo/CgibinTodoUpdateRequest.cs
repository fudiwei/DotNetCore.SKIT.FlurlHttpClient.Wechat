using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/todo/update 接口的请求。</para>
    /// </summary>
    public class CgibinTodoUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Attendee
            {
                /// <summary>
                /// 获取或设置参与人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置参与人待办状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置待办 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("todo_id")]
        [System.Text.Json.Serialization.JsonPropertyName("todo_id")]
        public string TodoId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置待办状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置参与人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("attendees")]
        public IList<Types.Attendee>? AttendeeList { get; set; }
    }
}
