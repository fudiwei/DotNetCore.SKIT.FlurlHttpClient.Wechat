namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/gettemplatedetail 接口的响应。</para>
    /// </summary>
    public class CgibinOAGetTemplateDetailResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class MultiLangText
            {
                /// <summary>
                /// 获取或设置语言类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lang")]
                [System.Text.Json.Serialization.JsonPropertyName("lang")]
                public string Language { get; set; } = default!;

                /// <summary>
                /// 获取或设置文本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string Text { get; set; } = default!;
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
                                public string Control { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置控件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string ControlId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置控件名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public MultiLangText[]? Title { get; set; }

                                /// <summary>
                                /// 获取或设置控件说明。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("placeholder")]
                                [System.Text.Json.Serialization.JsonPropertyName("placeholder")]
                                public MultiLangText[]? Placeholder { get; set; }

                                /// <summary>
                                /// 获取或设置是否为必填项。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("require")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("require")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                public bool IsRequired { get; set; }

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
                                /// 获取或设置 File 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("file")]
                                [System.Text.Json.Serialization.JsonPropertyName("file")]
                                public FileControlConfig? File { get; set; }

                                /// <summary>
                                /// 获取或设置 Tips 控件配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tips")]
                                [System.Text.Json.Serialization.JsonPropertyName("tips")]
                                public TipsControlConfig? Tips { get; set; }

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
                                public string Type { get; set; } = default!;
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
                                        public string Key { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置选项值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public MultiLangText[] Value { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置选择类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置选择列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("options")]
                                [System.Text.Json.Serialization.JsonPropertyName("options")]
                                public Types.Option[] OptionList { get; set; } = default!;
                            }

                            public class ContactControlConfig
                            {
                                /// <summary>
                                /// 获取或设置选择方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置选择对象。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mode")]
                                [System.Text.Json.Serialization.JsonPropertyName("mode")]
                                public string Mode { get; set; } = default!;
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
                                                                        public string Content { get; set; } = default!;
                                                                    }

                                                                    public class Link
                                                                    {
                                                                        /// <summary>
                                                                        /// 获取或设置链接标题。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("title")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                                                                        public string Title { get; set; } = default!;

                                                                        /// <summary>
                                                                        /// 获取或设置链接 URL。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("url")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                                                                        public string URL { get; set; } = default!;
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
                                                        public Types.Content Content { get; set; } = default!;
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置说明文字分段列表。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("sub_text")]
                                                [System.Text.Json.Serialization.JsonPropertyName("sub_text")]
                                                public Types.SubText[] SubTextList { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置语言类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("lang")]
                                        [System.Text.Json.Serialization.JsonPropertyName("lang")]
                                        public string Language { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置说明文字信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("text")]
                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                        public Types.Text Text { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置说明文字列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tips_content")]
                                [System.Text.Json.Serialization.JsonPropertyName("tips_content")]
                                public Types.TipsContent[] TipsList { get; set; } = default!;
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
                                public Control[] Children { get; set; } = default!;
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
                                public Types.DateRange DateRange { get; set; } = default!;
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
                                        public MultiLangText[] Name { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置假期列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item")]
                                [System.Text.Json.Serialization.JsonPropertyName("item")]
                                public Types.Vacation[] VacationList { get; set; } = default!;
                            }

                            public class DateRangeControlConfig
                            {
                                /// <summary>
                                /// 获取或设置时间刻度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

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
                                public string[] TemplateIdList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置模板控件属性。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("property")]
                        [System.Text.Json.Serialization.JsonPropertyName("property")]
                        public Types.Property Property { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置模板控件配置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("config")]
                        [System.Text.Json.Serialization.JsonPropertyName("config")]
                        public Types.Config Config { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置模板控件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("controls")]
                [System.Text.Json.Serialization.JsonPropertyName("controls")]
                public Types.Control[] ControlList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置模板名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_names")]
        [System.Text.Json.Serialization.JsonPropertyName("template_names")]
        public Types.MultiLangText[] TemplateName { get; set; } = default!;

        /// <summary>
        /// 获取或设置模板内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_content")]
        [System.Text.Json.Serialization.JsonPropertyName("template_content")]
        public Types.TemplateContent TemplateContent { get; set; } = default!;
    }
}
