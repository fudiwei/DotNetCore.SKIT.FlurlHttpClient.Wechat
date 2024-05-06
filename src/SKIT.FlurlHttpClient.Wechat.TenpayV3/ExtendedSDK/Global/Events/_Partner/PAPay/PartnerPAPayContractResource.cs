namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Events
{
    /// <summary>
    /// <para>表示 PAPAY.SIGN （仅限服务商）通知的数据。</para>
    /// <para>表示 PAPAY.TERMINATE （仅限服务商）通知的数据。</para>
    /// </summary>
    public class PartnerPAPayContractResource : PAPayContractResource, WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// <inheritdoc />
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public override string MerchantId { get; set; } = default!;

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public override string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string SubAppId { get; set; } = default!;
    }
}
