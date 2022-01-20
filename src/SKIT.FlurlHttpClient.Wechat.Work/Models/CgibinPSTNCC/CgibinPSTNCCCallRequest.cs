using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/pstncc/call 接口的请求。</para>
    /// </summary>
    public class CgibinPSTNCCCallRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置呼叫的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callee_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("callee_userid")]
        public IList<string> CalleeUserIdList { get; set; } = new List<string>();
    }
}
