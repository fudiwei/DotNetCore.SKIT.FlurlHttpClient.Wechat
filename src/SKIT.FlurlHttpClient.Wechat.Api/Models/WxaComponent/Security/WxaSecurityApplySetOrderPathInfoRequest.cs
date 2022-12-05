using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/security/applysetorderpathinfo 接口的请求。</para>
    /// </summary>
    public class WxaSecurityApplySetOrderPathInfoRequest : WechatApiRequest, IInferable<WxaSecurityApplySetOrderPathInfoRequest, WxaSecurityApplySetOrderPathInfoResponse>
    {
        public static class Types
        {
            public class BatchRequest
            {
                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string PagePath { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序 AppId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("appid_list")]
                public IList<string>? AppIdList { get; set; }

                /// <summary>
                /// 获取或设置申请材料图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_list")]
                [System.Text.Json.Serialization.JsonPropertyName("img_list")]
                public IList<string>? ImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置申请材料视频 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public string? VideoUrl { get; set; }

                /// <summary>
                /// 获取或设置测试账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("test_account")]
                [System.Text.Json.Serialization.JsonPropertyName("test_account")]
                public string? TestAccount { get; set; }

                /// <summary>
                /// 获取或设置测试账号密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("test_pwd")]
                [System.Text.Json.Serialization.JsonPropertyName("test_pwd")]
                public string? TestPassword { get; set; }

                /// <summary>
                /// 获取或设置测试备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("test_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("test_remark")]
                public string? TestRemark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批量申请信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_req")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_req")]
        public Types.BatchRequest BatchRequest { get; set; } = new Types.BatchRequest();
    }
}
