namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/add_field_group 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetAddFieldGroupResponse : WechatWorkResponse
    {
        public static class Types
        {
            public abstract class __zz__FieldGroup
            {
                /// <summary>
                /// 获取或设置编组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("field_group_id")]
                public string? FieldGroupId { get; set; }

                /// <summary>
                /// 获取或设置编组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }
            }

            public class FieldGroup : __zz__FieldGroup
            {
                public static class Types
                {
                    public class Field
                    {
                        /// <summary>
                        /// 获取或设置字段 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_id")]
                        public string? FieldId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("children")]
                [System.Text.Json.Serialization.JsonPropertyName("children")]
                public List<Types.Field>? FieldList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置编组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field_group")]
        [System.Text.Json.Serialization.JsonPropertyName("field_group")]
        public Types.FieldGroup? FieldGroup { get; set; }
    }
}
