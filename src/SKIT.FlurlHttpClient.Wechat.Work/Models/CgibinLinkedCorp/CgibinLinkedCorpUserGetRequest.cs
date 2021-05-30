using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/user/get 接口的请求。</para>
    /// </summary>
    public class CgibinLinkedCorpUserGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置互联企业成员账号（格式："CorpId/UserId"）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string CorpUserId { get; set; } = string.Empty;
    }
}
