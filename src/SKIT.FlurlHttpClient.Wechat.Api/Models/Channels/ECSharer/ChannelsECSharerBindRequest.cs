namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/bind 接口的请求。</para>
    /// </summary>
    public class ChannelsECSharerBindRequest : WechatApiRequest, IInferable<ChannelsECSharerBindRequest, ChannelsECSharerBindResponse>
    {
        /// <summary>
        /// 获取或设置分享员微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;
    }
}
