using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/convert_to_userid 接口的响应。</para>
    /// </summary>
    public class CgibinUserConvertToUserIdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置用户账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = default!;
    }
}
