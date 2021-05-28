using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/update 接口的响应。</para>
    /// </summary>
    public class CardUpdateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否需要提交审核。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_check")]
        [System.Text.Json.Serialization.JsonPropertyName("send_check")]
        public bool RequireSendCheck { get; set; }
    }
}
