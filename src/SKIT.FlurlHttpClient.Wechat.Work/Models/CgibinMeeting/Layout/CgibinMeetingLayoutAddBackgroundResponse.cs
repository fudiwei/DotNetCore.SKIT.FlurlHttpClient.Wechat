namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/layout/add_background 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingLayoutAddBackgroundResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class BackgroundImage : CgibinMeetingLayoutListBackgroundResponse.Types.BackgroundImage
            {
            }
        }

        /// <summary>
        /// 获取或设置会议应用的背景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selected_background_id")]
        [System.Text.Json.Serialization.JsonPropertyName("selected_background_id")]
        public string SelectedBackgroundId { get; set; } = default!;

        /// <summary>
        /// 获取或设置背景图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_list")]
        [System.Text.Json.Serialization.JsonPropertyName("background_list")]
        public Types.BackgroundImage[] BackgroundImageList { get; set; } = default!;
    }
}
