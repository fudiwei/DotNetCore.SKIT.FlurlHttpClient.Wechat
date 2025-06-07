namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_promoter_register_and_bind_status 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetPromoterRegisterAndBindStatusRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetPromoterRegisterAndBindStatusRequest, ChannelsECPromoterGetPromoterRegisterAndBindStatusResponse>
    {
        /// <summary>
        /// 获取或设置推客的微信电商平台注册的身份标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string? SharerAppId { get; set; }

        /// <summary>
        /// 获取或设置推客的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_openid")]
        public string? SharerOpenId { get; set; }

        /// <summary>
        /// 获取或设置是否简易版本注册。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_simple_register")]
        [System.Text.Json.Serialization.JsonPropertyName("is_simple_register")]
        public bool IsSimpleRegister { get; set; }
    }
}
