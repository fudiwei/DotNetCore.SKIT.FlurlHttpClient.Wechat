namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_bind_sharer_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetBindSharerListRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetBindSharerListRequest, ChannelsECPromoterGetBindSharerListResponse>
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
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }
}
