using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/quota/get 接口的响应。</para>
    /// </summary>
    public class CgibinExpressBusinessQuotaGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置电子面单余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quota_num")]
        [System.Text.Json.Serialization.JsonPropertyName("quota_num")]
        public int QuotaNumber { get; set; } = default!;
    }
}
