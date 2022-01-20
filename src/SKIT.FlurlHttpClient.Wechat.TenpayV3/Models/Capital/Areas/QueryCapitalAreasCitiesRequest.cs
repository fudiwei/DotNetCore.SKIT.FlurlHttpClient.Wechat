namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /capital/capitallhh/areas/provinces/{province_code}/cities 接口的请求。</para>
    /// </summary>
    public class QueryCapitalAreasCitiesRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置省份编码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int ProvinceCode { get; set; }
    }
}
