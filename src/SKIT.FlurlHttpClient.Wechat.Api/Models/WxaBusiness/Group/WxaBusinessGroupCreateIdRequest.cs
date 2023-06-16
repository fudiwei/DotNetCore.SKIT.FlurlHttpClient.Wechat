namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/group/createid 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGroupCreateIdRequest : WechatApiRequest, IInferable<WxaBusinessGroupCreateIdRequest, WxaBusinessGroupCreateIdResponse>
    {
        /// <summary>
        /// 获取或设置设备型号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_id")]
        [System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_name")]
        [System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string GroupName { get; set; } = string.Empty;
    }
}
