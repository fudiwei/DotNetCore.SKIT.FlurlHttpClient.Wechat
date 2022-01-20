using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_customized_auth_url 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetCustomizedAuthUrlRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置代开发自建应用模版 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("templateid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("templateid_list")]
        public IList<string> PermanentAuthCode { get; set; } = new List<string>();
    }
}
