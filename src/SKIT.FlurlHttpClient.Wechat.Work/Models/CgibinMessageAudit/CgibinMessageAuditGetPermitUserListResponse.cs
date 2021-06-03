using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/msgaudit/get_permit_user_list 接口的响应。</para>
    /// </summary>
    public class CgibinMessageAuditGetPermitUserListResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ids")]
        [System.Text.Json.Serialization.JsonPropertyName("ids")]
        public string[] UserIdList { get; set; } = default!;
    }
}
