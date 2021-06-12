using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /qualifications/delete 接口的请求。</para>
    /// </summary>
    public class QualificationsDeleteRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置资质 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_id")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_id")]
        public long QualificationId { get; set; }
    }
}
