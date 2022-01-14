namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/group/del 接口的请求。</para>
    /// </summary>
    public class MerchantGroupDeleteRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public int GroupId { get; set; }
    }
}
