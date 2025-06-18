namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getorderflow 接口的请求。</para>
    /// </summary>
    public class ShopFundsGetOrderFlowRequest : WechatApiRequest, IInferable<ShopFundsGetOrderFlowRequest, ShopFundsGetOrderFlowResponse>
    {
        /// <summary>
        /// 获取或设置资金流水单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funds_flow_id")]
        [System.Text.Json.Serialization.JsonPropertyName("funds_flow_id")]
        public string FundsFlowId { get; set; } = string.Empty;
    }
}
