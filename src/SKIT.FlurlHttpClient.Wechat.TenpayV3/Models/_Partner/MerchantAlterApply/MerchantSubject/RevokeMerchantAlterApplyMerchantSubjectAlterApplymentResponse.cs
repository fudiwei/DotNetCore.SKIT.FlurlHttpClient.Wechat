namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mchalterapply/mchsubjectalterapplyment/{apply_id}/revoke 接口的响应。</para>
    /// </summary>
    public class RevokeMerchantAlterApplyMerchantSubjectAlterApplymentResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置撤销状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;
    }
}
