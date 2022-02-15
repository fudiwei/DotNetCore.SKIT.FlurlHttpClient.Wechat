using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/batchdelete 接口的请求。</para>
    /// </summary>
    public class CgibinUserBatchDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useridlist")]
        [System.Text.Json.Serialization.JsonPropertyName("useridlist")]
        public IList<string> UserIdList { get; set; } = new List<string>();
    }
}
