namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/favorites/count/get 接口的响应。</para>
    /// </summary>
    public class ECFavoritesCountGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置收藏用户数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favor_uv_acc_all")]
        [System.Text.Json.Serialization.JsonPropertyName("favor_uv_acc_all")]
        public int FavorUV { get; set; }

        /// <summary>
        /// 获取或设置店铺首页收藏用户数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favor_uv_acc_shop_homepage")]
        [System.Text.Json.Serialization.JsonPropertyName("favor_uv_acc_shop_homepage")]
        public int FavorShopHomepageUV { get; set; }

        /// <summary>
        /// 获取或设置订单详情页收藏用户数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favor_uv_acc_order_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("favor_uv_acc_order_detail")]
        public int FavorOrderDetailUV { get; set; }

        /// <summary>
        /// 获取或设置商品详情页收藏用户数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favor_uv_acc_product_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("favor_uv_acc_product_detail")]
        public int FavorProductDetailUV { get; set; }

        /// <summary>
        /// 获取或设置其他场景收藏用户数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favor_uv_acc_other_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("favor_uv_acc_other_scene")]
        public int FavorOtherSceneUV { get; set; }
    }
}
