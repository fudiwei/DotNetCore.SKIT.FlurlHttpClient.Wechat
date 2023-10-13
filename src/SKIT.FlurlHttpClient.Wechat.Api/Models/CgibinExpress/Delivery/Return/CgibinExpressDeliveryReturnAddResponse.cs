namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/return/add 接口的响应。</para>
    /// </summary>
    public class CgibinExpressDeliveryReturnAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置退货单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_id")]
        [System.Text.Json.Serialization.JsonPropertyName("return_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        public string ReturnId { get; set; } = default!;
    }
}
