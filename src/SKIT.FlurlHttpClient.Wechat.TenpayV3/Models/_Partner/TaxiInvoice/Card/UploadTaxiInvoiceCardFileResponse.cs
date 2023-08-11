namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /taxi-invoice/cards/upload-file 接口的响应。</para>
    /// </summary>
    public class UploadTaxiInvoiceCardFileResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置发票文件 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_media_id")]
        public string InvoiceMediaId { get; set; } = default!;
    }
}
