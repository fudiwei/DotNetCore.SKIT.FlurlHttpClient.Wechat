using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/living/get_user_all_livingid 接口的响应。</para>
    /// </summary>
    public class CgibinLivingGetUserAllLivingIdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置直播 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("livingid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("livingid_list")]
        public string[] LivingIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
