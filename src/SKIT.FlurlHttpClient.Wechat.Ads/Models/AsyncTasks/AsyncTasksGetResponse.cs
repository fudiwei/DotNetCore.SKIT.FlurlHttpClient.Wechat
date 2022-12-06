namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /async_tasks/get 接口的响应。</para>
    /// </summary>
    public class AsyncTasksGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Task
                    {
                        public static class Types
                        {
                            public class Result
                            {
                                public static class Types
                                {
                                    public class Data
                                    {
                                        public static class Types
                                        {
                                            public class File
                                            {
                                                /// <summary>
                                                /// 获取或设置文件 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("file_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("file_id")]
                                                public int FileId { get; set; }

                                                /// <summary>
                                                /// 获取或设置文件 MD5 哈希值。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("md5")]
                                                [System.Text.Json.Serialization.JsonPropertyName("md5")]
                                                public string FileHash { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置文件列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("file_info_list")]
                                        [System.Text.Json.Serialization.JsonPropertyName("file_info_list")]
                                        public Types.File[] FileList { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置错误码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("code")]
                                [System.Text.Json.Serialization.JsonPropertyName("code")]
                                public int ErrorCode { get; set; }

                                /// <summary>
                                /// 获取或设置错误信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("message")]
                                [System.Text.Json.Serialization.JsonPropertyName("message")]
                                public string? ErrorMessage { get; set; }

                                /// <summary>
                                /// 获取或设置结果数据。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("data")]
                                [System.Text.Json.Serialization.JsonPropertyName("data")]
                                public Types.Data? Data { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        public int TaskId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置任务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_name")]
                        public string TaskName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置任务类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_type")]
                        public string TaskType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置任务状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置任务结果信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result")]
                        [System.Text.Json.Serialization.JsonPropertyName("result")]
                        public Types.Result? Result { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("created_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("created_time")]
                        public long CreateTimestamp { get; set; }
                    }

                    public class Pagination : Abstractions.CommonPagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置任务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Task[] TaskList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
