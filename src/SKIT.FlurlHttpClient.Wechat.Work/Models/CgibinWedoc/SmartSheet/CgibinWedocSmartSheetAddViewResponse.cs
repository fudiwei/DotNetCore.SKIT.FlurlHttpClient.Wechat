namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/add_view 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetAddViewResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class View
            {
                /// <summary>
                /// 获取或设置视图 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_id")]
                [System.Text.Json.Serialization.JsonPropertyName("view_id")]
                public string ViewId { get; set; } = default!;

                /// <summary>
                /// 获取或设置视图名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_title")]
                [System.Text.Json.Serialization.JsonPropertyName("view_title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置视图类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_type")]
                [System.Text.Json.Serialization.JsonPropertyName("view_type")]
                public string Type { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置视图信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view")]
        [System.Text.Json.Serialization.JsonPropertyName("view")]
        public Types.View View { get; set; } = default!;
    }
}
