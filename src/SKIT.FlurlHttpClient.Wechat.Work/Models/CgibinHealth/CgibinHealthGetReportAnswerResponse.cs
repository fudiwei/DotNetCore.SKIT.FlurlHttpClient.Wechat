using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/health/get_report_answer 接口的响应。</para>
    /// </summary>
    public class CgibinHealthGetReportAnswerResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Answer
            {
                public static class Types
                {
                    public class ReportValue
                    {
                        /// <summary>
                        /// 获取或设置问题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_id")]
                        public int QuestionId { get; set; }

                        /// <summary>
                        /// 获取或设置单选题答案编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("single_choice")]
                        [System.Text.Json.Serialization.JsonPropertyName("single_choice")]
                        public int? SignleChoice { get; set; }

                        /// <summary>
                        /// 获取或设置单选题答案编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("multi_choice")]
                        [System.Text.Json.Serialization.JsonPropertyName("multi_choice")]
                        public int[]? MultipleChoice { get; set; }

                        /// <summary>
                        /// 获取或设置填空题答案内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string? Text { get; set; }

                        /// <summary>
                        /// 获取或设置文件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fileid")]
                        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
                        public string[]? FileIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置 ID 类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_type")]
                [System.Text.Json.Serialization.JsonPropertyName("id_type")]
                public int IdType { get; set; }

                /// <summary>
                /// 获取或设置填写人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置填写人学生账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("student_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
                public string? StudentUserId { get; set; }

                /// <summary>
                /// 获取或设置填写人家长账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_userid")]
                public string? ParentUserId { get; set; }

                /// <summary>
                /// 获取或设置填写答案列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_values")]
                [System.Text.Json.Serialization.JsonPropertyName("report_values")]
                public Types.ReportValue[] ReportValueList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置答案列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answers")]
        [System.Text.Json.Serialization.JsonPropertyName("answers")]
        public Types.Answer[] AnswerList { get; set; } = default!;
    }
}
