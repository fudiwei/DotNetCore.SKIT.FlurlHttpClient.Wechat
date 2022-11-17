namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /user-order/orders-permission/confirm 接口的响应。</para>
    /// </summary>
    public class UserOrderOrdersPermissionConfirmResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置最近一次审核的结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_result")]
        [System.Text.Json.Serialization.JsonPropertyName("last_result")]
        public string? LastResult { get; set; }
    }
}
