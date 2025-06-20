using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/get_records 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGetRecordsRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class SortField
            {
                /// <summary>
                /// 获取或设置字段标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_title")]
                [System.Text.Json.Serialization.JsonPropertyName("field_title")]
                public string FieldTitle { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否降序。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public bool IsDescend { get; set; }
            }

            public class FilterSpec
            {
                public static class Types
                {
                    public class Condition
                    {
                        public static class Types
                        {
                            public class StringValue
                            {
                                /// <summary>
                                /// 获取或设置值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public IList<string> Value { get; set; } = new List<string>();
                            }

                            public class NumberValue
                            {
                                /// <summary>
                                /// 获取或设置值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public decimal Value { get; set; }
                            }

                            public class BoolValue
                            {
                                /// <summary>
                                /// 获取或设置值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public bool Value { get; set; }
                            }

                            public class UserValue
                            {
                                /// <summary>
                                /// 获取或设置值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public IList<string> Value { get; set; } = new List<string>();
                            }

                            public class DateTimeValue
                            {
                                public static class Types
                                {
                                    public class Value
                                    {
                                        /// <summary>
                                        /// 获取或设置日期类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                                        public string Type { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置日期时间值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public IList<string>? DateTimes { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public Types.Value Value { get; set; } = new Types.Value();
                            }
                        }

                        /// <summary>
                        /// 获取或设置字段 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_id")]
                        public string FieldId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置字段类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_type")]
                        public string? FieldType { get; set; }

                        /// <summary>
                        /// 获取或设置判断类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operator")]
                        [System.Text.Json.Serialization.JsonPropertyName("operator")]
                        public string Operator { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置文本值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("string_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("string_value")]
                        public Types.StringValue? StringValue { get; set; }

                        /// <summary>
                        /// 获取或设置数字值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("number_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("number_value")]
                        public Types.NumberValue? NumberValue { get; set; }

                        /// <summary>
                        /// 获取或设置布尔值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bool_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("bool_value")]
                        public Types.BoolValue? BoolValue { get; set; }

                        /// <summary>
                        /// 获取或设置人员值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_value")]
                        public Types.UserValue? UserValue { get; set; }

                        /// <summary>
                        /// 获取或设置日期时间值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_time_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_time_value")]
                        public Types.DateTimeValue? DateTimeValue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置条件连词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conjunction")]
                [System.Text.Json.Serialization.JsonPropertyName("conjunction")]
                public string Conjunction { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置条件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conditions")]
                [System.Text.Json.Serialization.JsonPropertyName("conditions")]
                public IList<Types.Condition> ConditionList { get; set; } = new List<Types.Condition>();
            }
        }

        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子表 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sheet_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视图 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view_id")]
        [System.Text.Json.Serialization.JsonPropertyName("view_id")]
        public string? ViewId { get; set; }

        /// <summary>
        /// 获取或设置记录 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("record_ids")]
        public IList<string>? RecordIdList { get; set; }

        /// <summary>
        /// 获取或设置字段 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("field_ids")]
        public IList<string>? FieldIdList { get; set; }

        /// <summary>
        /// 获取或设置字段标题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field_titles")]
        [System.Text.Json.Serialization.JsonPropertyName("field_titles")]
        public IList<string>? FieldTitleList { get; set; }

        /// <summary>
        /// 获取或设置单元格键类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key_type")]
        [System.Text.Json.Serialization.JsonPropertyName("key_type")]
        public string? KeyType { get; set; }

        /// <summary>
        /// 获取或设置排序字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort")]
        [System.Text.Json.Serialization.JsonPropertyName("sort")]
        public IList<Types.SortField>? SortFieldList { get; set; }

        /// <summary>
        /// 获取或设置过滤设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_spec")]
        [System.Text.Json.Serialization.JsonPropertyName("filter_spec")]
        public Types.FilterSpec? FilterSpec { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
