using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/create_renew_order_job 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseCreateRenewOrderJobRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Account
            {
                /// <summary>
                /// 获取或设置续期企业的成员 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置续期账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }
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
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string? JobId { get; set; }

        /// <summary>
        /// 获取或设置续期的账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_list")]
        [System.Text.Json.Serialization.JsonPropertyName("account_list")]
        public IList<Types.Account> AccountList { get; set; } = new List<Types.Account>();
    }
}
