namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_promoter_register_and_bind_status 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetPromoterRegisterAndBindStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置绑定状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_status")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
        public int BindStatus { get; set; }

        /// <summary>
        /// 获取或设置绑定业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_business_type")]
        public string? BindBusinessType { get; set; }

        /// <summary>
        /// 获取或设置绑定业务参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_query_string")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_query_string")]
        public string? BindQueryString { get; set; }

        /// <summary>
        /// 获取或设置注册状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("register_status")]
        [System.Text.Json.Serialization.JsonPropertyName("register_status")]
        public int RegisterStatus { get; set; }

        /// <summary>
        /// 获取或设置注册业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("register_business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("register_business_type")]
        public string? RegisterBusinessType { get; set; }

        /// <summary>
        /// 获取或设置注册业务参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("register_query_string")]
        [System.Text.Json.Serialization.JsonPropertyName("register_query_string")]
        public string? RegisterQueryString { get; set; }

        /// <summary>
        /// 获取或设置推客的微信电商平台注册的身份标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string? SharerAppId { get; set; }
    }
}
