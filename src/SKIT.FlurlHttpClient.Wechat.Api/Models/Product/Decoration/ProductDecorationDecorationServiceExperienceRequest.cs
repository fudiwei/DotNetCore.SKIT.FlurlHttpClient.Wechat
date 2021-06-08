using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/decoration/decoration_service_experience 接口的请求。</para>
    /// </summary>
    public class ProductDecorationDecorationServiceExperienceRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public int ServiceId { get; set; }
    }
}
