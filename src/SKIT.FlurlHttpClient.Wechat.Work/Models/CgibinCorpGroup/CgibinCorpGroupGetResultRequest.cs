using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/corpgroup/getresult 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupGetResultRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置异步任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string JobId { get; set; } = string.Empty;
    }
}
