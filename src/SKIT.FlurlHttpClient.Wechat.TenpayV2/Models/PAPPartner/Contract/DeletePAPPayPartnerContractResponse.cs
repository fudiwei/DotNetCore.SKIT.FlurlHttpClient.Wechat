namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/deletecontract 接口的响应。</para>
    /// </summary>
    public class DeletePAPPayPartnerContractResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string MerchantId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string AppId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置接口版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// 获取或设置签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_code")]
        public string ContractCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置委托代扣协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_id")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
        public string ContractId { get; set; } = default!;

        /// <summary>
        /// 获取或设置解约备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_termination_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_termination_remark")]
        public string TerminationRemark { get; set; } = default!;
    }
}
