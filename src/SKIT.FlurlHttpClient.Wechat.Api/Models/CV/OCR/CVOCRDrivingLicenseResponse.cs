using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/drivinglicense 接口的响应。</para>
    /// </summary>
    public class CVOCRDrivingLicenseResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置证件号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_num")]
        [System.Text.Json.Serialization.JsonPropertyName("id_num")]
        public string IdNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 获取或设置性别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sex")]
        [System.Text.Json.Serialization.JsonPropertyName("sex")]
        public string Sex { get; set; } = default!;

        /// <summary>
        /// 获取或设置国籍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nationality")]
        [System.Text.Json.Serialization.JsonPropertyName("nationality")]
        public string Nationality { get; set; } = default!;

        /// <summary>
        /// 获取或设置地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// 获取或设置出生日期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birth_date")]
        [System.Text.Json.Serialization.JsonPropertyName("birth_date")]
        public string BirthDate { get; set; } = default!;

        /// <summary>
        /// 获取或设置初次领证日期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("issue_date")]
        [System.Text.Json.Serialization.JsonPropertyName("issue_date")]
        public string IssueDate { get; set; } = default!;

        /// <summary>
        /// 获取或设置准驾车型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_class")]
        [System.Text.Json.Serialization.JsonPropertyName("car_class")]
        public string CarClass { get; set; } = default!;

        /// <summary>
        /// 获取或设置有效期限起始日。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_from")]
        [System.Text.Json.Serialization.JsonPropertyName("valid_from")]
        public string ValidDateFrom { get; set; } = default!;

        /// <summary>
        /// 获取或设置有效期限终止日。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_to")]
        [System.Text.Json.Serialization.JsonPropertyName("valid_to")]
        public string ValidDateTo { get; set; } = default!;

        /// <summary>
        /// 获取或设置印章文构。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("official_seal")]
        [System.Text.Json.Serialization.JsonPropertyName("official_seal")]
        public string OfficialSeal { get; set; } = default!;
    }
}
