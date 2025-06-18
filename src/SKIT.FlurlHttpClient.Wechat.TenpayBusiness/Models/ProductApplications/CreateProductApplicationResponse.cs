namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/product-applications 接口的响应。</para>
    /// </summary>
    public class CreateProductApplicationResponse : WechatTenpayBusinessResponse
    {
        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付开户申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("request_no")]
        public string RequestNumber { get; set; } = default!;
    }
}
