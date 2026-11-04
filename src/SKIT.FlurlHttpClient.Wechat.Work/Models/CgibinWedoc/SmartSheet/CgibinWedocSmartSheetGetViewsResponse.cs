namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/get_views 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGetViewsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class View : CgibinWedocSmartSheetAddViewResponse.Types.View
            {
                public static class Types
                {
                    public class ViewProperty : CgibinWedocSmartSheetUpdateViewRequest.Types.__zz__ViewProperty
                    {
                        public static class Types
                        {
                            public class SortSpec
                            {
                                public static class Types
                                {
                                    public class SortField : CgibinWedocSmartSheetUpdateViewRequest.Types.ViewProperty.Types.SortSpec.Types.SortField
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置排序字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sort_infos")]
                                [System.Text.Json.Serialization.JsonPropertyName("sort_infos")]
                                public List<Types.SortField>? SortFieldList { get; set; }
                            }

                            public class GroupSpec
                            {
                                public static class Types
                                {
                                    public class GroupField : CgibinWedocSmartSheetUpdateViewRequest.Types.ViewProperty.Types.GroupSpec.Types.GroupField
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置分组字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("groups")]
                                [System.Text.Json.Serialization.JsonPropertyName("groups")]
                                public List<Types.GroupField>? GroupFieldList { get; set; }
                            }

                            public class FieldCondition : CgibinWedocSmartSheetUpdateViewRequest.Types.ViewProperty.Types.__zz__FieldCondition
                            {
                                public static class Types
                                {
                                    public class StringValue : CgibinWedocSmartSheetUpdateViewRequest.Types.ViewProperty.Types.FieldCondition.Types.StringValue
                                    {
                                    }

                                    public class NumberValue : CgibinWedocSmartSheetUpdateViewRequest.Types.ViewProperty.Types.FieldCondition.Types.NumberValue
                                    {
                                    }

                                    public class BoolValue : CgibinWedocSmartSheetUpdateViewRequest.Types.ViewProperty.Types.FieldCondition.Types.BoolValue
                                    {
                                    }

                                    public class UserValue : CgibinWedocSmartSheetUpdateViewRequest.Types.ViewProperty.Types.FieldCondition.Types.UserValue
                                    {
                                    }

                                    public class DateTimeValue
                                    {
                                        public static class Types
                                        {
                                            public class Value : CgibinWedocSmartSheetUpdateViewRequest.Types.ViewProperty.Types.FieldCondition.Types.DateTimeValue.Types.Value
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public Types.Value? Value { get; set; }
                                    }
                                }

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

                            public class FilterSpec
                            {
                                /// <summary>
                                /// 获取或设置条件连词。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("conjunction")]
                                [System.Text.Json.Serialization.JsonPropertyName("conjunction")]
                                public string? Conjunction { get; set; }

                                /// <summary>
                                /// 获取或设置条件列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("conditions")]
                                [System.Text.Json.Serialization.JsonPropertyName("conditions")]
                                public List<Types.FieldCondition>? ConditionList { get; set; }
                            }

                            public class ColorConfig
                            {
                                public static class Types
                                {
                                    public class ColorCondition : CgibinWedocSmartSheetUpdateViewRequest.Types.ViewProperty.Types.ColorConfig.Types.__zz__ColorCondition
                                    {
                                        /// <summary>
                                        /// 获取或设置条件信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("condition")]
                                        [System.Text.Json.Serialization.JsonPropertyName("condition")]
                                        public FieldCondition? Condition { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置填色条件列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("conditions")]
                                [System.Text.Json.Serialization.JsonPropertyName("conditions")]
                                public List<Types.ColorCondition>? ColorConditionList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置排序设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sort_spec")]
                        [System.Text.Json.Serialization.JsonPropertyName("sort_spec")]
                        public Types.SortSpec? SortSpec { get; set; }

                        /// <summary>
                        /// 获取或设置分组设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_spec")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_spec")]
                        public Types.GroupSpec? GroupSpec { get; set; }

                        /// <summary>
                        /// 获取或设置过滤设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("filter_spec")]
                        [System.Text.Json.Serialization.JsonPropertyName("filter_spec")]
                        public Types.FilterSpec? FilterSpec { get; set; }

                        /// <summary>
                        /// 获取或设置填色设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("color_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("color_config")]
                        public Types.ColorConfig? ColorConfig { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置视图属性信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property")]
                [System.Text.Json.Serialization.JsonPropertyName("property")]
                public Types.ViewProperty? Property { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置视图列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("views")]
        [System.Text.Json.Serialization.JsonPropertyName("views")]
        public List<Types.View>? ViewList { get; set; }

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
