using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /adgroups/delete 接口的请求。</para>
    /// </summary>
    public class AdGroupsDeleteRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置广告组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adgroup_id")]
        [System.Text.Json.Serialization.JsonPropertyName("adgroup_id")]
        public long AdGroupId { get; set; }
    }
}
