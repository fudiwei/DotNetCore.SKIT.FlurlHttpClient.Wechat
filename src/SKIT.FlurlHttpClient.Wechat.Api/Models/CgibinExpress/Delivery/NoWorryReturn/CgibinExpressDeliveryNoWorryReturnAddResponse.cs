namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/no_worry_return/add 接口的响应。</para>
    /// </summary>
    public class CgibinExpressDeliveryNoWorryReturnAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置退货单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_id")]
        [System.Text.Json.Serialization.JsonPropertyName("return_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public string ReturnId { get; set; } = default!;
    }
}
