namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/no_worry_return/unbind 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliveryNoWorryReturnUnbindRequest : WechatApiRequest, IInferable<CgibinExpressDeliveryNoWorryReturnUnbindRequest, CgibinExpressDeliveryNoWorryReturnUnbindResponse>
    {
        /// <summary>
        /// 获取或设置退货单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_id")]
        [System.Text.Json.Serialization.JsonPropertyName("return_id")]
        public string ReturnId { get; set; } = string.Empty;
    }
}
