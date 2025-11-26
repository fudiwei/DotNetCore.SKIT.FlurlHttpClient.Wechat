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
                        public static class Types
                        {
                            public class Option
                            {
                                /// <summary>
                                /// 获取或设置选项的枚举值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public int OptionId { get; set; }

                                /// <summary>
                                /// 获取或设置选项的文本内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public string Value { get; set; } = default!;
                            }
                        }

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
                        /// 获取或设置字段值类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_type")]
                        public int ValueType { get; set; }

                        /// <summary>
                        /// 获取或设置是否必须。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_must")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_must")]
                        public bool IsMust { get; set; }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                        public Types.Option[]? OptionList { get; set; }
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
