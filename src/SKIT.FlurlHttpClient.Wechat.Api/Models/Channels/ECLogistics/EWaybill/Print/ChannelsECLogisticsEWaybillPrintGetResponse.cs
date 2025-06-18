namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/print/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillPrintGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置打印报文信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("print_info")]
        [System.Text.Json.Serialization.JsonPropertyName("print_info")]
        public string? PrintInfo { get; set; } = default!;
    }
}
