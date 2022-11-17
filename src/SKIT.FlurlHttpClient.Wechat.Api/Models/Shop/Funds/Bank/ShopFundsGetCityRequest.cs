namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getcity 接口的请求。</para>
    /// </summary>
    public class ShopFundsGetCityRequest : WechatApiRequest, IInferable<ShopFundsGetCityRequest, ShopFundsGetCityResponse>
    {
        /// <summary>
        /// 获取或设置省份编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_code")]
        [System.Text.Json.Serialization.JsonPropertyName("province_code")]
        public int ProvinceCode { get; set; }
    }
}
