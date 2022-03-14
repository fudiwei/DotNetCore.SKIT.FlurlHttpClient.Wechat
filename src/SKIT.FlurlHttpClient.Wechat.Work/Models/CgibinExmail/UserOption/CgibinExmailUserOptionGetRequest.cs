using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/useroption/get 接口的请求。</para>
    /// </summary>
    public class CgibinExmailUserOptionGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置功能设置属性类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public IList<int> TypeList { get; set; } = new List<int>();
    }
}
