namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/b2c/activity/info/promoter/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECB2CActivityInfoPromoterGetRequest : WechatApiRequest, IInferable<ChannelsECB2CActivityInfoPromoterGetRequest, ChannelsECB2CActivityInfoPromoterGetResponse>
    {
        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string ShopAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public long ActivityId { get; set; }
    }
}
