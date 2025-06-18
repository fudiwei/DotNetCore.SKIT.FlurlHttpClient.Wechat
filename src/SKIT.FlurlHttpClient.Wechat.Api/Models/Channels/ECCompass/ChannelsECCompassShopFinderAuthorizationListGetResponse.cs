namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/finder/authorization/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopFinderAuthorizationListGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置主营视频号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("main_finder_id")]
        public string MainFinderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权视频号 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorized_finder_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("authorized_finder_id_list")]
        public string[]? AuthorizedFinderIdList { get; set; }
    }
}
