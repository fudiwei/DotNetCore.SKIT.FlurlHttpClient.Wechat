using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/msgaudit/get_permit_user_list 接口的请求。</para>
    /// </summary>
    public class CgibinMessageAuditGetPermitUserListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }
    }
}
