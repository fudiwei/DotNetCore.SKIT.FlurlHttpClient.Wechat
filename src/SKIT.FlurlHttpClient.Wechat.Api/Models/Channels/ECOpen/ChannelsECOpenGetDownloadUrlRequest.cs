namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/open/get_download_url 接口的请求。</para>
    /// </summary>
    public class ChannelsECOpenGetDownloadUrlRequest : WechatApiRequest, IInferable<ChannelsECOpenGetDownloadUrlRequest, ChannelsECOpenGetDownloadUrlResponse>
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
