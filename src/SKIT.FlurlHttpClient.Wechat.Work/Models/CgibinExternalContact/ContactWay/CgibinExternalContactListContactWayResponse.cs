namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/list_contact_way 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactListContactWayResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ContactWay
            {
                /// <summary>
                /// 获取或设置配置 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("config_id")]
                [System.Text.Json.Serialization.JsonPropertyName("config_id")]
                public string ConfigId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置联系方式列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_way")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_way")]
        public Types.ContactWay[] ContactWayList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; } = default!;
    }
}
