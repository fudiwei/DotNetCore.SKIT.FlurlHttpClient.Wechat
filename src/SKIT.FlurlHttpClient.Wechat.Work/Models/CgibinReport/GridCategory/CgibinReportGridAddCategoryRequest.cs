using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/add_cata 接口的请求。</para>
    /// </summary>
    public class CgibinReportGridAddCategoryRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置分类名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_name")]
        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分类层级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        [System.Text.Json.Serialization.JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// 获取或设置上级分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("parent_category_id")]
        public string? ParentCategoryId { get; set; }
    }
}
