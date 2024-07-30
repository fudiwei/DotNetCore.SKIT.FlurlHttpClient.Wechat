using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/grade/update 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-07-22 下线。")]
    public class ChannelsECVipUserGradeUpdateRequest : WechatApiRequest, IInferable<ChannelsECVipUserGradeUpdateRequest, ChannelsECVipUserGradeUpdateResponse>
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grade")]
        [System.Text.Json.Serialization.JsonPropertyName("grade")]
        public int Grade { get; set; }
    }
}
