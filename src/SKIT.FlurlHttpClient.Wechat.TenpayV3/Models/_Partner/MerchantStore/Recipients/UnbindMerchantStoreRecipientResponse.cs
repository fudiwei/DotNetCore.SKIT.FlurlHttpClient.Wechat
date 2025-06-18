namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-store/stores/{store_id}/recipients/unbind 接口的响应。</para>
    /// </summary>
    public class UnbindMerchantStoreRecipientResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Recipient : UnbindMerchantStoreRecipientRequest.Types.Recipient
            {
            }
        }

        /// <summary>
        /// 获取或设置解绑失败的门店收款信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_store_recipient")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_store_recipient")]
        public Types.Recipient[]? FailedRecipientList { get; set; }
    }
}
