using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/delivery/insert_freight_template 接口的响应。</para>
    /// </summary>
    public class ProductDeliveryInsertFreightTemplateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public int TemplateId { get; set; }
    }
}
