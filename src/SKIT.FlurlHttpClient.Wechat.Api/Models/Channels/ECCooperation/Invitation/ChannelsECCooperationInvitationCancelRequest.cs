namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/cooperation/invitation/cancel 接口的请求。</para>
    /// </summary>
    public class ChannelsECCooperationInvitationCancelRequest : WechatApiRequest, IInferable<ChannelsECCooperationInvitationCancelRequest, ChannelsECCooperationInvitationCancelResponse>
    {
        /// <summary>
        /// 获取或设置合作账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_id")]
        public string SharerId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置合作账号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_type")]
        public int SharerType { get; set; }
    }
}
