namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/spreadsheet/get_sheet_range_data 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSpreadSheetGetSheetRangeDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
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
                                                        public string Url { get; set; } = default!;

                                                        /// <summary>
                                                        /// 获取或设置链接标题。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("text")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                                        public string Text { get; set; } = default!;
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
                                                                public byte Alpha { get; set; }
                                                            }
                                                        }

                                                        /// <summary>
                                                        /// 获取或设置字体。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("font")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("font")]
                                                        public string FontName { get; set; } = default!;

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
                                                public Types.TextFormat TextFormat { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置单元格的数据内容。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("cell_value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("cell_value")]
                                        public Types.CellValue CellValue { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置单元格的样式信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("cell_format")]
                                        [System.Text.Json.Serialization.JsonPropertyName("cell_format")]
                                        public Types.CellFormat CellFormat { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置单元格数据。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("values")]
                                [System.Text.Json.Serialization.JsonPropertyName("values")]
                                public Types.Cell[] Cells { get; set; } = default!;
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
                        public Types.Row[] Rows { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置表格数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public Types.GridData GridData { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
