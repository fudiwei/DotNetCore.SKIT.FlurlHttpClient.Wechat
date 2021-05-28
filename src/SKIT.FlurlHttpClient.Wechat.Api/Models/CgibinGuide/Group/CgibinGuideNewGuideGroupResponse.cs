using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/newguidegroup 接口的响应。</para>
    /// </summary>
    public class CgibinGuideNewGuideGroupResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置顾问分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public long GroupId { get; set; }
    }
}
