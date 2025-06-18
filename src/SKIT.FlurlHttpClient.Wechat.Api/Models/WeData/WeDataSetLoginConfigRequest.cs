using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wedata/wedata_set_login_config 接口的请求。</para>
    /// </summary>
    public class WeDataSetLoginConfigRequest : WechatApiRequest, IInferable<WeDataSetLoginConfigRequest, WeDataSetLoginConfigResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设置类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("set_type")]
        [System.Text.Json.Serialization.JsonPropertyName("set_type")]
        public int SetType { get; set; }

        /// <summary>
        /// 获取或设置反查地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recheck_url")]
        [System.Text.Json.Serialization.JsonPropertyName("recheck_url")]
        public string? RecheckUrl { get; set; }

        /// <summary>
        /// 获取或设置关联小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("associate_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("associate_appid")]
        public IList<string>? AssociatedAppIdList { get; set; }
    }
}
