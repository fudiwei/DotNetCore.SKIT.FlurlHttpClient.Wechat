namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/list_cata 接口的响应。</para>
    /// </summary>
    public class CgibinReportGridListCategoryResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cata_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cata_id")]
                public string CategoryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置分类名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cata_name")]
                [System.Text.Json.Serialization.JsonPropertyName("cata_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置分类层级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public int Level { get; set; }

                /// <summary>
                /// 获取或设置上级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_cata_id")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_cata_id")]
                public string? ParentCategoryId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分类列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cata_list")]
        [System.Text.Json.Serialization.JsonPropertyName("cata_list")]
        public Types.Category[] CategoryList { get; set; } = default!;
    }
}
