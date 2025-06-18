﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/delguide2guidegroup 接口的请求。</para>
    /// </summary>
    public class CgibinGuideDeleteGuide2GuideGroupRequest : WechatApiRequest, IInferable<CgibinGuideDeleteGuide2GuideGroupRequest, CgibinGuideDeleteGuide2GuideGroupResponse>
    {
        /// <summary>
        /// 获取或设置顾问分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 获取或设置顾问微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_account")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_account")]
        public string GuideAccount { get; set; } = string.Empty;
    }
}
