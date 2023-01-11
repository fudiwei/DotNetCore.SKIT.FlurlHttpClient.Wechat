using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/document/batch_update 接口的请求。</para>
    /// </summary>
    public class CgibinWedocDocumentBatchUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class UpdateRequest
            {
                public static class Types
                {
                    public class Range
                    {
                        /// <summary>
                        /// 获取或设置起始位置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_index")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_index")]
                        public int StartIndex { get; set; }

                        /// <summary>
                        /// 获取或设置长度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("length")]
                        [System.Text.Json.Serialization.JsonPropertyName("length")]
                        public int Length { get; set; }
                    }

                    public class Location
                    {
                        /// <summary>
                        /// 获取或设置位置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("index")]
                        [System.Text.Json.Serialization.JsonPropertyName("index")]
                        public int Index { get; set; }
                    }

                    public class ReplaceTextRequest
                    {
                        /// <summary>
                        /// 获取或设置要替换的文本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string Text { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置要替换的文档范围列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ranges")]
                        [System.Text.Json.Serialization.JsonPropertyName("ranges")]
                        public IList<Range> RangeList { get; set; } = new List<Range>();
                    }

                    public class InsertTextRequest
                    {
                        /// <summary>
                        /// 获取或设置要插入的文本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string Text { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置插入的位置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("location")]
                        [System.Text.Json.Serialization.JsonPropertyName("location")]
                        public Location Location { get; set; } = new Location();
                    }

                    public class DeleteContentRequest
                    {
                        /// <summary>
                        /// 获取或设置要删除的范围信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("range")]
                        [System.Text.Json.Serialization.JsonPropertyName("range")]
                        public Range Range { get; set; } = new Range();
                    }

                    public class InsertImageRequest
                    {
                        /// <summary>
                        /// 获取或设置要插入的图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                        public string ImageId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图片宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int? Width { get; set; }

                        /// <summary>
                        /// 获取或设置图片高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int? Height { get; set; }

                        /// <summary>
                        /// 获取或设置插入的位置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("location")]
                        [System.Text.Json.Serialization.JsonPropertyName("location")]
                        public Location Location { get; set; } = new Location();
                    }

                    public class InsertPageBreakRequest
                    {
                        /// <summary>
                        /// 获取或设置插入的位置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("location")]
                        [System.Text.Json.Serialization.JsonPropertyName("location")]
                        public Location Location { get; set; } = new Location();
                    }

                    public class InsertTableRequest
                    {
                        /// <summary>
                        /// 获取或设置表格行数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rows")]
                        [System.Text.Json.Serialization.JsonPropertyName("rows")]
                        public int RowCount { get; set; }

                        /// <summary>
                        /// 获取或设置表格列数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cols")]
                        [System.Text.Json.Serialization.JsonPropertyName("cols")]
                        public int ColumnCount { get; set; }

                        /// <summary>
                        /// 获取或设置插入的位置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("location")]
                        [System.Text.Json.Serialization.JsonPropertyName("location")]
                        public Location Location { get; set; } = new Location();
                    }

                    public class InsertParagraphRequest
                    {
                        /// <summary>
                        /// 获取或设置插入的位置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("location")]
                        [System.Text.Json.Serialization.JsonPropertyName("location")]
                        public Location Location { get; set; } = new Location();
                    }

                    public class UpdateTextPropertyRequest
                    {
                        /// <summary>
                        /// 获取或设置是否加粗。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bold")]
                        [System.Text.Json.Serialization.JsonPropertyName("bold")]
                        public bool? IsBold { get; set; }

                        /// <summary>
                        /// 获取或设置文字颜色（格式：RRGGBB）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("color")]
                        [System.Text.Json.Serialization.JsonPropertyName("color")]
                        public string? Color { get; set; }

                        /// <summary>
                        /// 获取或设置背景颜色（格式：RRGGBB）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("background_color")]
                        [System.Text.Json.Serialization.JsonPropertyName("background_color")]
                        public string? BackgroundColor { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置替换指定位置文本内容的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("replace_text")]
                [System.Text.Json.Serialization.JsonPropertyName("replace_text")]
                public Types.ReplaceTextRequest? ReplaceTextRequest { get; set; }

                /// <summary>
                /// 获取或设置在指定位置插入文本内容的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("insert_text")]
                [System.Text.Json.Serialization.JsonPropertyName("insert_text")]
                public Types.InsertTextRequest? InsertTextRequest { get; set; }

                /// <summary>
                /// 获取或设置删除指定位置内容的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delete_content")]
                [System.Text.Json.Serialization.JsonPropertyName("delete_content")]
                public Types.DeleteContentRequest? DeleteContentRequest { get; set; }

                /// <summary>
                /// 获取或设置在指定位置插入图片的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("insert_image")]
                [System.Text.Json.Serialization.JsonPropertyName("insert_image")]
                public Types.InsertImageRequest? InsertImageRequest { get; set; }

                /// <summary>
                /// 获取或设置在指定位置插入分页符的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("insert_page_break")]
                [System.Text.Json.Serialization.JsonPropertyName("insert_page_break")]
                public Types.InsertPageBreakRequest? InsertPageBreakRequest { get; set; }

                /// <summary>
                /// 获取或设置在指定位置插入表格的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("insert_table")]
                [System.Text.Json.Serialization.JsonPropertyName("insert_table")]
                public Types.InsertTableRequest? InsertTableRequest { get; set; }

                /// <summary>
                /// 获取或设置在指定位置插入段落的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("insert_paragraph")]
                [System.Text.Json.Serialization.JsonPropertyName("insert_paragraph")]
                public Types.InsertParagraphRequest? InsertParagraphRequest { get; set; }

                /// <summary>
                /// 获取或设置更新指定位置文本属性的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_text_property")]
                [System.Text.Json.Serialization.JsonPropertyName("update_text_property")]
                public Types.UpdateTextPropertyRequest? UpdateTextPropertyRequest { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文档版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 获取或设置批量更新请求列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requests")]
        [System.Text.Json.Serialization.JsonPropertyName("requests")]
        public IList<Types.UpdateRequest> BatchRequestList { get; set; } = new List<Types.UpdateRequest>();
    }
}
