using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/servicer/add 接口的请求。</para>
    /// </summary>
    public class CgibinKfServicerAddRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客服账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_kfid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
        public string OpenKfId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接待人员的 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
        public IList<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置接待人员的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("department_id_list")]
        public IList<long>? DepartmentIdList { get; set; }
    }
}
