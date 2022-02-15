using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/delguidetagoption 接口的请求。</para>
    /// </summary>
    public class CgibinGuideDeleteGuideTagOptionRequest : WechatApiRequest, IMapResponse<CgibinGuideDeleteGuideTagOptionRequest, CgibinGuideDeleteGuideTagOptionResponse>
    {
        /// <summary>
        /// 获取或设置标签类型名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_name")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        public string TagName { get; set; } = string.Empty;
    }
}
