using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/living/get_living_code 接口的响应。</para>
    /// </summary>
    public class CgibinLivingGetLivingCodeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置微信观看直播凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("living_code")]
        [System.Text.Json.Serialization.JsonPropertyName("living_code")]
        public string LivingCode { get; set; } = default!;
    }
}
