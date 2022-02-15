using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/fastregisterweapp?action=create 接口的请求。</para>
    /// </summary>
    public class CgibinComponentFastRegisterWeappCreateRequest : WechatApiRequest, IMapResponse<CgibinComponentFastRegisterWeappCreateRequest, CgibinComponentFastRegisterWeappCreateResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string EnterpriseName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string LicenseNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业代码类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_type")]
        [System.Text.Json.Serialization.JsonPropertyName("code_type")]
        public int LicenseType { get; set; }

        /// <summary>
        /// 获取或设置法人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_persona_name")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_persona_name")]
        public string LegalPersonName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_persona_wechat")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_persona_wechat")]
        public string LegalPersonWxname { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置第三方联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("component_phone")]
        public string? ComponentPhoneNumber { get; set; }
    }
}
