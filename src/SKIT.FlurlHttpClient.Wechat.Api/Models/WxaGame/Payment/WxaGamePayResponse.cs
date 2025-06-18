namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/pay 接口的响应。</para>
    /// </summary>
    public class WxaGamePayResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置扣除游戏币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置预扣后的余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// 获取或设置本次扣除的赠送币的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("used_present_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("used_present_amount")]
        public int UsedPresentAmount { get; set; }
    }
}
