namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /fund-app/mch-transfer/user-confirm-authorization 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateFundAppMerchantTransferUserConfirmAuthorizationRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户侧授权单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_authorization_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_authorization_no")]
        public string OutAuthorizationNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收款用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置转账场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_id")]
        public string? TransferSceneId { get; set; }

        /// <summary>
        /// 获取或设置授权结果通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_notify_url")]
        public string? AuthorizationNotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置用户展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_display_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_display_name")]
        public string UserDisplayName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户收款感知。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_recv_perception")]
        [System.Text.Json.Serialization.JsonPropertyName("user_recv_perception")]
        public string? UserReceivePerception { get; set; }
    }
}
