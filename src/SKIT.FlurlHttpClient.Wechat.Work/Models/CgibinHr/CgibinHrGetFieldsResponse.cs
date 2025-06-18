namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/hr/get_fields 接口的响应。</para>
    /// </summary>
    public class CgibinHrGetFieldsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class FieldGroup
            {
                public static class Types
                {
                    public class Field
                    {
                        /// <summary>
                        /// 获取或设置字段 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fieldid")]
                        [System.Text.Json.Serialization.JsonPropertyName("fieldid")]
                        public int FieldId { get; set; }

                        /// <summary>
                        /// 获取或设置字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_name")]
                        public string FieldName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_type")]
                        public int FieldType { get; set; }

                        /// <summary>
                        /// 获取或设置是否必须。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_must")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_must")]
                        public bool IsMust { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置字段组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public int GroupId { get; set; }

                /// <summary>
                /// 获取或设置字段组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_name")]
                [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                public string GroupName { get; set; } = default!;

                /// <summary>
                /// 获取或设置字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("field_list")]
                public Types.Field[] FieldList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置字段组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_list")]
        [System.Text.Json.Serialization.JsonPropertyName("group_list")]
        public Types.FieldGroup[] FieldGroupList { get; set; } = default!;
    }
}
