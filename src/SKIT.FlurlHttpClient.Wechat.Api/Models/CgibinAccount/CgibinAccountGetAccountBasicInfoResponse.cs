using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/account/getaccountbasicinfo 接口的响应。</para>
    /// </summary>
    public class CgibinAccountGetAccountBasicInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Nickname
            {
                /// <summary>
                /// 获取或设置账号昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Value { get; set; } = default!;

                /// <summary>
                /// 获取或设置已使用修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_used_count")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_used_count")]
                public int UsedModifyCount { get; set; }

                /// <summary>
                /// 获取或设置修改次数总额度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_quota")]
                public int MaxModifyCount { get; set; }
            }

            public class HeadImage
            {
                /// <summary>
                /// 获取或设置账号头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_image_url")]
                public string Value { get; set; } = default!;

                /// <summary>
                /// 获取或设置已使用修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_used_count")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_used_count")]
                public int UsedModifyCount { get; set; }

                /// <summary>
                /// 获取或设置修改次数总额度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_quota")]
                public int MaxModifyCount { get; set; }
            }

            public class Signature
            {
                /// <summary>
                /// 获取或设置账号介绍。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("signature")]
                [System.Text.Json.Serialization.JsonPropertyName("signature")]
                public string Value { get; set; } = default!;

                /// <summary>
                /// 获取或设置已使用修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_used_count")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_used_count")]
                public int UsedModifyCount { get; set; }

                /// <summary>
                /// 获取或设置修改次数总额度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_quota")]
                public int MaxModifyCount { get; set; }
            }

            public class Verification
            {
                /// <summary>
                /// 获取或设置是否资质认证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_verify")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_verify")]
                public bool IsQualificationVerified { get; set; }

                /// <summary>
                /// 获取或设置是否名称认证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("naming_verify")]
                [System.Text.Json.Serialization.JsonPropertyName("naming_verify")]
                public bool IsNamingVerified { get; set; }

                /// <summary>
                /// 获取或设置是否需要年审。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("annual_review")]
                [System.Text.Json.Serialization.JsonPropertyName("annual_review")]
                public bool? IsAnnualReviewing { get; set; }

                /// <summary>
                /// 获取或设置年审开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("annual_review_begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("annual_review_begin_time")]
                public long? AnnualReviewBeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置年审截止时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("annual_review_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("annual_review_end_time")]
                public long? AnnualReviewEndTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置帐号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public int AccountType { get; set; }

        /// <summary>
        /// 获取或设置主体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("principal_type")]
        [System.Text.Json.Serialization.JsonPropertyName("principal_type")]
        public int PrincipalType { get; set; }

        /// <summary>
        /// 获取或设置主体名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("principal_name")]
        [System.Text.Json.Serialization.JsonPropertyName("principal_name")]
        public string PrincipalName { get; set; } = default!;

        /// <summary>
        /// 获取或设置主体标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("credential")]
        [System.Text.Json.Serialization.JsonPropertyName("credential")]
        public string PrincipalCredential { get; set; } = default!;

        /// <summary>
        /// 获取或设置实名认证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("realname_status")]
        [System.Text.Json.Serialization.JsonPropertyName("realname_status")]
        public int RealNameStatus { get; set; }

        /// <summary>
        /// 获取或设置注册国家代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_country")]
        [System.Text.Json.Serialization.JsonPropertyName("registered_country")]
        public int? RegisteredCountry { get; set; }

        /// <summary>
        /// 获取或设置昵称信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname_info")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname_info")]
        public Types.Nickname Nickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置头像信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_image_info")]
        [System.Text.Json.Serialization.JsonPropertyName("head_image_info")]
        public Types.HeadImage HeadImage { get; set; } = default!;

        /// <summary>
        /// 获取或设置介绍信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature_info")]
        [System.Text.Json.Serialization.JsonPropertyName("signature_info")]
        public Types.Signature Signature { get; set; } = default!;

        /// <summary>
        /// 获取或设置认证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_verify_info")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_verify_info")]
        public Types.Verification Verification { get; set; } = default!;
    }
}
