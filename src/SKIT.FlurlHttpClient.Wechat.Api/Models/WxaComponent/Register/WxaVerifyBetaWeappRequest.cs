namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/verifybetaweapp 接口的请求。</para>
    /// </summary>
    public class WxaVerifyBetaWeappRequest : WechatApiRequest, IInferable<WxaVerifyBetaWeappRequest, WxaVerifyBetaWeappResponse>
    {
        public static class Types
        {
            public class Verification
            {
                /// <summary>
                /// 获取或设置小程序名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enterprise_name")]
                [System.Text.Json.Serialization.JsonPropertyName("enterprise_name")]
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
                /// 获取或设置法人身份证号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_persona_idcard")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_persona_idcard")]
                public string LegalPersonIdCardNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置第三方联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("component_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("component_phone")]
                public string ComponentName { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置验证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_info")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_info")]
        public Types.Verification Verification { get; set; } = new Types.Verification();
    }
}
