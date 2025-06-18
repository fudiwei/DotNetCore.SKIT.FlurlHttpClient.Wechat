using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/unbind 接口的请求。</para>
    /// </summary>
    public class ShopSharerUnbindRequest : WechatApiRequest, IInferable<ShopSharerUnbindRequest, ShopSharerUnbindResponse>
    {
        /// <summary>
        /// 获取或设置分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openids")]
        [System.Text.Json.Serialization.JsonPropertyName("openids")]
        public IList<string> OpenIdList { get; set; } = new List<string>();
    }
}
