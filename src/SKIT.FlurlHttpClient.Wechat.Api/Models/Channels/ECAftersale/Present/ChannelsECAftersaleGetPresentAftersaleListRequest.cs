namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/getpresentaftersalelist 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleGetPresentAftersaleListRequest : WechatApiRequest, IInferable<ChannelsECAftersaleGetPresentAftersaleListRequest, ChannelsECAftersaleGetPresentAftersaleListResponse>
    {
        /// <summary>
        /// 获取或设置创建时间开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_create_time")]
        public long StartCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置创建时间结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_create_time")]
        public long EndCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }
    }
}
