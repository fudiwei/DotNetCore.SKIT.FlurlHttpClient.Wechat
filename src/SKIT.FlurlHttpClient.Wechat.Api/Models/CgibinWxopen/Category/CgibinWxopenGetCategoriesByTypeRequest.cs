using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/getcategoriesbytype 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenGetCategoriesByTypeRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置主体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_type")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_type")]
        public int? VerifyType { get; set; }
    }
}
