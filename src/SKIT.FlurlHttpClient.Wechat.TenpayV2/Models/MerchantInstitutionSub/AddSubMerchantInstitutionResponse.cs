namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /secapi/mch/addInstitutionsub 接口的响应。</para>
    /// </summary>
    public class AddSubMerchantInstitutionResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerhantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置验证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verification_status")]
        [System.Text.Json.Serialization.JsonPropertyName("verification_status")]
        public string? VerificationStatus { get; set; }

        /// <summary>
        /// 获取或设置验证状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? VerificationStatusDescription { get; set; }
    }
}
