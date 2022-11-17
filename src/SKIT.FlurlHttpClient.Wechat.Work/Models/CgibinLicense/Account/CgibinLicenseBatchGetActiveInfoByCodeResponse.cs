namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/batch_get_active_info_by_code 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseBatchGetActiveInfoByCodeResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ActiveInfo : CgibinLicenseGetActiveInfoByCodeResponse.Types.ActiveInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置账号激活列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("active_info_list")]
        public Types.ActiveInfo[] ActiveList { get; set; } = default!;

        /// <summary>
        /// 获取或设置无效的激活码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_active_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_active_code_list")]
        public string[] InvalidActiveCodeList { get; set; } = default!;
    }
}
