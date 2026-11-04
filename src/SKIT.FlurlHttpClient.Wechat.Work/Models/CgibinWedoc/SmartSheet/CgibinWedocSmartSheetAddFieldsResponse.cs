namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/add_fields 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetAddFieldsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Field : CgibinWedocSmartSheetAddFieldsRequest.Types.__zz__Field
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
        [Newtonsoft.Json.JsonProperty("fields")]
        [System.Text.Json.Serialization.JsonPropertyName("fields")]
        public List<Types.Field>? FieldList { get; set; }
    }
}
