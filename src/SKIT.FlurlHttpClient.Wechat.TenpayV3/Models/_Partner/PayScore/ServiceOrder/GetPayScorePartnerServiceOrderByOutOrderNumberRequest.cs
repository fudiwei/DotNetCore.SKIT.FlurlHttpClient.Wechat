namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/partner/serviceorder 接口的请求。</para>
    /// </summary>
    public class GetPayScorePartnerServiceOrderByOutOrderNumberRequest : GetPayScoreServiceOrderByOutOrderNumberRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
