namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/card/card-links/business-code/{business_code} 接口的请求。</para>
    /// </summary>
    public class GetBrandCardLinkByBusinessCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户业务申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? BusinessCode { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? BrandId { get; set; }
    }
}
