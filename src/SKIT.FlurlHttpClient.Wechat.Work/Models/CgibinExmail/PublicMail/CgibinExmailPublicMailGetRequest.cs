using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/publicmail/get 接口的请求。</para>
    /// </summary>
    public class CgibinExmailPublicMailGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置业务邮箱 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
        public IList<int> IdList { get; set; } = new List<int>();
    }
}
