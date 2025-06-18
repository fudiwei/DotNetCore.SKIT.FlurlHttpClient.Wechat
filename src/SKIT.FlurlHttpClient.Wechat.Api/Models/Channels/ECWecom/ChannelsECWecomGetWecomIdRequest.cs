namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/wecom/get_wecom_id 接口的请求。</para>
    /// </summary>
    public class ChannelsECWecomGetWecomIdRequest : WechatApiRequest, IInferable<ChannelsECWecomGetWecomIdRequest, ChannelsECWecomGetWecomIdResponse>
    {
        /// <summary>
        /// 获取或设置企业微信 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corp_id")]
        [System.Text.Json.Serialization.JsonPropertyName("corp_id")]
        public string CorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业微信 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }
}
