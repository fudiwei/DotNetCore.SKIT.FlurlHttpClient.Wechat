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

        /// <summary>
        /// 获取或设置是否需要返回客户最后一次进入会话的上下文信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_enter_session_context")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_enter_session_context")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? RequireEnterSessionContext { get; set; }
    }
}
