using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/list_selected_ticket_user 接口的请求。</para>
    /// </summary>
    public class CgibinUserListSelectedTicketUserRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置选人 JSAPI 返回的 SelectedTicket。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SelectedTicket { get; set; } = string.Empty;
    }
}
