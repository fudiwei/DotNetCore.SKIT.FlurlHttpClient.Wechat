using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/vip/batch_del 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveVipBatchDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
        public IList<string> UserIdList { get; set; } = new List<string>();
    }
}
