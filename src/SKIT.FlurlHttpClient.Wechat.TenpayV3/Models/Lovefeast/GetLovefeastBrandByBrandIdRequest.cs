namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /lovefeast/brands/{brand_id} 接口的请求。</para>
    /// </summary>
    public class GetLovefeastBrandByBrandIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandId { get; set; } = string.Empty;
    }
}
