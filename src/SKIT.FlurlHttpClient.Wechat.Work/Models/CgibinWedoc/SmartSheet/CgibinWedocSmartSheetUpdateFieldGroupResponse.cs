namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/update_field_group 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetUpdateFieldGroupResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class FieldGroup : CgibinWedocSmartSheetAddFieldGroupResponse.Types.FieldGroup
            {
            }
        }

        /// <summary>
        /// 获取或设置编组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field_group")]
        [System.Text.Json.Serialization.JsonPropertyName("field_group")]
        public Types.FieldGroup FieldGroup { get; set; } = default!;
    }
}
