using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/chatid 接口的请求。</para>
    /// </summary>
    public class CgibinIdConvertChatIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置群聊 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_id_list")]
        public IList<string> GroupChatIdList { get; set; } = new List<string>();
    }
}
