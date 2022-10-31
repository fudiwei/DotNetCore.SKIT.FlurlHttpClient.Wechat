namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/auth/getuserdetail 接口的响应。</para>
    /// </summary>
    public class CgibinAuthGetUserDetailResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置成员 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置性别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gender")]
        [System.Text.Json.Serialization.JsonPropertyName("gender")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int Gender { get; set; }

        /// <summary>
        /// 获取或设置头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar")]
        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 获取或设置员工个人二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code")]
        [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
        public string? QrcodeUrl { get; set; }

        /// <summary>
        /// 获取或设置手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// 获取或设置邮箱地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 获取或设置企业邮箱地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_mail")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_mail")]
        public string? BusinessEmail { get; set; }

        /// <summary>
        /// 获取或设置地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }
    }
}
