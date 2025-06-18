namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/shop/qrcode/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsShopQrcodeGetRequest : WechatApiRequest, IInferable<ChannelsECBasicsShopQrcodeGetRequest, ChannelsECBasicsShopQrcodeGetResponse>
    {
        /// <summary>
        /// 获取或设置二维码类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_type")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_type")]
        public int QrcodeType { get; set; }

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
