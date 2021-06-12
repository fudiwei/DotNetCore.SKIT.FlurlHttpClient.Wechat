using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /ads/delete 接口的请求。</para>
    /// </summary>
    public class AdsDeleteRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置广告 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
        public long AdId { get; set; }
    }
}
