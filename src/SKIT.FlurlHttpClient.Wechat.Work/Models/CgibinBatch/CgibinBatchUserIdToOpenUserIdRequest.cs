using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/batch/userid_to_openuserid 接口的请求。</para>
    /// </summary>
    public class CgibinBatchUserIdToOpenUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
        public IList<string> UserIdList { get; set; } = new List<string>();
    }
}
