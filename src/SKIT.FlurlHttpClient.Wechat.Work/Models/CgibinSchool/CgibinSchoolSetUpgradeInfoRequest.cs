using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/set_upgrade_info 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolSetUpgradeInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置是否自动升年级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upgrade_switch")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("upgrade_switch")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool UpgradeSwitch { get; set; }

        /// <summary>
        /// 获取或设置自动升年级的时间戳（仅月日有效）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upgrade_time")]
        [System.Text.Json.Serialization.JsonPropertyName("upgrade_time")]
        public long? UpgradeTimestamp { get; set; }
    }
}
