namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/scene/check 接口的请求。</para>
    /// </summary>
    public class ShopSceneCheckRequest : WechatApiRequest, IInferable<ShopSceneCheckRequest, ShopSceneCheckResponse>
    {
        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public int Scene { get; set; }
    }
}
