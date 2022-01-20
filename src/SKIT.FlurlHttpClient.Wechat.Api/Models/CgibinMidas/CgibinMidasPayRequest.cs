namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/pay 接口的请求。</para>
    /// </summary>
    public class CgibinMidasPayRequest : CgibinMidasRequestBase
    {
        /// <summary>
        /// 获取或设置扣除游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt")]
        [System.Text.Json.Serialization.JsonPropertyName("amt")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置道具名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_item")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_item")]
        public string? PayItem { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("app_remark")]
        public string? Remark { get; set; }
    }
}
