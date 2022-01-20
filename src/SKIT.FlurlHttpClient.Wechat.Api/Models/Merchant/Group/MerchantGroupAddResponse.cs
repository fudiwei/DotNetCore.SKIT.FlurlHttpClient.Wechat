namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/group/add 接口的响应。</para>
    /// </summary>
    public class MerchantGroupAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public int GroupId { get; set; }
    }
}
