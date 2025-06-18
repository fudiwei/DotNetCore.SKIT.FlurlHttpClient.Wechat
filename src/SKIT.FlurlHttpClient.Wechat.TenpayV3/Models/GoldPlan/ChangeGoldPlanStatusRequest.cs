namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /goldplan/merchants/changegoldplanstatus 接口的请求。</para>
    /// </summary>
    public class ChangeGoldPlanStatusRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("operation_type")]
        public string OperationType { get; set; } = string.Empty;
    }
}
