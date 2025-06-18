﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/template/api_set_industry 接口的请求。</para>
    /// </summary>
    public class CgibinTemplateSetIndustryRequest : WechatApiRequest, IInferable<CgibinTemplateSetIndustryRequest, CgibinTemplateSetIndustryResponse>
    {
        /// <summary>
        /// 获取或设置主行业编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_id1")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_id1")]
        public string PrimaryIndustryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置副行业编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_id2")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_id2")]
        public string SecondaryIndustryId { get; set; } = string.Empty;
    }
}
