namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/get_hide_sensitiveinfo_config 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataGetHideSensitiveInfoConfigResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Config : CgibinChatDataSetHideSensitiveInfoConfigRequest.Types.Config
            {
            }
        }

        /// <summary>
        /// 获取或设置配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config")]
        [System.Text.Json.Serialization.JsonPropertyName("config")]
        public Types.Config? Config { get; set; }
    }
}
