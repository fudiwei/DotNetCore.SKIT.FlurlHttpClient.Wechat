using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/getVideo 接口的响应。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsGetVideoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置讲解视频 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string VideoUrl { get; set; } = default!;
    }
}
