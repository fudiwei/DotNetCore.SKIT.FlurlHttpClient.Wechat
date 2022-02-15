using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_strategy_tag_list 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGetStrategyTagListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置规则组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy_id")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy_id")]
        public int? StrategyId { get; set; }

        /// <summary>
        /// 获取或设置企业标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
        public IList<string>? TagIdList { get; set; }

        /// <summary>
        /// 获取或设置企业标签分组 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public IList<string>? TagGroupIdList { get; set; }
    }
}
