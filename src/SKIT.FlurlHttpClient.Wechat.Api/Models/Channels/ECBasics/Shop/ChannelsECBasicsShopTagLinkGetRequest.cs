namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/shop/taglink/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsShopTagLinkGetRequest : WechatApiRequest, IInferable<ChannelsECBasicsShopTagLinkGetRequest, ChannelsECBasicsShopTagLinkGetResponse>
    {
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
