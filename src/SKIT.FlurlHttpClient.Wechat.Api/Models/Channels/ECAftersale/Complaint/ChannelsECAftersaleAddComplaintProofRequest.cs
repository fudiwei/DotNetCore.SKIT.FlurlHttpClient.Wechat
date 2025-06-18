using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/addcomplaintproof 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleAddComplaintProofRequest : WechatApiRequest, IInferable<ChannelsECAftersaleAddComplaintProofRequest, ChannelsECAftersaleAddComplaintProofResponse>
    {
        /// <summary>
        /// 获取或设置纠纷单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_id")]
        public string ComplaintId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置举证内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id_list")]
        public IList<string>? MediaIdList { get; set; }
    }
}
