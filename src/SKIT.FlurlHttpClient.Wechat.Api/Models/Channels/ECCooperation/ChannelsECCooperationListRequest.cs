namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/cooperation/list 接口的请求。</para>
    /// </summary>
    public class ChannelsECCooperationListRequest : WechatApiRequest, IInferable<ChannelsECCooperationListRequest, ChannelsECCooperationListResponse>
    {
        /// <summary>
        /// 获取或设置合作账号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_type")]
        public int SharerType { get; set; }
    }
}
