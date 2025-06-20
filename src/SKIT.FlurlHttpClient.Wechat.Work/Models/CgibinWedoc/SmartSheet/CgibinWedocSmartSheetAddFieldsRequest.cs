using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/add_fields 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetAddFieldsRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Field
            {
                public static class Types
                {
                    public class TextFieldProperty
                    {
                    }

                    public class NumberFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置小数点的位数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("decimal_places")]
                        [System.Text.Json.Serialization.JsonPropertyName("decimal_places")]
                        public int DecimalPlaces { get; set; }

                        /// <summary>
                        /// 获取或设置是否使用千位符。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_separate")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_separate")]
                        public bool IsUseSeparate { get; set; }
                    }

                    public class CheckboxFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置是否默认勾选。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("checked")]
                        [System.Text.Json.Serialization.JsonPropertyName("checked")]
                        public bool IsChecked { get; set; }
                    }

                    public class DateTimeFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置日期格式字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("format")]
                        [System.Text.Json.Serialization.JsonPropertyName("format")]
                        public string FormatString { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置是否自动填充。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auto_fill")]
                        [System.Text.Json.Serialization.JsonPropertyName("auto_fill")]
                        public bool IsAutoFill { get; set; }
                    }

                    public class AttachmentFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置显示模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("display_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("display_mode")]
                        public string DisplayMode { get; set; } = string.Empty;
                    }

                    public class UserFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置是否允许添加多个。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_multiple")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_multiple")]
                        public bool IsMultiple { get; set; }

                        /// <summary>
                        /// 获取或设置是否通知用户。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_notified")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_notified")]
                        public bool IsNotified { get; set; }
                    }

                    public class UrlFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置超链接展示样式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = string.Empty;
                    }

                    public class SelectFieldProperty
                    {
                        public static class Types
                        {
                            public class Option
                            {
                                /// <summary>
                                /// 获取或设置选项 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string Id { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置选项内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string Text { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置选项颜色。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("style")]
                                [System.Text.Json.Serialization.JsonPropertyName("style")]
                                public int Style { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否允许填写时新增选项。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_quick_add")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_quick_add")]
                        public bool IsQuickAdd { get; set; }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("options")]
                        [System.Text.Json.Serialization.JsonPropertyName("options")]
                        public IList<Types.Option> OptionList { get; set; } = new List<Types.Option>();
                    }

                    public class CreatedTimeFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置日期格式字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("format")]
                        [System.Text.Json.Serialization.JsonPropertyName("format")]
                        public string FormatString { get; set; } = string.Empty;
                    }

                    public class ModifiedTimeFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置日期格式字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("format")]
                        [System.Text.Json.Serialization.JsonPropertyName("format")]
                        public string FormatString { get; set; } = string.Empty;
                    }

                    public class ProgressFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置小数点的位数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("decimal_places")]
                        [System.Text.Json.Serialization.JsonPropertyName("decimal_places")]
                        public int DecimalPlaces { get; set; }
                    }

                    public class SingleSelectFieldProperty
                    {
                        public static class Types
                        {
                            public class Option : SelectFieldProperty.Types.Option
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否允许填写时新增选项。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_quick_add")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_quick_add")]
                        public bool IsQuickAdd { get; set; }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("options")]
                        [System.Text.Json.Serialization.JsonPropertyName("options")]
                        public IList<Types.Option> OptionList { get; set; } = new List<Types.Option>();
                    }

                    public class ReferenceFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置视图 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_id")]
                        public string Viewid { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置关联的子表 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_id")]
                        public string? SheetId { get; set; }

                        /// <summary>
                        /// 获取或设置关联的字段 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_id")]
                        public string? FieldId { get; set; }

                        /// <summary>
                        /// 获取或设置是否允许多选。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_multiple")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_multiple")]
                        public bool IsMultiple { get; set; }
                    }

                    public class LocationFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置输入类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("input_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("input_type")]
                        public string InputType { get; set; } = string.Empty;
                    }

                    public class AutoNumberFieldProperty
                    {
                        public static class Types
                        {
                            public class Rule
                            {
                                /// <summary>
                                /// 获取或设置规则类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public string Value { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置输入类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("input_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("input_type")]
                        public string InputType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置自定义规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rules")]
                        [System.Text.Json.Serialization.JsonPropertyName("rules")]
                        public IList<Types.Rule>? RuleList { get; set; }

                        /// <summary>
                        /// 获取或设置是否应用于已有编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reformat_existing_record")]
                        [System.Text.Json.Serialization.JsonPropertyName("reformat_existing_record")]
                        public bool IsReformatExistingRecord { get; set; }
                    }

                    public class CurrencyFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置货币类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency_type")]
                        public string CurrencyType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小数点的位数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("decimal_places")]
                        [System.Text.Json.Serialization.JsonPropertyName("decimal_places")]
                        public int DecimalPlaces { get; set; }

                        /// <summary>
                        /// 获取或设置是否使用千位符。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_separate")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_separate")]
                        public bool IsUseSeparate { get; set; }
                    }

                    public class GroupChatFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置是否允许多个群聊。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("allow_multiple")]
                        [System.Text.Json.Serialization.JsonPropertyName("allow_multiple")]
                        public bool IsAllowMultiple { get; set; }
                    }

                    public class PercentageFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置小数点的位数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("decimal_places")]
                        [System.Text.Json.Serialization.JsonPropertyName("decimal_places")]
                        public int DecimalPlaces { get; set; }

                        /// <summary>
                        /// 获取或设置是否使用千位符。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_separate")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_separate")]
                        public bool IsUseSeparate { get; set; }
                    }

                    public class BarcodeFieldProperty
                    {
                        /// <summary>
                        /// 获取或设置是否仅限手机扫描录入。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile_scan_only")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile_scan_only")]
                        public bool IsMobileScanOnly { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置字段名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_title")]
                [System.Text.Json.Serialization.JsonPropertyName("field_title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置字段类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_type")]
                [System.Text.Json.Serialization.JsonPropertyName("field_type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置文本类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_text")]
                [System.Text.Json.Serialization.JsonPropertyName("property_text")]
                public Types.TextFieldProperty? PropertyAsText { get; set; }

                /// <summary>
                /// 获取或设置数字类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_number")]
                [System.Text.Json.Serialization.JsonPropertyName("property_number")]
                public Types.NumberFieldProperty? PropertyAsNumber { get; set; }

                /// <summary>
                /// 获取或设置复选框类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_checkbox")]
                [System.Text.Json.Serialization.JsonPropertyName("property_checkbox")]
                public Types.CheckboxFieldProperty? PropertyAsCheckbox { get; set; }

                /// <summary>
                /// 获取或设置日期类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_date_time")]
                [System.Text.Json.Serialization.JsonPropertyName("property_date_time")]
                public Types.DateTimeFieldProperty? PropertyAsDateTime { get; set; }

                /// <summary>
                /// 获取或设置文件类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_attachment")]
                [System.Text.Json.Serialization.JsonPropertyName("property_attachment")]
                public Types.AttachmentFieldProperty? PropertyAsAttachment { get; set; }

                /// <summary>
                /// 获取或设置人员类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_user")]
                [System.Text.Json.Serialization.JsonPropertyName("property_user")]
                public Types.UserFieldProperty? PropertyAsUser { get; set; }

                /// <summary>
                /// 获取或设置超链接类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_url")]
                [System.Text.Json.Serialization.JsonPropertyName("property_url")]
                public Types.UrlFieldProperty? PropertyAsUrl { get; set; }

                /// <summary>
                /// 获取或设置多选类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_select")]
                [System.Text.Json.Serialization.JsonPropertyName("property_select")]
                public Types.SelectFieldProperty? PropertyAsSelect { get; set; }

                /// <summary>
                /// 获取或设置创建时间类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_created_time")]
                [System.Text.Json.Serialization.JsonPropertyName("property_created_time")]
                public Types.CreatedTimeFieldProperty? PropertyAsCreatedTime { get; set; }

                /// <summary>
                /// 获取或设置最后编辑时间类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_modified_time")]
                [System.Text.Json.Serialization.JsonPropertyName("property_modified_time")]
                public Types.ModifiedTimeFieldProperty? PropertyAsModifiedTime { get; set; }

                /// <summary>
                /// 获取或设置进度类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_progress")]
                [System.Text.Json.Serialization.JsonPropertyName("property_progress")]
                public Types.ProgressFieldProperty? PropertyAsProgress { get; set; }

                /// <summary>
                /// 获取或设置单选类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_single_select")]
                [System.Text.Json.Serialization.JsonPropertyName("property_single_select")]
                public Types.SingleSelectFieldProperty? PropertyAsSingleSelect { get; set; }

                /// <summary>
                /// 获取或设置引用类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_reference")]
                [System.Text.Json.Serialization.JsonPropertyName("property_reference")]
                public Types.ReferenceFieldProperty? PropertyAsReference { get; set; }

                /// <summary>
                /// 获取或设置地理位置类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_location")]
                [System.Text.Json.Serialization.JsonPropertyName("property_location")]
                public Types.LocationFieldProperty? PropertyAsLocation { get; set; }

                /// <summary>
                /// 获取或设置自动编号类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_auto_number")]
                [System.Text.Json.Serialization.JsonPropertyName("property_auto_number")]
                public Types.AutoNumberFieldProperty? PropertyAsAutoNumber { get; set; }

                /// <summary>
                /// 获取或设置货币类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_currency")]
                [System.Text.Json.Serialization.JsonPropertyName("property_currency")]
                public Types.CurrencyFieldProperty? PropertyAsCurrency { get; set; }

                /// <summary>
                /// 获取或设置群类型的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_ww_group")]
                [System.Text.Json.Serialization.JsonPropertyName("property_ww_group")]
                public Types.GroupChatFieldProperty? PropertyAsGroupChat { get; set; }

                /// <summary>
                /// 获取或设置百分数的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_percentage")]
                [System.Text.Json.Serialization.JsonPropertyName("property_percentage")]
                public Types.PercentageFieldProperty? PropertyAsPercentage { get; set; }

                /// <summary>
                /// 获取或设置条码的字段属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_barcode")]
                [System.Text.Json.Serialization.JsonPropertyName("property_barcode")]
                public Types.BarcodeFieldProperty? PropertyAsBarcode { get; set; }
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
        /// 获取或设置字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fields")]
        [System.Text.Json.Serialization.JsonPropertyName("fields")]
        public IList<Types.Field> FieldList { get; set; } = new List<Types.Field>();
    }
}
