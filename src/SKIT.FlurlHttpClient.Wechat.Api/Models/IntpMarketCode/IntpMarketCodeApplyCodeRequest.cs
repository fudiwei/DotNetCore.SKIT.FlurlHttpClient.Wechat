using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/applycode 接口的请求。</para>
    /// </summary>
    public class IntpMarketCodeApplyCodeRequest : WechatApiRequest, IMapResponse<IntpMarketCodeApplyCodeRequest, IntpMarketCodeApplyCodeResponse>
    {
        /// <summary>
        /// 获取或设置申请码的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_count")]
        [System.Text.Json.Serialization.JsonPropertyName("code_count")]
        public long CodeCount { get; set; }

        /// <summary>
        /// 获取或设置外部单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isv_application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("isv_application_id")]
        public string ISVApplicationId { get; set; } = string.Empty;
    }
}
