namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/cancelpay 接口的响应。</para>
    /// </summary>
    public class WxaGameCancelPayResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置退回游戏币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = default!;
    }
}
