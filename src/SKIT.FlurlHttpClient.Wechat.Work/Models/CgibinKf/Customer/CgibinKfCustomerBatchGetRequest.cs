using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/customer/batchget 接口的请求。</para>
    /// </summary>
    public class CgibinKfCustomerBatchGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置外部联系人账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid_list")]
        public IList<string> ExternalUserIdList { get; set; } = new List<string>();
    }
}
