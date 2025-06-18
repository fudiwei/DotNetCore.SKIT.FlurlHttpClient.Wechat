namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/h5/permission/{sub_mchid} 接口的响应。</para>
    /// </summary>
    public class GetMerchantH5PermissionBySubMerchantIdResponse : WechatTenpayGlobalResponse
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置认证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_state")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_state")]
        public string AuthorizationState { get; set; } = default!;
    }
}
