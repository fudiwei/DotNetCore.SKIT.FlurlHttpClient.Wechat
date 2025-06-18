namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/mng_pro_info 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveManageProfessionalInfoResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置是否是专业版。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_pro")]
        [System.Text.Json.Serialization.JsonPropertyName("is_pro")]
        public bool IsProfessional { get; set; }

        /// <summary>
        /// 获取或设置 VIP 账号总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_vip_acct_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_vip_acct_num")]
        public int TotalVipAccountCount { get; set; }

        /// <summary>
        /// 获取或设置 VIP 账号已使用数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_vip_acct_num")]
        [System.Text.Json.Serialization.JsonPropertyName("use_vip_acct_num")]
        public int UsedVipAccountCount { get; set; }

        /// <summary>
        /// 获取或设置专业版到期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pro_expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pro_expire_time")]
        public long? ProfessionalExpireTimestamp { get; set; }
    }
}
