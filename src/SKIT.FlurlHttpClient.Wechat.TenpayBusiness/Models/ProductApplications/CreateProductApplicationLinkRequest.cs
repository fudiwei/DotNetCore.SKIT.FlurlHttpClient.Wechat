namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/product-applications/{request_no}/links 接口的请求。</para>
    /// </summary>
    public class CreateProductApplicationLinkRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付开户申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RequestNumber { get; set; } = string.Empty;
    }
}
