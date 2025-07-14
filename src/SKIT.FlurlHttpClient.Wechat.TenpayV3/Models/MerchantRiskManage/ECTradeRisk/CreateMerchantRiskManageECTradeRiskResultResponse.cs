namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-risk-manage/ec-trade-risk/recv-dispose-result 接口的响应。</para>
    /// </summary>
    public class CreateMerchantRiskManageECTradeRiskResultResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置返回描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rsp_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("rsp_msg")]
        public string? ResponseMessage { get; set; }
    }
}
