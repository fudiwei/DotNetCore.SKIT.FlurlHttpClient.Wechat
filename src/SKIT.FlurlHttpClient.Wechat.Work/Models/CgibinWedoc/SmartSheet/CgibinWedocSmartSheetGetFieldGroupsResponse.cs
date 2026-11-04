namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/get_field_groups 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGetFieldGroupsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class FieldGroup : CgibinWedocSmartSheetAddFieldGroupResponse.Types.__zz__FieldGroup
            {
                public static class Types
                {
                    public class Field : CgibinWedocSmartSheetAddFieldGroupResponse.Types.FieldGroup.Types.Field
                    {
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
        /// 获取或设置编组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field_groups")]
        [System.Text.Json.Serialization.JsonPropertyName("field_groups")]
        public List<Types.FieldGroup>? FieldGroupList { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置下一页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next")]
        [System.Text.Json.Serialization.JsonPropertyName("next")]
        public int? NextOffset { get; set; }
    }
}
