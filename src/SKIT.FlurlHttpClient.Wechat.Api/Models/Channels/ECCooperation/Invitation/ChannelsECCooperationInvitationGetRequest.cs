using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/cooperation/invitation/get 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-06-16 下线。")]
    public class ChannelsECCooperationInvitationGetRequest : WechatApiRequest, IInferable<ChannelsECCooperationInvitationGetRequest, ChannelsECCooperationInvitationGetResponse>
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
