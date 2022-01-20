using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/batch_delete_parent 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserBatchDeleteParentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置家长账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useridlist")]
        [System.Text.Json.Serialization.JsonPropertyName("useridlist")]
        public IList<string> ParentUserIdList { get; set; } = new List<string>();
    }
}
