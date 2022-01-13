using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/update_contact_way 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactUpdateContactWayRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Conclusion : CgibinExternalContactAddContactWayRequest.Types.Conclusion
            {
            }
        }

        /// <summary>
        /// 获取或设置配置 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config_id")]
        [System.Text.Json.Serialization.JsonPropertyName("config_id")]
        public string ConfigId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置控件样式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("style")]
        [System.Text.Json.Serialization.JsonPropertyName("style")]
        public int? Style { get; set; }

        /// <summary>
        /// 获取或设置备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置是否无需验证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skip_verify")]
        [System.Text.Json.Serialization.JsonPropertyName("skip_verify")]
        public bool? IsSkipVerify { get; set; }

        /// <summary>
        /// 获取或设置企业自定义的渠道参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置使用该联系方式的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user")]
        [System.Text.Json.Serialization.JsonPropertyName("user")]
        public IList<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置使用该联系方式的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("party")]
        [System.Text.Json.Serialization.JsonPropertyName("party")]
        public IList<int>? DepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置是否临时会话模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_temp")]
        [System.Text.Json.Serialization.JsonPropertyName("is_temp")]
        public bool? IsTemp { get; set; }

        /// <summary>
        /// 获取或设置临时会话二维码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int? TempQrcodeExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置临时会话有效时间有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_expires_in")]
        public int? TempChatExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置可进行临时会话的客户 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        /// <summary>
        /// 获取或设置结束语信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conclusions")]
        [System.Text.Json.Serialization.JsonPropertyName("conclusions")]
        public Types.Conclusion? Conclusions { get; set; }
    }
}
