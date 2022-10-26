using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/security/get_privacy_interface 接口的响应。</para>
    /// </summary>
    public class WxaSecurityGetPrivacyInterfaceResponse : WechatApiResponse
    {
        public class Types
        {
            public class PrivacyInterface
            {
                /// <summary>
                /// 获取或设置 API 英文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("api_name")]
                [System.Text.Json.Serialization.JsonPropertyName("api_name")]
                public string ApiName { get; set; } = default!;

                /// <summary>
                /// 获取或设置 API 中文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("api_ch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("api_ch_name")]
                public string ApiChineseName { get; set; } = default!;

                /// <summary>
                /// 获取或设置 API 描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("api_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("api_desc")]
                public string ApiDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置 API 文档链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("api_link")]
                [System.Text.Json.Serialization.JsonPropertyName("api_link")]
                public string? ApiLink { get; set; }

                /// <summary>
                /// 获取或设置分组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_name")]
                [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                public string? GroupName { get; set; }

                /// <summary>
                /// 获取或设置申请单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_id")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
                public long? AuditId { get; set; }

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int? Status { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                public long? ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置申请被驳回原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                public string? FailReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置隐私接口列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interface_list")]
        [System.Text.Json.Serialization.JsonPropertyName("interface_list")]
        public Types.PrivacyInterface[] PrivacyInterfaceList { get; set; } = default!;
    }
}
