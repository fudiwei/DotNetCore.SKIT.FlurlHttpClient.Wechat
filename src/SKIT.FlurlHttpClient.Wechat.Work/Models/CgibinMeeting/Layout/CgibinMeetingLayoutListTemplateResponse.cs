namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/meeting/layout/list_template 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingLayoutListTemplateResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class LayoutTemplate
            {
                /// <summary>
                /// 获取或设置布局模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("layout_template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("layout_template_id")]
                public string LayoutTemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置缩略图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumbnail_url")]
                [System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
                public string ThumbnailUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置布局图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("picture_url")]
                [System.Text.Json.Serialization.JsonPropertyName("picture_url")]
                public string PictureUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置渲染规则（JSON 格式）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("render_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("render_rule")]
                public string RenderRuleJson { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置布局模板列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_template_list")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_template_list")]
        public Types.LayoutTemplate[] LayoutTemplateList { get; set; } = default!;
    }
}
