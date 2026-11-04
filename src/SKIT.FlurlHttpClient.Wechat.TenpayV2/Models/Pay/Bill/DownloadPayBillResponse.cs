namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/downloadbill 接口的响应。</para>
    /// </summary>
    public class DownloadPayBillResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <remarks><i>（冗余字段，请忽略）</i></remarks>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <remarks><i>（冗余字段，请忽略）</i></remarks>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawHeaders().ContainsKey(HttpHeaders.ContentDisposition);
        }
    }
}
