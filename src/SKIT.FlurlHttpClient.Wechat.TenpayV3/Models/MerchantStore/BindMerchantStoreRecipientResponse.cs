namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-store/stores/{store_id}/recipients/bind 接口的响应。</para>
    /// </summary>
    public class BindMerchantStoreRecipientResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Recipient : BindMerchantStoreRecipientRequest.Types.Recipient
            {
            }
        }

        /// <summary>
        /// 获取或设置绑定失败的门店收款信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_store_recipient")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_store_recipient")]
        public Types.Recipient[]? FailedRecipientList { get; set; }
    }
}
