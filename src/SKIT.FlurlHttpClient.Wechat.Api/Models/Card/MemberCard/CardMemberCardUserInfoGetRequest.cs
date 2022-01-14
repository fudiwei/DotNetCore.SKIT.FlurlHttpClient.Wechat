namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/userinfo/get 接口的请求。</para>
    /// </summary>
    public class CardMemberCardUserInfoGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string CardCode { get; set; } = string.Empty;
    }
}
