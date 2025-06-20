using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/update_view 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetUpdateViewRequest : WechatWorkRequest
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
                                public string FieldId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置是否降序。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public bool? IsDescend { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置排序字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sort_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("sort_infos")]
                        public IList<Types.SortField> SortFieldList { get; set; } = new List<Types.SortField>();
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
                                public string FieldId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置是否降序。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public bool? IsDescend { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置分组字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("groups")]
                        [System.Text.Json.Serialization.JsonPropertyName("groups")]
                        public IList<Types.GroupField> GroupFieldList { get; set; } = new List<Types.GroupField>();
                    }

                    public class FilterSpec
                    {
                        public static class Types
                        {
                            public class Condition : CgibinWedocSmartSheetGetRecordsRequest.Types.FilterSpec.Types.Condition
                            {
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
                /// 获取或设置是否自动重新排序。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_sort")]
                [System.Text.Json.Serialization.JsonPropertyName("auto_sort")]
                public bool? IsAutoSort { get; set; }

                /// <summary>
                /// 获取或设置是否使用数据统计。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_field_stat_enabled")]
                [System.Text.Json.Serialization.JsonPropertyName("is_field_stat_enabled")]
                public bool? IsFieldStatEnabled { get; set; }

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
                /// 获取或设置字段可见性字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_visibility")]
                [System.Text.Json.Serialization.JsonPropertyName("field_visibility")]
                public IDictionary<string, bool>? FieldVisibilityMap { get; set; } = default!;

                /// <summary>
                /// 获取或设置冻结列数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("frozen_field_count")]
                [System.Text.Json.Serialization.JsonPropertyName("frozen_field_count")]
                public int? FrozenFieldCount { get; set; }
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
        public string ViewId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视图名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view_title")]
        [System.Text.Json.Serialization.JsonPropertyName("view_title")]
        public string? ViewTitle { get; set; }

        /// <summary>
        /// 获取或设置视图属性信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("property")]
        [System.Text.Json.Serialization.JsonPropertyName("property")]
        public Types.ViewProperty? ViewProperty { get; set; }
    }
}
