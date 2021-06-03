using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_permanent_code 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetPermanentCodeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置临时授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_code")]
        public string TempAuthCode { get; set; } = string.Empty;
    }
}
