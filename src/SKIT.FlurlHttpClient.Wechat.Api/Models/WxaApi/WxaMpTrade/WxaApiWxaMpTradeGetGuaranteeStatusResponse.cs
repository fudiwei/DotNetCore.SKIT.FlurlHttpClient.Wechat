namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/wxamptrade/get_guarantee_status 接口的响应。</para>
    /// </summary>
    public class WxaApiWxaMpTradeGetGuaranteeStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否激活交易保障。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isActived")]
        [System.Text.Json.Serialization.JsonPropertyName("isActived")]
        public bool IsActived { get; set; }
    }
}
