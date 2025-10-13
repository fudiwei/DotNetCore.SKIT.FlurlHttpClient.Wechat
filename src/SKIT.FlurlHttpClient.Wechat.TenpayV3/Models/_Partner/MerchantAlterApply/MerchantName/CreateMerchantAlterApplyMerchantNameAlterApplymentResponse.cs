namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mchalterapply/merchantnamealterapplyment 接口的响应。</para>
    /// </summary>
    public class CreateMerchantAlterApplyMerchantNameAlterApplymentResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
        public string ApplymentId { get; set; } = default!;
    }
}
