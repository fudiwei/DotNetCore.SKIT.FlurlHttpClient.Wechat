namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/get_form_answer 接口的响应。</para>
    /// </summary>
    public class CgibinWedocGetFormAnswerResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AnswerList
            {
                /// <summary>
                /// 获取或设置答案列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer_list")]
                [System.Text.Json.Serialization.JsonPropertyName("answer_list")]
                public AnswerItem[] Items { get; set; } = default!;
            }

            public class AnswerItem
            {
                public static class Types
                {
                    public class ReplyList
                    {
                        /// <summary>
                        /// 获取或设置回答列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("items")]
                        [System.Text.Json.Serialization.JsonPropertyName("items")]
                        public ReplyItem[] Items { get; set; } = default!;
                    }

                    public class ReplyItem
                    {
                        public static class Types
                        {
                            public class ExtendedFileReply
                            {
                                /// <summary>
                                /// 获取或设置文件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fileid")]
                                [System.Text.Json.Serialization.JsonPropertyName("fileid")]
                                public string FileId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置文件名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }

                            public class ExtendedOptionReply
                            {
                                /// <summary>
                                /// 获取或设置额外回答选项键。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("option_reply")]
                                [System.Text.Json.Serialization.JsonPropertyName("option_reply")]
                                public int OptionKey { get; set; }

                                /// <summary>
                                /// 获取或设置文本。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("extend_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("extend_text")]
                                public string Text { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置问题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_id")]
                        public int QuestionId { get; set; }

                        /// <summary>
                        /// 获取或设置回答文本内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text_reply")]
                        [System.Text.Json.Serialization.JsonPropertyName("text_reply")]
                        public string? ReplyText { get; set; }

                        /// <summary>
                        /// 获取或设置回答选项键列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_reply")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_reply")]
                        public int[]? ReplyOptionKeyList { get; set; }

                        /// <summary>
                        /// 获取或设置回答文件列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("file_extend_reply")]
                        [System.Text.Json.Serialization.JsonPropertyName("file_extend_reply")]
                        public Types.ExtendedFileReply[]? ReplyExtendedFileReply { get; set; }

                        /// <summary>
                        /// 获取或设置回答额外选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_extend_reply")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_extend_reply")]
                        public Types.ExtendedOptionReply[]? ReplyExtendedOptionList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置答案 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer_id")]
                [System.Text.Json.Serialization.JsonPropertyName("answer_id")]
                public long AnswerId { get; set; }

                /// <summary>
                /// 获取或设置用户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string UserName { get; set; } = default!;

                /// <summary>
                /// 获取或设置外部联系人临时 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_external_userid")]
                public string? TempExternalUserId { get; set; }

                /// <summary>
                /// 获取或设置回答列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply")]
                [System.Text.Json.Serialization.JsonPropertyName("reply")]
                public Types.ReplyList ReplyList { get; set; } = default!;

                /// <summary>
                /// 获取或设置答案状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer_status")]
                [System.Text.Json.Serialization.JsonPropertyName("answer_status")]
                public int AnswerStatus { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ctime")]
                [System.Text.Json.Serialization.JsonPropertyName("ctime")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mtime")]
                [System.Text.Json.Serialization.JsonPropertyName("mtime")]
                public long ModifyTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置收集表答案列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answer")]
        [System.Text.Json.Serialization.JsonPropertyName("answer")]
        public Types.AnswerList AnswerList { get; set; } = default!;
    }
}
