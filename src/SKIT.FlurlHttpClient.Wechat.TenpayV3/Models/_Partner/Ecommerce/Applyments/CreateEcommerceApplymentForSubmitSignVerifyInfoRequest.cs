using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/applyments/submit-sign-verify-info 接口的请求。</para>
    /// </summary>
    public class CreateEcommerceApplymentForSubmitSignVerifyInfoRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ProxyVerifyIdentity
            {
                /// <summary>
                /// 获取或设置核身方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_identity_type")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_identity_type")]
                public string VerifyIdentityType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置核身结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_identity_result")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_identity_result")]
                public bool VerifyIdentityResult { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务申请编号。与字段 <see cref="ApplymentId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置申请单编号。与字段 <see cref="OutRequestNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public long? ApplymentId { get; set; }

        /// <summary>
        /// 获取或设置预签署微信支付协议时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_sign_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pre_sign_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? PresignTime { get; set; }

        /// <summary>
        /// 获取或设置平台代理核身信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("proxy_verify_identity_info")]
        [System.Text.Json.Serialization.JsonPropertyName("proxy_verify_identity_info")]
        public Types.ProxyVerifyIdentity? ProxyVerifyIdentity { get; set; }
    }
}
