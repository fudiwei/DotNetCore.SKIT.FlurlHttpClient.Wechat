namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/charge/usage/get_recent_average 接口的请求。</para>
    /// </summary>
    public class WxaChargeUsageGetRecentAverageRequest : WechatApiRequest, IInferable<WxaChargeUsageGetRecentAverageRequest, WxaChargeUsageGetRecentAverageResponse>
    {
        /// <summary>
        /// 获取或设置商品 SPU ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SPUId { get; set; } = string.Empty;
    }
}
