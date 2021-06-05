using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/batch_to_external_userid 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactBatchToExternalUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置手机号码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobiles")]
        [System.Text.Json.Serialization.JsonPropertyName("mobiles")]
        public IList<string> MobileNumberList { get; set; } = new List<string>();
    }
}
