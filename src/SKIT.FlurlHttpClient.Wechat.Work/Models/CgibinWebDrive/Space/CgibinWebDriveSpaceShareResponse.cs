using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/space_share 接口的响应。</para>
    /// </summary>
    public class CgibinWebDriveSpaceShareResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置邀请链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("space_share_url")]
        [System.Text.Json.Serialization.JsonPropertyName("space_share_url")]
        public string ShareUrl { get; set; } = default!;
    }
}
