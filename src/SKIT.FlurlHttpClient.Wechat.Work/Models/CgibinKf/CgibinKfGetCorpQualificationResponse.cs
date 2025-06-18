namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/kf/get_corp_qualification 接口的响应。</para>
    /// </summary>
    public class CgibinKfGetCorpQualificationResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置是否已绑定视频号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wechat_channels_binding")]
        [System.Text.Json.Serialization.JsonPropertyName("wechat_channels_binding")]
        public bool IsWechatChannelsBound { get; set; }
    }
}
