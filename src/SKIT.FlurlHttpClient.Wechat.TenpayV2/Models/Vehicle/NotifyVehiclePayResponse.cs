namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/pay/notification 接口的响应。</para>
    /// </summary>
    public class NotifyVehiclePayResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string MerchantId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string AppId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// 获取或设置用户状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_state")]
        [System.Text.Json.Serialization.JsonPropertyName("user_state")]
        public string UserState { get; set; } = default!;

        /// <summary>
        /// 获取或设置发起扣费方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_mode")]
        public string? DeductMode { get; set; }
    }
}
