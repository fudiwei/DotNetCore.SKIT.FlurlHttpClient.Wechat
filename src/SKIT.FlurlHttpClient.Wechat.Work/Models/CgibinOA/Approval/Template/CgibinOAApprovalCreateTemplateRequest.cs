using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/approval/create_template 接口的请求。</para>
    /// </summary>
    public class CgibinOAApprovalCreateTemplateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class MultiLangText : CgibinOAApplyEventRequest.Types.MultiLangText
            {
            }

            public class TemplateContent
            {
                public static class Types
                {
                    public class Control
                    {
                        public static class Types
                        {
                            public class Property
                            {
                                /// <summary>
                                /// 获取或设置控件类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("control")]
                                [System.Text.Json.Serialization.JsonPropertyName("control")]
                                public string Control { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置控件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string ControlId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置控件名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public IList<MultiLangText>? Title { get; set; }

                                /// <summary>
                                /// 获取或设置控件说明。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("placeholder")]
                                [System.Text.Json.Serialization.JsonPropertyName("placeholder")]
                                public IList<MultiLangText>? Placeholder { get; set; }

                                /// <summary>
                                /// 获取或设置是否为必填项。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("require")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("require")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                public bool? IsRequired { get; set; }

                                /// <summary>
                                /// 获取或设置是否不可打印。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("un_print")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("un_print")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                public bool IsUnprintable { get; set; }
                            }

                            public class Config
                            {
                                /// <summary>
                                /// 获取或设置 Date 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("date")]
                                [System.Text.Json.Serialization.JsonPropertyName("date")]
                                public DateControlConfig? Date { get; set; }

                                /// <summary>
                                /// 获取或设置 Selector 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("selector")]
                                [System.Text.Json.Serialization.JsonPropertyName("selector")]
                                public SelectorControlConfig? Selector { get; set; }

                                /// <summary>
                                /// 获取或设置 Contact 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("contact")]
                                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                                public ContactControlConfig? Contact { get; set; }

                                /// <summary>
                                /// 获取或设置 Tips 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tips")]
                                [System.Text.Json.Serialization.JsonPropertyName("tips")]
                                public TipsControlConfig? Tips { get; set; }

                                /// <summary>
                                /// 获取或设置 File 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("file")]
                                [System.Text.Json.Serialization.JsonPropertyName("file")]
                                public FileControlConfig? File { get; set; }

                                /// <summary>
                                /// 获取或设置 Table 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("table")]
                                [System.Text.Json.Serialization.JsonPropertyName("table")]
                                public TableControlConfig? Table { get; set; }

                                /// <summary>
                                /// 获取或设置 Attendance 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attendance")]
                                [System.Text.Json.Serialization.JsonPropertyName("attendance")]
                                public AttendanceControlConfig? Attendance { get; set; }

                                /// <summary>
                                /// 获取或设置 Vacation 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("vacation_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("vacation_list")]
                                public VacationControlConfig? Vacation { get; set; }

                                /// <summary>
                                /// 获取或设置 DateRange 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("date_range")]
                                [System.Text.Json.Serialization.JsonPropertyName("date_range")]
                                public DateRangeControlConfig? DateRange { get; set; }

                                /// <summary>
                                /// 获取或设置 Location 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("location")]
                                [System.Text.Json.Serialization.JsonPropertyName("location")]
                                public LocationControlConfig? Location { get; set; }

                                /// <summary>
                                /// 获取或设置 RelatedApproval 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("related_approval")]
                                [System.Text.Json.Serialization.JsonPropertyName("related_approval")]
                                public RelatedApprovalControlConfig? RelatedApproval { get; set; }
                            }

                            public class DateControlConfig
                            {
                                /// <summary>
                                /// 获取或设置时间展示类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = string.Empty;
                            }

                            public class SelectorControlConfig
                            {
                                public static class Types
                                {
                                    public class Option
                                    {
                                        /// <summary>
                                        /// 获取或设置选项 Key。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("key")]
                                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                                        public string Key { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置选项值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public IList<MultiLangText> Value { get; set; } = new List<MultiLangText>();
                                    }
                                }

                                /// <summary>
                                /// 获取或设置选择类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置选择列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("options")]
                                [System.Text.Json.Serialization.JsonPropertyName("options")]
                                public IList<Types.Option> OptionList { get; set; } = new List<Types.Option>();
                            }

                            public class ContactControlConfig
                            {
                                /// <summary>
                                /// 获取或设置选择方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置选择对象。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mode")]
                                [System.Text.Json.Serialization.JsonPropertyName("mode")]
                                public string Mode { get; set; } = string.Empty;
                            }

                            public class TipsControlConfig
                            {
                                public static class Types
                                {
                                    public class TipsContent
                                    {
                                        public static class Types
                                        {
                                            public class Text
                                            {
                                                public static class Types
                                                {
                                                    public class SubText
                                                    {
                                                        public static class Types
                                                        {
                                                            public class Content
                                                            {
                                                                public static class Types
                                                                {
                                                                    public class PlainText
                                                                    {
                                                                        /// <summary>
                                                                        /// 获取或设置纯文本文字。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("content")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                                                                        public string Content { get; set; } = string.Empty;
                                                                    }

                                                                    public class Link
                                                                    {
                                                                        /// <summary>
                                                                        /// 获取或设置链接标题。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("title")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                                                                        public string Title { get; set; } = string.Empty;

                                                                        /// <summary>
                                                                        /// 获取或设置链接 URL。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("url")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                                                                        public string URL { get; set; } = string.Empty;
                                                                    }
                                                                }

                                                                /// <summary>
                                                                /// 获取或设置纯文本类型的内容信息。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("plain_text")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("plain_text")]
                                                                public Types.PlainText? PlainText { get; set; }

                                                                /// <summary>
                                                                /// 获取或设置链接类型的内容信息。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("link")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("link")]
                                                                public Types.Link? Link { get; set; }
                                                            }
                                                        }

                                                        /// <summary>
                                                        /// 获取或设置文本类型。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("type")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                                                        public int Type { get; set; }

                                                        /// <summary>
                                                        /// 获取或设置文本内容。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("content")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                                                        public Types.Content Content { get; set; } = new Types.Content();
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置说明文字分段列表。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("sub_text")]
                                                [System.Text.Json.Serialization.JsonPropertyName("sub_text")]
                                                public IList<Types.SubText> SubTextList { get; set; } = new List<Types.SubText>();
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置语言类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("lang")]
                                        [System.Text.Json.Serialization.JsonPropertyName("lang")]
                                        public string Language { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置说明文字信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("text")]
                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                        public Types.Text Text { get; set; } = new Types.Text();
                                    }
                                }

                                /// <summary>
                                /// 获取或设置说明文字列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tips_content")]
                                [System.Text.Json.Serialization.JsonPropertyName("tips_content")]
                                public IList<Types.TipsContent> TipsList { get; set; } = new List<Types.TipsContent>();
                            }

                            public class FileControlConfig
                            {
                                /// <summary>
                                /// 获取或设置是否只允许拍照。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_only_photo")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("is_only_photo")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                public bool IsOnlyPhoto { get; set; }
                            }

                            public class TableControlConfig
                            {
                                /// <summary>
                                /// 获取或设置打印格式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("print_format")]
                                [System.Text.Json.Serialization.JsonPropertyName("print_format")]
                                public int PrintFormat { get; set; }

                                /// <summary>
                                /// 获取或设置子控件。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("children")]
                                [System.Text.Json.Serialization.JsonPropertyName("children")]
                                public IList<Control> Children { get; set; } = new List<Control>();
                            }

                            public class AttendanceControlConfig
                            {
                                public static class Types
                                {
                                    public class DateRange : DateRangeControlConfig
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置假勤类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置时间选择范围。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("date_range")]
                                [System.Text.Json.Serialization.JsonPropertyName("date_range")]
                                public Types.DateRange DateRange { get; set; } = new Types.DateRange();
                            }

                            public class VacationControlConfig
                            {
                                public static class Types
                                {
                                    public class Vacation
                                    {
                                        /// <summary>
                                        /// 获取或设置假期类型标识。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                                        public int VacationId { get; set; }

                                        /// <summary>
                                        /// 获取或设置假期类型名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public IList<MultiLangText> Name { get; set; } = new List<MultiLangText>();
                                    }
                                }

                                /// <summary>
                                /// 获取或设置假期列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item")]
                                [System.Text.Json.Serialization.JsonPropertyName("item")]
                                public IList<Types.Vacation> VacationList { get; set; } = new List<Types.Vacation>();
                            }

                            public class DateRangeControlConfig
                            {
                                /// <summary>
                                /// 获取或设置时间刻度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置自然日或工作日。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("official_holiday")]
                                [System.Text.Json.Serialization.JsonPropertyName("official_holiday")]
                                public int? OfficialHoliday { get; set; }

                                /// <summary>
                                /// 获取或设置一天的时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("perday_duration")]
                                [System.Text.Json.Serialization.JsonPropertyName("perday_duration")]
                                public int? PerdayDuration { get; set; }
                            }

                            public class LocationControlConfig
                            {
                                /// <summary>
                                /// 获取或设置距离（单位：米）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("distance")]
                                [System.Text.Json.Serialization.JsonPropertyName("distance")]
                                public int Distance { get; set; }
                            }

                            public class RelatedApprovalControlConfig
                            {
                                /// <summary>
                                /// 获取或设置审批单模板 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("template_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                                public IList<string> TemplateIdList { get; set; } = new List<string>();
                            }
                        }

                        /// <summary>
                        /// 获取或设置模板控件属性。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("property")]
                        [System.Text.Json.Serialization.JsonPropertyName("property")]
                        public Types.Property Property { get; set; } = new Types.Property();

                        /// <summary>
                        /// 获取或设置模板控件配置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("config")]
                        [System.Text.Json.Serialization.JsonPropertyName("config")]
                        public Types.Config? Config { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板控件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("controls")]
                [System.Text.Json.Serialization.JsonPropertyName("controls")]
                public IList<Types.Control> ControlList { get; set; } = new List<Types.Control>();
            }
        }

        /// <summary>
        /// 获取或设置模板名称列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_name")]
        [System.Text.Json.Serialization.JsonPropertyName("template_name")]
        public IList<Types.MultiLangText> TemplateName { get; set; } = new List<Types.MultiLangText>();

        /// <summary>
        /// 获取或设置模板内容信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_content")]
        [System.Text.Json.Serialization.JsonPropertyName("template_content")]
        public Types.TemplateContent TemplateContent { get; set; } = new Types.TemplateContent();
    }
}
