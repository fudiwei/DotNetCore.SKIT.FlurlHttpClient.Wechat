using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/transactions/native 接口的响应。</para>
    /// </summary>
    public class CreatePayTransactionNativeResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_url")]
        [System.Text.Json.Serialization.JsonPropertyName("code_url")]
        public string QrcodeUrl { get; set; } = default!;
    }
}
