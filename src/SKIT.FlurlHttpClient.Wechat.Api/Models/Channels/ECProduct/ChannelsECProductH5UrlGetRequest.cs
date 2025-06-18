namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/h5url/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductH5UrlGetRequest : WechatApiRequest, IInferable<ChannelsECProductH5UrlGetRequest, ChannelsECProductH5UrlGetResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置企业微信 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wecom_corp_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wecom_corp_id")]
        public string? WecomCorpId { get; set; }

        /// <summary>
        /// 获取或设置企业微信账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wecom_user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wecom_user_id")]
        public string? WecomUserId { get; set; }
    }
}
