namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/is_trade_managed 接口的响应。</para>
    /// </summary>
    public class WxaSecOrderIsTradeManagedResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否已开通小程序发货信息管理服务。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_trade_managed")]
        [System.Text.Json.Serialization.JsonPropertyName("is_trade_managed")]
        public bool IsTradeManaged { get; set; }
    }
}
