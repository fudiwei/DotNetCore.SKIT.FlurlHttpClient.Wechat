namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [GET] /papay/contracts/out-contract-code/{out_contract_code} 接口的响应。</para>
    /// </summary>
    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models." + nameof(GetPAPayContractByOutContractCodeResponse))]
    public class GetPartnerPAPayContractByOutContractCodeResponse : GetPAPayContractByOutContractCodeResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public new string? MerchantId
        {
            get { return base.MerchantId; }
            set { base.MerchantId = value; }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public new string? AppId
        {
            get { return base.AppId; }
            set { base.AppId = value; }
        }

        /// <summary>
        /// 获取或设置子商户微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }
    }
}
