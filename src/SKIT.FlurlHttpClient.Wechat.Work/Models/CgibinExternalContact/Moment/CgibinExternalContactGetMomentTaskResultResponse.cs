namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_moment_task_result 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetMomentTaskResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class Sender
                    {
                        /// <summary>
                        /// 获取或设置发表任务的执行者用户 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                        public string[]? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置发表任务的执行者部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("department_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("department_list")]
                        public long[]? DepartmentIdList { get; set; }
                    }

                    public class ExternalContact
                    {
                        /// <summary>
                        /// 获取或设置可见到该朋友圈的客户标签 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_list")]
                        public string[]? TagIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string ErrorMessage { get; set; } = default!;

                /// <summary>
                /// 获取或设置朋友圈 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("moment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("moment_id")]
                public string MomentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置不合法的执行者信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invalid_sender_list")]
                [System.Text.Json.Serialization.JsonPropertyName("invalid_sender_list")]
                public Types.Sender? InvalidSender { get; set; }

                /// <summary>
                /// 获取或设置不合法的客户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invalid_external_contact_list")]
                [System.Text.Json.Serialization.JsonPropertyName("invalid_external_contact_list")]
                public Types.ExternalContact? InvalidExternalContact { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置处理结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result Result { get; set; } = default!;
    }
}
