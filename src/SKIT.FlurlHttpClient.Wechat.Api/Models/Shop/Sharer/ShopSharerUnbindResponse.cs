namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/unbind 接口的响应。</para>
    /// </summary>
    public class ShopSharerUnbindResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置解绑成功的分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_list")]
        [System.Text.Json.Serialization.JsonPropertyName("success_list")]
        public List<string>? SuccessOpenIdList { get; set; }

        /// <summary>
        /// 获取或设置解绑失败的分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public List<string>? FailOpenIdList { get; set; }

        /// <summary>
        /// 获取或设置解绑拒绝的分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refuse_list")]
        [System.Text.Json.Serialization.JsonPropertyName("refuse_list")]
        public List<string>? RefuseOpenIdList { get; set; }
    }
}
