using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/queryguidebuyerbytag 接口的响应。</para>
    /// </summary>
    public class CgibinGuideQueryGuideBuyerByTagResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置客户 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("openid_list")]
        public string[] BuyerOpenIdList { get; set; } = default!;
    }
}
