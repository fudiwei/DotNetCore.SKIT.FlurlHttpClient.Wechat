namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/group/getinfo 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGroupGetInfoRequest : WechatApiRequest, IInferable<WxaBusinessGroupGetInfoRequest, WxaBusinessGroupGetInfoResponse>
    {
        /// <summary>
        /// 获取或设置设备组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;
    }
}
