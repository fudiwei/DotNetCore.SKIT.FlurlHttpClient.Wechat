namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/gettemplatedetail 接口的响应。</para>
    /// </summary>
    public class CgibinOAGetTemplateDetailResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class MultiLangText : CgibinOAApprovalCreateTemplateRequest.Types.MultiLangText
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
                            public class Property : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.__zz__Property
                            {
                                /// <summary>
                                /// 获取或设置控件名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public List<MultiLangText>? Title { get; set; }

                                /// <summary>
                                /// 获取或设置控件说明。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("placeholder")]
                                [System.Text.Json.Serialization.JsonPropertyName("placeholder")]
                                public List<MultiLangText>? Placeholder { get; set; }
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

                            public class DateControlConfig : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.DateControlConfig
                            {
                            }

                            public class SelectorControlConfig : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.__zz__SelectorControlConfig
                            {
                                public static class Types
                                {
                                    public class Option : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.SelectorControlConfig.Types.__zz__Option
                                    {
                                        /// <summary>
                                        /// 获取或设置选项值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public List<MultiLangText>? Value { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置选择列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("options")]
                                [System.Text.Json.Serialization.JsonPropertyName("options")]
                                public List<Types.Option>? OptionList { get; set; }
                            }

                            public class ContactControlConfig : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.ContactControlConfig
                            {
                            }

                            public class TipsControlConfig
                            {
                                public static class Types
                                {
                                    public class TipsContent : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.TipsControlConfig.Types.__zz__TipsContent
                                    {
                                        public static class Types
                                        {
                                            public class Text
                                            {
                                                public static class Types
                                                {
                                                    public class SubText : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.TipsControlConfig.Types.TipsContent.Types.Text.Types.__zz__SubText
                                                    {
                                                        public static class Types
                                                        {
                                                            public class Content
                                                            {
                                                                public static class Types
                                                                {
                                                                    public class PlainText : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.TipsControlConfig.Types.TipsContent.Types.Text.Types.SubText.Types.Content.Types.PlainText
                                                                    {
                                                                    }

                                                                    public class Link : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.TipsControlConfig.Types.TipsContent.Types.Text.Types.SubText.Types.Content.Types.Link
                                                                    {
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
                                                        /// 获取或设置文本内容。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("content")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                                                        public Types.Content? Content { get; set; }
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置说明文字分段列表。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("sub_text")]
                                                [System.Text.Json.Serialization.JsonPropertyName("sub_text")]
                                                public List<Types.SubText>? SubTextList { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置说明文字信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("text")]
                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                        public Types.Text? Text { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置说明文字列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tips_content")]
                                [System.Text.Json.Serialization.JsonPropertyName("tips_content")]
                                public List<Types.TipsContent>? TipsList { get; set; }
                            }

                            public class FileControlConfig : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.FileControlConfig
                            {
                            }

                            public class TableControlConfig : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.__zz__TableControlConfig
                            {
                                /// <summary>
                                /// 获取或设置子控件。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("children")]
                                [System.Text.Json.Serialization.JsonPropertyName("children")]
                                public List<Control>? Children { get; set; }
                            }

                            public class AttendanceControlConfig : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.__zz__AttendanceControlConfig
                            {
                                public static class Types
                                {
                                    public class DateRange : DateRangeControlConfig
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置时间选择范围。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("date_range")]
                                [System.Text.Json.Serialization.JsonPropertyName("date_range")]
                                public Types.DateRange? DateRange { get; set; }
                            }

                            public class VacationControlConfig
                            {
                                public static class Types
                                {
                                    public class Vacation : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.VacationControlConfig.Types.__zz__Vacation
                                    {
                                        /// <summary>
                                        /// 获取或设置假期类型名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public List<MultiLangText>? Name { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置假期列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item")]
                                [System.Text.Json.Serialization.JsonPropertyName("item")]
                                public List<Types.Vacation>? VacationList { get; set; }
                            }

                            public class DateRangeControlConfig : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.DateRangeControlConfig
                            {
                            }

                            public class LocationControlConfig : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.LocationControlConfig
                            {
                            }

                            public class RelatedApprovalControlConfig : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.RelatedApprovalControlConfig
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置模板控件属性。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("property")]
                        [System.Text.Json.Serialization.JsonPropertyName("property")]
                        public Types.Property? Property { get; set; }

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
                public List<Types.Control>? ControlList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置模板名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_names")]
        [System.Text.Json.Serialization.JsonPropertyName("template_names")]
        public List<Types.MultiLangText>? TemplateName { get; set; }

        /// <summary>
        /// 获取或设置模板内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_content")]
        [System.Text.Json.Serialization.JsonPropertyName("template_content")]
        public Types.TemplateContent? TemplateContent { get; set; }
    }
}
