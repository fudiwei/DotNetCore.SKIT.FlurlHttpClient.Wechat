namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getuserriskrank 接口的请求。</para>
    /// </summary>
    public class WxaGetUserRiskRankRequest : WechatApiRequest, IInferable<WxaGetUserRiskRankRequest, WxaGetUserRiskRankResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public int Scene { get; set; }

        /// <summary>
        /// 获取或设置用户访问源 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("client_ip")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// 获取或设置用户邮箱地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email_address")]
        [System.Text.Json.Serialization.JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// 获取或设置用户手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile_no")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile_no")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// 获取或设置银行卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_card_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_card_no")]
        public string? BankCardNumber { get; set; }

        /// <summary>
        /// 获取或设置证书编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_no")]
        public string? CertificateNumber { get; set; }

        /// <summary>
        /// 获取或设置额外补充信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extended_info")]
        [System.Text.Json.Serialization.JsonPropertyName("extended_info")]
        public string? ExtendedInformation { get; set; }

        /// <summary>
        /// 获取或设置是否是测试调用。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_test")]
        [System.Text.Json.Serialization.JsonPropertyName("is_test")]
        public bool? IsTest { get; set; }
    }
}
