namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/novelreader/getpreviewsetting 接口的响应。</para>
    /// </summary>
    public class WxaBusinessNovelReaderGetPreviewSettingsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Settings : WxaBusinessNovelReaderSetPreviewSettingsRequest.Types.__zz__Settings
            {
                public static class Types
                {
                    public class Chapter : WxaBusinessNovelReaderSetPreviewSettingsRequest.Types.Settings.Types.Chapter
                    {
                    }
                }

                /// <summary>
                /// 获取或设置章节列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chapter_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("chapter_setting")]
                public List<Types.Chapter>? ChapterList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置预览设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("setting")]
        [System.Text.Json.Serialization.JsonPropertyName("setting")]
        public Types.Settings? Settings { get; set; }
    }
}
