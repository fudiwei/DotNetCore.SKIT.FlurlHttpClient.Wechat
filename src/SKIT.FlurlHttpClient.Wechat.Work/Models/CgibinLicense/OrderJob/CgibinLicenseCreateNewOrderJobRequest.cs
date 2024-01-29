using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/create_new_order_job 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseCreateNewOrderJobRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Buy
            {
                public static class Types
                {
                    public class AccountCount : CgibinLicenseCreateNewOrderRequest.Types.AccountCount
                    {
                    }

                    public class AccountDuration : CgibinLicenseCreateNewOrderRequest.Types.AccountDuration
                    {
                    }
                }

                /// <summary>
                /// 获取或设置企业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string CorpId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置账号个数信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_count")]
                [System.Text.Json.Serialization.JsonPropertyName("account_count")]
                public Types.AccountCount AccountCount { get; set; } = new Types.AccountCount();

                /// <summary>
                /// 获取或设置账号时长信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("account_duration")]
                public Types.AccountDuration AccountDuration { get; set; } = new Types.AccountDuration();

                /// <summary>
                /// 获取或设置是否自动激活。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_active_status")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("auto_active_status")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool? IsAutoActive { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置多企业新购任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string? JobId { get; set; }

        /// <summary>
        /// 获取或设置多企业购买信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buy_list")]
        [System.Text.Json.Serialization.JsonPropertyName("buy_list")]
        public IList<Types.Buy> BuyList { get; set; } = new List<Types.Buy>();
    }
}
