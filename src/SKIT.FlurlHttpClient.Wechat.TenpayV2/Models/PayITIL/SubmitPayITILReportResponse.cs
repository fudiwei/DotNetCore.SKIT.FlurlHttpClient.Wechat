namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /payitil/report 接口的响应。</para>
    /// </summary>
    public class SubmitPayITILReportResponse : WechatTenpaySignableResponse
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
    }
}
