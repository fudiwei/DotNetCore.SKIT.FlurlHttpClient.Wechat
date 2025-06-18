namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/getuserdetail3rd 接口的响应。</para>
    /// </summary>
    public class CgibinServiceUserDetail3rdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置用户所属企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户所在企业内的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置成员名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置性别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gender")]
        [System.Text.Json.Serialization.JsonPropertyName("gender")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
        public int? Gender { get; set; }

        /// <summary>
        /// 获取或设置头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar")]
        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 获取或设置二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code")]
        [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
        public string? QrcodeUrl { get; set; }
    }
}
