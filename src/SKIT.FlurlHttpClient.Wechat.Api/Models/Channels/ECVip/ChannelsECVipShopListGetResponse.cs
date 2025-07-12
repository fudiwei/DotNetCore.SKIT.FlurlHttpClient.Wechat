namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/shop/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipShopListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ShopInfo
            {
                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                public string ShopAppId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置已关联的小店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.ShopInfo[] ShopList { get; set; } = default!;
    }
}
