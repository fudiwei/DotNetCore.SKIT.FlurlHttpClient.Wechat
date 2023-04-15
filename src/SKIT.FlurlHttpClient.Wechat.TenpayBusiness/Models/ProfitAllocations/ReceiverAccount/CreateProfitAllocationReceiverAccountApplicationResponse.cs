namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/profit-allocations/receiver-accounts-applications 接口的响应。</para>
    /// </summary>
    public class CreateProfitAllocationReceiverAccountApplicationResponse : WechatTenpayBusinessResponse
    {
        /// <summary>
        /// 获取或设置平台申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_application_id")]
        public string OutApplicationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public string ApplicationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;
    }
}
