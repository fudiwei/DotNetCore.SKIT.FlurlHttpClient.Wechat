namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/get_app_license_info 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseGetAppLicenseInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class TrailInfo
            {
                /// <summary>
                /// 获取或设置试用开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置试用到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置接口许可状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license_status")]
        [System.Text.Json.Serialization.JsonPropertyName("license_status")]
        public int LicenseStatus { get; set; }

        /// <summary>
        /// 获取或设置试用期信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trail_info")]
        [System.Text.Json.Serialization.JsonPropertyName("trail_info")]
        public Types.TrailInfo? TrailInfo { get; set; }
    }
}
