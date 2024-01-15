namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxadrama/setplayerdramarecmdswitch 接口的请求。</para>
    /// </summary>
    public class WxaDramaSetPlayerDramaRecommendSwitchRequest : WechatApiRequest, IInferable<WxaDramaSetPlayerDramaRecommendSwitchRequest, WxaDramaSetPlayerDramaRecommendSwitchResponse>
    {
        /// <summary>
        /// 获取或设置推荐位类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entry_type")]
        [System.Text.Json.Serialization.JsonPropertyName("entry_type")]
        public int EntryType { get; set; }

        /// <summary>
        /// 获取或设置是否打开。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("switch_status")]
        [System.Text.Json.Serialization.JsonPropertyName("switch_status")]
        public bool IsOpen { get; set; }
    }
}
