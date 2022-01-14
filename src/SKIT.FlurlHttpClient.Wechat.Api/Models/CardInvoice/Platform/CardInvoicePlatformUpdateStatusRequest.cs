namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/platform/updatestatus 接口的请求。</para>
    /// </summary>
    public class CardInvoicePlatformUpdateStatusRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置发票或非税票据卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发票或非税票据卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string CardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发票或非税票据报销状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reimburse_status")]
        [System.Text.Json.Serialization.JsonPropertyName("reimburse_status")]
        public string SeimburseStatus { get; set; } = string.Empty;
    }
}
