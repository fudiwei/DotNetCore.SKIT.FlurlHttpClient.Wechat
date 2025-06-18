namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/get_active_info_by_user 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseGetActiveInfoByUserResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Account : CgibinLicenseListActivedAccountResponse.Types.Account
            {
                /// <summary>
                /// 获取或设置账号激活码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_code")]
                [System.Text.Json.Serialization.JsonPropertyName("active_code")]
                public string ActiveCode { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置激活状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_status")]
        [System.Text.Json.Serialization.JsonPropertyName("active_status")]
        public int ActiveStatus { get; set; }

        /// <summary>
        /// 获取或设置账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("active_info_list")]
        public Types.Account[] AccountList { get; set; } = default!;
    }
}
