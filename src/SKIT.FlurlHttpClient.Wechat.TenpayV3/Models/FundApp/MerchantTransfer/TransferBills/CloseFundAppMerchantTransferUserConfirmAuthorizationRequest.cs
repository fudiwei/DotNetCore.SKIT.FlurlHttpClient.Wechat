namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /fund-app/mch-transfer/user-confirm-authorization/out-authorization-no/{out_authorization_no}/close 接口的请求。</para>
    /// </summary>
    public class CloseFundAppMerchantTransferUserConfirmAuthorizationRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户侧授权单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutAuthorizationNumber { get; set; } = string.Empty;
    }
}
