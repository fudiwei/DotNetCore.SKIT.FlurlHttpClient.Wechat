namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/get_fields 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGetFieldsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Field : CgibinWedocSmartSheetAddFieldsRequest.Types.__zz__Field
            {
                public static class Types
                {
                    public class TextFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.TextFieldProperty
                    {
                    }

                    public class NumberFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.NumberFieldProperty
                    {
                    }

                    public class CheckboxFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.CheckboxFieldProperty
                    {
                    }

                    public class DateTimeFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.DateTimeFieldProperty
                    {
                    }

                    public class AttachmentFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.AttachmentFieldProperty
                    {
                    }

                    public class UserFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.UserFieldProperty
                    {
                    }

                    public class UrlFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.UrlFieldProperty
                    {
                    }

                    public class SelectFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.__zz__SelectFieldProperty
                    {
                        public static class Types
                        {
                            public class Option : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.SelectFieldProperty.Types.Option
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("options")]
                        [System.Text.Json.Serialization.JsonPropertyName("options")]
                        public List<Types.Option>? OptionList { get; set; }
                    }

                    public class CreatedTimeFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.CreatedTimeFieldProperty
                    {
                    }

                    public class ModifiedTimeFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.ModifiedTimeFieldProperty
                    {
                    }

                    public class ProgressFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.ProgressFieldProperty
                    {
                    }

                    public class SingleSelectFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.__zz__SingleSelectFieldProperty
                    {
                        public static class Types
                        {
                            public class Option : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.SingleSelectFieldProperty.Types.Option
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("options")]
                        [System.Text.Json.Serialization.JsonPropertyName("options")]
                        public List<Types.Option>? OptionList { get; set; }
                    }

                    public class ReferenceFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.ReferenceFieldProperty
                    {
                    }

                    public class LocationFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.LocationFieldProperty
                    {
                    }

                    public class AutoNumberFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.__zz__AutoNumberFieldProperty
                    {
                        public static class Types
                        {
                            public class Rule : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.AutoNumberFieldProperty.Types.Rule
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置自定义规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rules")]
                        [System.Text.Json.Serialization.JsonPropertyName("rules")]
                        public List<Types.Rule>? RuleList { get; set; }
                    }

                    public class CurrencyFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.CurrencyFieldProperty
                    {
                    }

                    public class GroupChatFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.GroupChatFieldProperty
                    {
                    }

                    public class PercentageFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.PercentageFieldProperty
                    {
                    }

                    public class BarcodeFieldProperty : CgibinWedocSmartSheetAddFieldsRequest.Types.Field.Types.BarcodeFieldProperty
                    {
                    }
                }

                /// <summary>
                /// 获取或设置字段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_id")]
                [System.Text.Json.Serialization.JsonPropertyName("field_id")]
                public string? FieldId { get; set; }

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
        /// 获取或设置字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fields")]
        [System.Text.Json.Serialization.JsonPropertyName("fields")]
        public List<Types.Field>? FieldList { get; set; }

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
    }
}
