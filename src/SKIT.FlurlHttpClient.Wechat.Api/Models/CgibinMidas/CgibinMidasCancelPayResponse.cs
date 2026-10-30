namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/cancelpay 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-11-05 下线。")]
    public class CgibinMidasCancelPayResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string? BillNumber { get; set; }
    }
}
