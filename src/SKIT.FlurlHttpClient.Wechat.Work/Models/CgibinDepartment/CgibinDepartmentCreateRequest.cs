using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/department/create 接口的请求。</para>
    /// </summary>
    public class CgibinDepartmentCreateRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// 获取或设置部门名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置部门英文名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name_en")]
        [System.Text.Json.Serialization.JsonPropertyName("name_en")]
        public string? EnglishName { get; set; }

        /// <summary>
        /// 获取或设置上级部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentid")]
        [System.Text.Json.Serialization.JsonPropertyName("parentid")]
        public int? ParentDepartmentId { get; set; }

        /// <summary>
        /// 获取或设置在上级部门中的次序值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? DepartmentOrder { get; set; }
    }
}
