using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/delete_views 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetDeleteViewsRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子表 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sheet_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视图 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("view_ids")]
        public IList<string> ViewIdList { get; set; } = new List<string>();
    }
}
