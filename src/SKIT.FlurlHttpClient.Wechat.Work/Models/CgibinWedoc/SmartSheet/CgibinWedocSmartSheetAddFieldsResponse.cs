namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/add_fields 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetAddFieldsResponse : WechatWorkResponse
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
                public string FieldId { get; set; } = default!;

                /// <summary>
                /// 获取或设置字段名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_title")]
                [System.Text.Json.Serialization.JsonPropertyName("field_title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置字段类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_type")]
                [System.Text.Json.Serialization.JsonPropertyName("field_type")]
                public string Type { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fields")]
        [System.Text.Json.Serialization.JsonPropertyName("fields")]
        public Types.Field[] FieldList { get; set; } = default!;
    }
}
