namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/hr/update_staff_info 接口的响应。</para>
    /// </summary>
    public class CgibinHrUpdateStaffInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class UpdatedResult
            {
                /// <summary>
                /// 获取或设置字段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fieldid")]
                [System.Text.Json.Serialization.JsonPropertyName("fieldid")]
                public int FieldId { get; set; }

                /// <summary>
                /// 获取或设置需要获取的字段下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_idx")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_idx")]
                public int? SubIndex { get; set; }

                /// <summary>
                /// 获取或设置更新结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public int Result { get; set; }
            }

            public class InsertedResult
            {
                /// <summary>
                /// 获取或设置字段组类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_type")]
                [System.Text.Json.Serialization.JsonPropertyName("group_type")]
                public int GroupType { get; set; }

                /// <summary>
                /// 获取或设置字段下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("idx")]
                [System.Text.Json.Serialization.JsonPropertyName("idx")]
                public int? Index { get; set; }

                /// <summary>
                /// 获取或设置新增结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public int Result { get; set; }
            }

            public class RemovedResult
            {
                /// <summary>
                /// 获取或设置字段组类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_type")]
                [System.Text.Json.Serialization.JsonPropertyName("group_type")]
                public int GroupType { get; set; }

                /// <summary>
                /// 获取或设置字段组下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_idx")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_idx")]
                public int SubIndex { get; set; }

                /// <summary>
                /// 获取或设置删除结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public int Result { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置更新结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_results")]
        [System.Text.Json.Serialization.JsonPropertyName("update_results")]
        public Types.UpdatedResult[]? UpdatedResultList { get; set; }

        /// <summary>
        /// 获取或设置新增结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insert_result")]
        [System.Text.Json.Serialization.JsonPropertyName("insert_result")]
        public Types.InsertedResult[]? InsertedResultList { get; set; }

        /// <summary>
        /// 获取或设置删除结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remove_results")]
        [System.Text.Json.Serialization.JsonPropertyName("remove_results")]
        public Types.RemovedResult[]? RemovedResultList { get; set; }
    }
}
