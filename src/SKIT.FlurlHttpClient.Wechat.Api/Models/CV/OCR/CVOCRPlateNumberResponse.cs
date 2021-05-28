using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/platenum 接口的响应。</para>
    /// </summary>
    public class CVOCRPlateNumberResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置车牌号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("number")]
        [System.Text.Json.Serialization.JsonPropertyName("number")]
        public string PlateNumber { get; set; } = default!;
    }
}
