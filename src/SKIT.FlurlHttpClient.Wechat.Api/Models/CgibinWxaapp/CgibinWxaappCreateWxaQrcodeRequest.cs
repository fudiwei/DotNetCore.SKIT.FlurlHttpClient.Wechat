using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxaapp/createwxaqrcode 接口的请求。</para>
    /// </summary>
    public class CgibinWxaappCreateWxaQrcodeRequest : WechatApiRequest, IMapResponse<CgibinWxaappCreateWxaQrcodeRequest, CgibinWxaappCreateWxaQrcodeResponse>
    {
        /// <summary>
        /// 获取或设置扫码进入的小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置二维码的宽度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width")]
        [System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }
    }
}
