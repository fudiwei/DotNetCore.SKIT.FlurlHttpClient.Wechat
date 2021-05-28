using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/gamematch/setmatchopenstate 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGameMatchSetMatchOpenStateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置匹配池对应的 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("match_id")]
        [System.Text.Json.Serialization.JsonPropertyName("match_id")]
        public string MatchId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置打开状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_state")]
        [System.Text.Json.Serialization.JsonPropertyName("open_state")]
        public int OpenState { get; set; }
    }
}
