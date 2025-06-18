namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_api/get_corp_buy_info 接口的请求。</para>
    /// </summary>
    public class CgibinAdvancedApiGetCorpBuyInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置购买的高级接口类型。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advanced_api_type")]
        [System.Text.Json.Serialization.JsonPropertyName("advanced_api_type")]
        public int AdvancedApiType { get; set; } = 1;

        /// <summary>
        /// 获取或设置客户企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_corpid")]
        public string CustomCorpId { get; set; } = string.Empty;
    }
}
