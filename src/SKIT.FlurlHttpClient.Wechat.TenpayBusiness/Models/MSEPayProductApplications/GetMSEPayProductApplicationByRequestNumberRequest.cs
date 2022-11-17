namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/product-applications/{request_no} 接口的请求。</para>
    /// </summary>
    public class GetMSEPayProductApplicationByRequestNumberRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付开户申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RequestNumber { get; set; } = string.Empty;
    }
}
