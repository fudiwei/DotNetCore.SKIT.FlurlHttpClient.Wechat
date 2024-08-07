namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/finder/sale/profile/data/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassFinderSaleProfileDataGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data : ChannelsECCompassShopSaleProfileDataGetResponse.Types.Data
            {
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
