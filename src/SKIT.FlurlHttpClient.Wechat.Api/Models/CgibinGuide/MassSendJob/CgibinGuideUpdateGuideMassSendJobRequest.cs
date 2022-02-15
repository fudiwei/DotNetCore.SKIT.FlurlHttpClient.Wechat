using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/updateguidemassendjob 接口的请求。</para>
    /// </summary>
    public class CgibinGuideUpdateGuideMassSendJobRequest : WechatApiRequest, IMapResponse<CgibinGuideUpdateGuideMassSendJobRequest, CgibinGuideUpdateGuideMassSendJobResponse>
    {
        public static class Types
        {
            public class Material : CgibinGuideAddGuideMassSendJobRequest.Types.Material
            {
            }
        }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 获取或设置群发任务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_name")]
        [System.Text.Json.Serialization.JsonPropertyName("task_name")]
        public string? TaskName { get; set; }

        /// <summary>
        /// 获取或设置群发任务备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("task_remark")]
        public string? TaskRemark { get; set; }

        /// <summary>
        /// 获取或设置任务下发时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("push_time")]
        [System.Text.Json.Serialization.JsonPropertyName("push_time")]
        public long? PushTimestamp { get; set; }

        /// <summary>
        /// 获取或设置客户 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public IList<string>? BuyerOpenIdList { get; set; }

        /// <summary>
        /// 获取或设置素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material")]
        [System.Text.Json.Serialization.JsonPropertyName("material")]
        public IList<Types.Material>? MaterialList { get; set; }
    }
}
