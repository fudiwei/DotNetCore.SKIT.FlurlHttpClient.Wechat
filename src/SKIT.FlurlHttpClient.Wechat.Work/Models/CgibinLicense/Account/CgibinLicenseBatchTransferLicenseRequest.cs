using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/batch_transfer_license 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseBatchTransferLicenseRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Transfer
            {
                /// <summary>
                /// 获取或设置转移成员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("handover_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("handover_userid")]
                public string HandoverUserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置接收成员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("takeover_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("takeover_userid")]
                public string TakeoverUserId { get; set; } = string.Empty;
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
        /// 获取或设置转移列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_list")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_list")]
        public IList<Types.Transfer> TransferList { get; set; } = new List<Types.Transfer>();
    }
}
