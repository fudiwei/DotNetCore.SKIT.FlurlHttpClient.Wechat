using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/customservice/getonlinekflist 接口的响应。</para>
    /// </summary>
    public class CgibinCustomServiceGetOnlineKfListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Kf
            {
                /// <summary>
                /// 获取或设置客服 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_id")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_id")]
                public string KfId { get; set; } = default!;

                /// <summary>
                /// 获取或设置客服账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_account")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_account")]
                public string KfAccount { get; set; } = default!;

                /// <summary>
                /// 获取或设置客服在线状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置客服当前正在接待的会话数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("accepted_case")]
                [System.Text.Json.Serialization.JsonPropertyName("accepted_case")]
                public int AcceptedCaseCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客服列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kf_online_list")]
        [System.Text.Json.Serialization.JsonPropertyName("kf_online_list")]
        public Types.Kf[] KfList { get; set; } = default!;
    }
}
