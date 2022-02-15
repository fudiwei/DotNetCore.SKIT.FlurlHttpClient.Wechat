using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/grayrelease 接口的请求。</para>
    /// </summary>
    public class WxaGrayReleaseRequest : WechatApiRequest, IMapResponse<WxaGrayReleaseRequest, WxaGrayReleaseResponse>
    {
        /// <summary>
        /// 获取或设置灰度百分比（范围：1～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gray_percentage")]
        [System.Text.Json.Serialization.JsonPropertyName("gray_percentage")]
        public int GrayPercentage { get; set; }
    }
}
