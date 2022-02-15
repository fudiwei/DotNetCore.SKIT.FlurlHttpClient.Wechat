using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/quota/get 接口的请求。</para>
    /// </summary>
    public class CgibinExpressBusinessQuotaGetRequest : WechatApiRequest, IMapResponse<CgibinExpressBusinessQuotaGetRequest, CgibinExpressBusinessQuotaGetResponse>
    {
        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_id")]
        public string BusinessId { get; set; } = string.Empty;
    }
}
