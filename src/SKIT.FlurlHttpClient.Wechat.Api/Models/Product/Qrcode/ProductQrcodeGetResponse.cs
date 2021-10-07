using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/qrcode/get 接口的响应。</para>
    /// </summary>
    public class ProductQrcodeGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置经 Base64 编码的二维码二进制流。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_buf")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_buf")]
        public string EncodingQrcodeBuffer { get; set; } = default!;
    }
}
