using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/prolong_try 接口的请求。</para>
    /// </summary>
    public class CgibinServiceProlongTryRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置购买方 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_corpid")]
        public string BuyerCorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置延长天数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prolong_days")]
        [System.Text.Json.Serialization.JsonPropertyName("prolong_days")]
        public int ProlongDays { get; set; }

        /// <summary>
        /// 获取或设置第三方套件应用 ID。
        /// </summary>
        [Obsolete("相关接口或字段于 2020-01-13 下线。")]
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public int? AppId { get; set; }
    }
}
