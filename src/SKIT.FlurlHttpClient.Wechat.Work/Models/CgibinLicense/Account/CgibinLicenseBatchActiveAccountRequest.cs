using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/batch_active_account 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseBatchActiveAccountRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Account
            {
                /// <summary>
                /// 获取或设置账号激活码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_code")]
                [System.Text.Json.Serialization.JsonPropertyName("active_code")]
                public string ActiveCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置待绑定激活的成员 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置激活账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_list")]
        [System.Text.Json.Serialization.JsonPropertyName("active_list")]
        public IList<Types.Account> AccountList { get; set; } = new List<Types.Account>();
    }
}
