namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/downloadbill 接口的响应。</para>
    /// </summary>
    public class DownloadPayBillResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <i>（请忽略此字段）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（请忽略此字段）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0;
        }
    }
}
