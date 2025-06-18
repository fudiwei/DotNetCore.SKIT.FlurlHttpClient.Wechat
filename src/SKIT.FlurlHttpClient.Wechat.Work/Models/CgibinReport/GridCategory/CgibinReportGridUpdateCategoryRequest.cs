namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/update_cata 接口的请求。</para>
    /// </summary>
    public class CgibinReportGridUpdateCategoryRequest : CgibinReportGridAddCategoryRequest
    {
        /// <summary>
        /// 获取或设置分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public string CatrgoryId { get; set; } = string.Empty;
    }
}
