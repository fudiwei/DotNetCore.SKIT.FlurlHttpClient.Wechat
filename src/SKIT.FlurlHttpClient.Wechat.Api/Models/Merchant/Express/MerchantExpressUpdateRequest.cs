using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/express/update 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantExpressUpdateRequest : WechatApiRequest, IInferable<MerchantExpressUpdateRequest, MerchantExpressUpdateResponse>
    {
        public static class Types
        {
            public class Template : MerchantExpressAddRequest.Types.Template
            {
            }
        }

        /// <summary>
        /// 获取或设置邮费模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public int TemplateId { get; set; }

        /// <summary>
        /// 获取或设置邮费模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_template")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_template")]
        public Types.Template Template { get; set; } = new Types.Template();
    }
}
