using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/activateuserform/set 接口的请求。</para>
    /// </summary>
    public class CardMemberCardActivateUserFormSetRequest : WechatApiRequest, IInferable<CardMemberCardActivateUserFormSetRequest, CardMemberCardActivateUserFormSetResponse>
    {
        public static class Types
        {
            public class Statement
            {
                /// <summary>
                /// 获取或设置字段名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置字段 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;
            }

            public class Form
            {
                public static class Types
                {
                    public class RichField
                    {
                        /// <summary>
                        /// 获取或设置字段类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置字段名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置字段值列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public IList<string> Values { get; set; } = new List<string>();
                    }
                }

                /// <summary>
                /// 获取或设置是否允许用户激活后再次修改。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_modify")]
                [System.Text.Json.Serialization.JsonPropertyName("can_modify")]
                public bool? CanModify { get; set; }

                /// <summary>
                /// 获取或设置自定义富文本字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rich_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("rich_field_list")]
                public IList<Types.RichField>? RichFieldList { get; set; }

                /// <summary>
                /// 获取或设置内置字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_id_list")]
                public IList<string>? CommonFieldList { get; set; }

                /// <summary>
                /// 获取或设置自定义字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public IList<string>? CustomFieldList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务声明信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_statement")]
        [System.Text.Json.Serialization.JsonPropertyName("service_statement")]
        public Types.Statement? ServiceStatement { get; set; }

        /// <summary>
        /// 获取或设置绑定老会员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_old_card")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_old_card")]
        public Types.Statement? BindOldCard { get; set; }

        /// <summary>
        /// 获取或设置必填表单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("required_form")]
        [System.Text.Json.Serialization.JsonPropertyName("required_form")]
        public Types.Form? RequiredForm { get; set; }

        /// <summary>
        /// 获取或设置选填表单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("optional_form")]
        [System.Text.Json.Serialization.JsonPropertyName("optional_form")]
        public Types.Form? OptionalForm { get; set; }
    }
}
