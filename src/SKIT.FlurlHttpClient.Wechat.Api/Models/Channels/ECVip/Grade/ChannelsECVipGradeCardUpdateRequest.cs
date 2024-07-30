using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/grade/card/update 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-07-22 下线。")]
    public class ChannelsECVipGradeCardUpdateRequest : WechatApiRequest, IInferable<ChannelsECVipGradeCardUpdateRequest, ChannelsECVipGradeCardUpdateResponse>
    {
        /// <summary>
        /// 获取或设置会员等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grade")]
        [System.Text.Json.Serialization.JsonPropertyName("grade")]
        public int Grade { get; set; }

        /// <summary>
        /// 获取或设置会员等级名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
