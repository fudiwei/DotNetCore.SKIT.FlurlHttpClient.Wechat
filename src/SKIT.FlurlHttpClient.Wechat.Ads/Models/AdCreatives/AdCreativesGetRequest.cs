using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /adcreatives/get 接口的请求。</para>
    /// </summary>
    public class AdCreativesGetRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置广告创意 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? AdCreativeId { get; set; }

        /// <summary>
        /// 获取或设置过滤条件。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<Abstractions.CommonFilter>? Filters { get; set; }

        /// <summary>
        /// 获取或设置页大小。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? PageSize { get; set; }

        /// <summary>
        /// 获取或设置页码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Page { get; set; }
    }
}
