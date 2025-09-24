namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mchalterapply/mchcontactalterapplyment/{apply_id}/revoke 接口的请求。</para>
    /// </summary>
    public class RevokeMerchantAlterApplyMerchantContactAlterApplymentRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplymentId { get; set; } = string.Empty;
    }
}
