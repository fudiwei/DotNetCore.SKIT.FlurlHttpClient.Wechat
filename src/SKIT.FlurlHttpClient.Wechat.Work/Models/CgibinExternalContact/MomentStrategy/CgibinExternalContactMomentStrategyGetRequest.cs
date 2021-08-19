using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/moment_strategy/get 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactMomentStrategyGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置规则组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy_id")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy_id")]
        public int StrategyId { get; set; }
    }
}
