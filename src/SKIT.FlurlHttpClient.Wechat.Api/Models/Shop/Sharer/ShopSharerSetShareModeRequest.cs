namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/set_share_mode 接口的请求。</para>
    /// </summary>
    public class ShopSharerSetShareModeRequest : WechatApiRequest, IInferable<ShopSharerSetShareModeRequest, ShopSharerSetShareModeResponse>
    {
        /// <summary>
        /// 获取或设置分享模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("share_mode")]
        public int ShareMode { get; set; }
    }
}
