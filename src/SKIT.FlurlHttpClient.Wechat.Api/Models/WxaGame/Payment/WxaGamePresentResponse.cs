namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/present 接口的响应。</para>
    /// </summary>
    public class WxaGamePresentResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置赠送游戏币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置赠送后的余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }
    }
}
