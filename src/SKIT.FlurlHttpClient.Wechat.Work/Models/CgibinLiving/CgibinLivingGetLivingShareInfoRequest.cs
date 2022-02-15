namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/living/get_living_share_info 接口的请求。</para>
    /// </summary>
    public class CgibinLivingGetLivingShareInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置“推广产品”直播观众跳转小程序商城时的 `ww_share_code` 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ww_share_code")]
        [System.Text.Json.Serialization.JsonPropertyName("ww_share_code")]
        public string ShareCode { get; set; } = string.Empty;
    }
}
