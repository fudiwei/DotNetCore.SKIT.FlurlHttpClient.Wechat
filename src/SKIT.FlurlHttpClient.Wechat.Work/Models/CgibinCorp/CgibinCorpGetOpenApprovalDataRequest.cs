using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corp/getopenapprovaldata 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGetOpenApprovalDataRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置第三方审批单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdNo")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdNo")]
        public string ThirdPartyApprovalNumber { get; set; } = string.Empty;
    }
}
