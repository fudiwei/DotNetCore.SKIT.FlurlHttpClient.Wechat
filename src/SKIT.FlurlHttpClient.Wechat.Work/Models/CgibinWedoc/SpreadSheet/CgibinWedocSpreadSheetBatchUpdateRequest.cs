using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/spreadsheet/batch_update 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSpreadSheetBatchUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class UpdateRequest
            {
                public static class Types
                {
                    public class AddSheetRequest
                    {
                        /// <summary>
                        /// 获取或设置工作表名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置初始行数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("row_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("row_count")]
                        public int RowCount { get; set; }

                        /// <summary>
                        /// 获取或设置初始列数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("column_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("column_count")]
                        public int ColumnCount { get; set; }
                    }

                    public class DeleteSheetRequest
                    {
                        /// <summary>
                        /// 获取或设置工作表 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sheet_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
                        public string SheetId { get; set; } = string.Empty;
                    }

                    public class UpdateRangeRequest
                    {
                        public static class Types
                        {
                            public class GridData
                            {
                                public static class Types
                                {
                                    public class Row
                                    {
                                        public static class Types
                                        {
                                            public class Cell
                                            {
                                                public static class Types
                                                {
                                                    public class CellValue
                                                    {
                                                        public static class Types
                                                        {
                                                            public class Link
                                                            {
                                                                /// <summary>
                                                                /// 获取或设置链接 URL。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("url")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                                                public string Url { get; set; } = string.Empty;

                                                                /// <summary>
                                                                /// 获取或设置链接标题。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("text")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                                                public string Text { get; set; } = string.Empty;
                                                            }
                                                        }

                                                        /// <summary>
                                                        /// 获取或设置文本内容。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("text")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                                        public string? Text { get; set; }

                                                        /// <summary>
                                                        /// 获取或设置超链接内容。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("link")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("link")]
                                                        public Types.Link? Link { get; set; }
                                                    }

                                                    public class CellFormat
                                                    {
                                                        public static class Types
                                                        {
                                                            public class TextFormat
                                                            {
                                                                public static class Types
                                                                {
                                                                    public class Color
                                                                    {
                                                                        /// <summary>
                                                                        /// 获取或设置红色值。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("red")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("red")]
                                                                        public byte Red { get; set; }

                                                                        /// <summary>
                                                                        /// 获取或设置绿色值。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("green")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("green")]
                                                                        public byte Green { get; set; }

                                                                        /// <summary>
                                                                        /// 获取或设置蓝色值。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("blue")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("blue")]
                                                                        public byte Blue { get; set; }

                                                                        /// <summary>
                                                                        /// 获取或设置 Alpha 通道值。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("alpha")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("alpha")]
                                                                        public byte? Alpha { get; set; }
                                                                    }
                                                                }

                                                                /// <summary>
                                                                /// 获取或设置字体。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("font")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("font")]
                                                                public string FontName { get; set; } = string.Empty;

                                                                /// <summary>
                                                                /// 获取或设置字号。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("font_size")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("font_size")]
                                                                public int FontSize { get; set; }

                                                                /// <summary>
                                                                /// 获取或设置是否加粗。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("bold")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("bold")]
                                                                public bool IsBold { get; set; }

                                                                /// <summary>
                                                                /// 获取或设置是否斜体。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("italic")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("italic")]
                                                                public bool IsItalic { get; set; }

                                                                /// <summary>
                                                                /// 获取或设置是否删除线。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("strikethrough")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("strikethrough")]
                                                                public bool IsStrikeThrough { get; set; }

                                                                /// <summary>
                                                                /// 获取或设置是否下划线。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("underline")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("underline")]
                                                                public bool IsUnderline { get; set; }

                                                                /// <summary>
                                                                /// 获取或设置颜色。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("color")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("color")]
                                                                public Types.Color? Color { get; set; }
                                                            }
                                                        }

                                                        /// <summary>
                                                        /// 获取或设置文字样式信息。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("text_format")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("text_format")]
                                                        public Types.TextFormat TextFormat { get; set; } = new Types.TextFormat();
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置单元格的数据内容。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("cell_value")]
                                                [System.Text.Json.Serialization.JsonPropertyName("cell_value")]
                                                public Types.CellValue CellValue { get; set; } = new Types.CellValue();

                                                /// <summary>
                                                /// 获取或设置单元格的样式信息。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("cell_format")]
                                                [System.Text.Json.Serialization.JsonPropertyName("cell_format")]
                                                public Types.CellFormat CellFormat { get; set; } = new Types.CellFormat();
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置单元格数据。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("values")]
                                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                                        public IList<Types.Cell> Cells { get; set; } = new List<Types.Cell>();
                                    }
                                }

                                /// <summary>
                                /// 获取或设置起始行号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_row")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_row")]
                                public int StartRowIndex { get; set; }

                                /// <summary>
                                /// 获取或设置起始列号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_column")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_column")]
                                public int StartColumnIndex { get; set; }

                                /// <summary>
                                /// 获取或设置行数据。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rows")]
                                [System.Text.Json.Serialization.JsonPropertyName("rows")]
                                public IList<Types.Row> Rows { get; set; } = new List<Types.Row>();
                            }
                        }

                        /// <summary>
                        /// 获取或设置工作表 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sheet_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
                        public string SheetId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置表格数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("grid_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("grid_data")]
                        public Types.GridData GridData { get; set; } = new Types.GridData();
                    }

                    public class DeleteDimensionRequest
                    {
                        /// <summary>
                        /// 获取或设置工作表 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sheet_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
                        public string SheetId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置删除维度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dimension")]
                        [System.Text.Json.Serialization.JsonPropertyName("dimension")]
                        public string Dimension { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置起始位置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_index")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_index")]
                        public int StartIndex { get; set; }

                        /// <summary>
                        /// 获取或设置终止位置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_index")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_index")]
                        public int EndIndex { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置新增工作表的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("add_sheet_request")]
                [System.Text.Json.Serialization.JsonPropertyName("add_sheet_request")]
                public Types.AddSheetRequest? AddSheetRequest { get; set; }

                /// <summary>
                /// 获取或设置删除工作表的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delete_sheet_request")]
                [System.Text.Json.Serialization.JsonPropertyName("delete_sheet_request")]
                public Types.DeleteSheetRequest? DeleteSheetRequest { get; set; }

                /// <summary>
                /// 获取或设置更新范围内单元格内容的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_range_request")]
                [System.Text.Json.Serialization.JsonPropertyName("update_range_request")]
                public Types.UpdateRangeRequest? UpdateRangeRequest { get; set; }

                /// <summary>
                /// 获取或设置删除表格连续的行或列的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delete_dimension_request")]
                [System.Text.Json.Serialization.JsonPropertyName("delete_dimension_request")]
                public Types.DeleteDimensionRequest? DeleteDimensionRequest { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批量更新请求列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requests")]
        [System.Text.Json.Serialization.JsonPropertyName("requests")]
        public IList<Types.UpdateRequest> BatchRequestList { get; set; } = new List<Types.UpdateRequest>();
    }
}
