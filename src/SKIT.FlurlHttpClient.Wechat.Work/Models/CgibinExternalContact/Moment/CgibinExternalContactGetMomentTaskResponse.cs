using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_moment_task 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetMomentTaskResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置发布状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_status")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_status")]
                public int PublishStatus { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置朋友圈发布任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_list")]
        [System.Text.Json.Serialization.JsonPropertyName("task_list")]
        public Types.Task[] TaskList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
