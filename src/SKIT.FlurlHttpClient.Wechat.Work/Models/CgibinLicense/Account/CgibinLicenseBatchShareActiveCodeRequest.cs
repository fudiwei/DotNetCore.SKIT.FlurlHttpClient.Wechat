using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/batch_share_active_code 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseBatchShareActiveCodeRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Share
            {
                /// <summary>
                /// 获取或设置账号激活码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_code")]
                [System.Text.Json.Serialization.JsonPropertyName("active_code")]
                public string ActiveCode { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上游企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("from_corpid")]
        public string FromCorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下游企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("to_corpid")]
        public string ToCorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置转移列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_list")]
        [System.Text.Json.Serialization.JsonPropertyName("share_list")]
        public IList<Types.Share> ShareList { get; set; } = new List<Types.Share>();
    }
}
