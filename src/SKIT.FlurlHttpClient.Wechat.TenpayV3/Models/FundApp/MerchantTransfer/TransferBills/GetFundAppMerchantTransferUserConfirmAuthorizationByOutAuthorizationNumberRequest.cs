namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /fund-app/mch-transfer/user-confirm-authorization/out-authorization-no/{out_authorization_no} 接口的请求。</para>
    /// </summary>
    public class GetFundAppMerchantTransferUserConfirmAuthorizationByOutAuthorizationNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户侧授权单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutAuthorizationNumber { get; set; } = string.Empty;
    }
}
