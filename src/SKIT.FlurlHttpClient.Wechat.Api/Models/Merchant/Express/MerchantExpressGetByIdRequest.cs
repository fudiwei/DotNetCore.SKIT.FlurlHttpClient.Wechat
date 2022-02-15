using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/express/getbyid 接口的请求。</para>
    /// </summary>
    public class MerchantExpressGetByIdRequest : WechatApiRequest, IMapResponse<MerchantExpressGetByIdRequest, MerchantExpressGetByIdResponse>
    {
        /// <summary>
        /// 获取或设置邮费模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public int TemplateId { get; set; }
    }
}
