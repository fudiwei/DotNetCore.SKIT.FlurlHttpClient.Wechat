using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /realtime_cost/get 接口的请求。</para>
    /// </summary>
    public class RealtimeCostGetRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置查询日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置类型级别。
        /// <para>默认值：ADGROUP</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Level { get; set; } = "ADGROUP";

        /// <summary>
        /// 获取或设置过滤条件。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<CommonFilter>? Filters { get; set; }
    }
}
