using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/batch_get_active_info_by_code 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseBatchGetActiveInfoByCodeRequest : WechatWorkRequest
    {
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
        /// 获取或设置账号激活码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("active_code_list")]
        public IList<string> ActiveCodeList { get; set; } = new List<string>();
    }
}
