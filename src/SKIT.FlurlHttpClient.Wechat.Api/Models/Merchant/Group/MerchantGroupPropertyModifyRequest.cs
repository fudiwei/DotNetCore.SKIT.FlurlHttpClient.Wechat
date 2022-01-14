namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/group/propertymod 接口的请求。</para>
    /// </summary>
    public class MerchantGroupPropertyModifyRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// 获取或设置分组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_name")]
        [System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string GroupName { get; set; } = string.Empty;
    }
}
