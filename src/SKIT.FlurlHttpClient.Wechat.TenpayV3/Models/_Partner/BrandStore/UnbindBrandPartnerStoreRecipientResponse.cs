namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/partner/store/brandstores/{store_id}/unbindrecipient 接口的响应。</para>
    /// </summary>
    public class UnbindBrandPartnerStoreRecipientResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置解绑失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        public string? FailedReason { get; set; }
    }
}
