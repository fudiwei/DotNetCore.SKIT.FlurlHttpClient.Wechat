namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /webizpay/employees/{employee_id}/quota-cards/{card_no}/payment-url 接口的请求。</para>
    /// </summary>
    public class GetWeBusinessPayEmployeeQuotaCardPaymentUrlRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayGlobalClient"/> 时的 <see cref="WechatTenpayGlobalClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信授权关系 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EmployeeId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业支付额度卡卡号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业应用类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplicationType { get; set; } = string.Empty;
    }
}
