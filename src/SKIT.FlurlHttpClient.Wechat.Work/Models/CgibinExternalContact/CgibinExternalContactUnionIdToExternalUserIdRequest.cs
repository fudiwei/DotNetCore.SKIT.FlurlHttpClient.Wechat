using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/unionid_to_external_userid 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactUnionIdToExternalUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置用户 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string UnionId { get; set; } = string.Empty;
    }
}
