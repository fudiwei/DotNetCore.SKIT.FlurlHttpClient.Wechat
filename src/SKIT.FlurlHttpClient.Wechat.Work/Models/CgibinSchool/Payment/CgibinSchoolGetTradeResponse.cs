namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/get_trade 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolGetTradeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置微信交易单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        public long PayTimestamp { get; set; }
    }
}
