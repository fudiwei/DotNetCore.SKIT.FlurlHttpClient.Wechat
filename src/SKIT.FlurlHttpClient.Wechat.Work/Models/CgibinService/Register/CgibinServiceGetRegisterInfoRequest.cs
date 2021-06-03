using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/service/get_register_info 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetRegisterInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注册码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("register_code")]
        [System.Text.Json.Serialization.JsonPropertyName("register_code")]
        public string RegisterCode { get; set; } = string.Empty;
    }
}
