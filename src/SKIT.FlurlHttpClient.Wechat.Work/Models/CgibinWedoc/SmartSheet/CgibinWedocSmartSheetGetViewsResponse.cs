using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/get_views 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGetViewsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class View
            {
                public static class Types
                {
                    public class ViewProperty
                    {
                        public static class Types
                        {
                            public class SortSpec
                            {
                                public static class Types
                                {
                                    public class SortField
                                    {
                                        /// <summary>
                                        /// 获取或设置字段 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("field_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("field_id")]
                                        public string FieldId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置是否降序。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("desc")]
                                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                        public bool IsDescend { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置排序字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sort_infos")]
                                [System.Text.Json.Serialization.JsonPropertyName("sort_infos")]
                                public Types.SortField[] SortFieldList { get; set; } = default!;
                            }

                            public class GroupSpec
                            {
                                public static class Types
                                {
                                    public class GroupField
                                    {
                                        /// <summary>
                                        /// 获取或设置字段 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("field_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("field_id")]
                                        public string FieldId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置是否降序。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("desc")]
                                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                        public bool IsDescend { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置分组字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("groups")]
                                [System.Text.Json.Serialization.JsonPropertyName("groups")]
                                public Types.GroupField[] GroupFieldList { get; set; } = default!;
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
                                                public string[] Value { get; set; } = default!;
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
                                                public string[] Value { get; set; } = default!;
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
                                                        public string Type { get; set; } = default!;

                                                        /// <summary>
                                                        /// 获取或设置日期时间值。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("value")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                                        public string[]? DateTimes { get; set; }
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置值。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("value")]
                                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                                public Types.Value Value { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置字段 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("field_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("field_id")]
                                        public string FieldId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置字段类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("field_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("field_type")]
                                        public string FieldType { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置判断类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("operator")]
                                        [System.Text.Json.Serialization.JsonPropertyName("operator")]
                                        public string Operator { get; set; } = default!;

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
                                public string Conjunction { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置条件列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("conditions")]
                                [System.Text.Json.Serialization.JsonPropertyName("conditions")]
                                public Types.Condition[] ConditionList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否自动重新排序。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auto_sort")]
                        [System.Text.Json.Serialization.JsonPropertyName("auto_sort")]
                        public bool IsAutoSort { get; set; }

                        /// <summary>
                        /// 获取或设置是否使用数据统计。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_field_stat_enabled")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_field_stat_enabled")]
                        public bool IsFieldStatEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置排序设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sort_spec")]
                        [System.Text.Json.Serialization.JsonPropertyName("sort_spec")]
                        public Types.SortSpec SortSpec { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分组设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_spec")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_spec")]
                        public Types.GroupSpec GroupSpec { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置过滤设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("filter_spec")]
                        [System.Text.Json.Serialization.JsonPropertyName("filter_spec")]
                        public Types.FilterSpec FilterSpec { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段可见性字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_visibility")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_visibility")]
                        public IDictionary<string, bool> FieldVisibilityMap { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置冻结列数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("frozen_field_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("frozen_field_count")]
                        public int FrozenFieldCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置视图 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_id")]
                [System.Text.Json.Serialization.JsonPropertyName("view_id")]
                public string ViewId { get; set; } = default!;

                /// <summary>
                /// 获取或设置视图名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_title")]
                [System.Text.Json.Serialization.JsonPropertyName("view_title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置视图类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_type")]
                [System.Text.Json.Serialization.JsonPropertyName("view_type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置视图属性信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property")]
                [System.Text.Json.Serialization.JsonPropertyName("property")]
                public Types.ViewProperty Property { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置视图列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("views")]
        [System.Text.Json.Serialization.JsonPropertyName("views")]
        public Types.View[] ViewList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置下一页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next")]
        [System.Text.Json.Serialization.JsonPropertyName("next")]
        public int? NextOffset { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
