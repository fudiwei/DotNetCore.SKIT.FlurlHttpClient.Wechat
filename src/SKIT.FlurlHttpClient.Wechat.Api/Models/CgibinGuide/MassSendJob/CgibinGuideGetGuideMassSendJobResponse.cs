namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidemassendjob 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideMassSendJobResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Job
            {
                public static class Types
                {
                    public class Material
                    {
                        /// <summary>
                        /// 获取或设置素材类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置图片素材或小程序卡片素材封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_url")]
                        public string? PictureUrl { get; set; }

                        /// <summary>
                        /// 获取或设置文字素材内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("word")]
                        [System.Text.Json.Serialization.JsonPropertyName("word")]
                        public string? Word { get; set; }

                        /// <summary>
                        /// 获取或设置小程序卡片素材 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? AppId { get; set; }

                        /// <summary>
                        /// 获取或设置小程序卡片素材名字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置小程序卡片素材路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string? Path { get; set; }
                    }

                    public class Buyer
                    {
                        /// <summary>
                        /// 获取或设置客户 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("openid")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置消息发送状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_status")]
                        public int SendStatus { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public long TaskId { get; set; }

                /// <summary>
                /// 获取或设置任务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_name")]
                [System.Text.Json.Serialization.JsonPropertyName("task_name")]
                public string TaskName { get; set; } = default!;

                /// <summary>
                /// 获取或设置任务备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("task_remark")]
                public string? TaskRemark { get; set; }

                /// <summary>
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_status")]
                [System.Text.Json.Serialization.JsonPropertyName("task_status")]
                public int TaskStatus { get; set; }

                /// <summary>
                /// 获取或设置素材列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material")]
                [System.Text.Json.Serialization.JsonPropertyName("material")]
                public Types.Material[] MaterialList { get; set; } = default!;

                /// <summary>
                /// 获取或设置客户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_info")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_info")]
                public Types.Buyer[] BuyerList { get; set; } = default!;

                /// <summary>
                /// 获取或设置任务下发时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("push_time")]
                [System.Text.Json.Serialization.JsonPropertyName("push_time")]
                public long PushTimestamp { get; set; }

                /// <summary>
                /// 获取或设置任务完成时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
                public long FinishTimestamp { get; set; }

                /// <summary>
                /// 获取或设置任务创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置任务最后修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置群发任务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job")]
        [System.Text.Json.Serialization.JsonPropertyName("job")]
        public Types.Job Job { get; set; } = default!;
    }
}
