namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/patrol/get_order_list 接口的响应。</para>
    /// </summary>
    public class CgibinReportPatrolGetOrderListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class WorkOrder
            {
                public static class Types
                {
                    public class Location
                    {
                        /// <summary>
                        /// 获取或设置位置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string Address { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置经度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("longitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                        public double Longitude { get; set; }

                        /// <summary>
                        /// 获取或设置纬度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                        public double Latitude { get; set; }
                    }

                    public class ProcessRecord
                    {
                        /// <summary>
                        /// 获取或设置流程类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("process_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("process_type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置流程描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("process_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("process_desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置流程状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_urls")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_urls")]
                        public string[]? ImageUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置视频 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_media_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_media_ids")]
                        public string[]? VideoMediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置办结人用户 UserId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("solve_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("solve_userid")]
                        public string? SolverUserId { get; set; }

                        /// <summary>
                        /// 获取或设置办结时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("solved_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("solved_time")]
                        public long? SolvedTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置工单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string WorkOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置事件描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置紧急类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("urge_type")]
                [System.Text.Json.Serialization.JsonPropertyName("urge_type")]
                public int UrgencyType { get; set; }

                /// <summary>
                /// 获取或设置分类名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("case_name")]
                [System.Text.Json.Serialization.JsonPropertyName("case_name")]
                public string CategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置网格 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grid_id")]
                [System.Text.Json.Serialization.JsonPropertyName("grid_id")]
                public string GridId { get; set; } = default!;

                /// <summary>
                /// 获取或设置网格名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grid_name")]
                [System.Text.Json.Serialization.JsonPropertyName("grid_name")]
                public string GridName { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_urls")]
                [System.Text.Json.Serialization.JsonPropertyName("image_urls")]
                public string[]? ImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置视频 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_media_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("video_media_ids")]
                public string[]? VideoMediaIdList { get; set; }

                /// <summary>
                /// 获取或设置位置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Types.Location? Location { get; set; }

                /// <summary>
                /// 获取或设置处理人用户 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("processor_userids")]
                [System.Text.Json.Serialization.JsonPropertyName("processor_userids")]
                public string[]? ProcessorUserIdList { get; set; }

                /// <summary>
                /// 获取或设置处理记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("process_list")]
                [System.Text.Json.Serialization.JsonPropertyName("process_list")]
                public Types.ProcessRecord[] ProcessRecordList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置工单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.WorkOrder[] WorkOrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
