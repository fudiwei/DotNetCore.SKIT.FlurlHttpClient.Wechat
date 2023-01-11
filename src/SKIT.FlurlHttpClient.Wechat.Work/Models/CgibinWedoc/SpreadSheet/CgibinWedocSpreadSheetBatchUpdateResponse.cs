namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/spreadsheet/batch_update 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSpreadSheetBatchUpdateResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class UpdateResponse
                    {
                        public static class Types
                        {
                            public class AddSheetResponse
                            {
                                public static class Types
                                {
                                    public class SheetProperty : CgibinWedocSpreadSheetGetSheetPropertiesResponse.Types.SheetProperty
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置工作表属性。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("properties")]
                                [System.Text.Json.Serialization.JsonPropertyName("properties")]
                                public Types.SheetProperty SheetProperty { get; set; } = default!;
                            }

                            public class DeleteSheetResponse
                            {
                                /// <summary>
                                /// 获取或设置工作表 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sheet_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
                                public string SheetId { get; set; } = default!;
                            }

                            public class UpdateRangeResponse
                            {
                                /// <summary>
                                /// 获取或设置数据更新的成功的单元格数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("updated_cells")]
                                [System.Text.Json.Serialization.JsonPropertyName("updated_cells")]
                                public int UpdatedCellCount { get; set; }
                            }

                            public class DeleteDimensionResponse
                            {
                                /// <summary>
                                /// 获取或设置删除表格连续的行或列数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("deleted")]
                                [System.Text.Json.Serialization.JsonPropertyName("deleted")]
                                public int DeletedCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置新增工作表的信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("add_sheet_response")]
                        [System.Text.Json.Serialization.JsonPropertyName("add_sheet_response")]
                        public Types.AddSheetResponse? AddSheetResponse { get; set; }

                        /// <summary>
                        /// 获取或设置删除工作表的信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delete_sheet_response")]
                        [System.Text.Json.Serialization.JsonPropertyName("delete_sheet_response")]
                        public Types.DeleteSheetResponse? DeleteSheetResponse { get; set; }

                        /// <summary>
                        /// 获取或设置更新范围内单元格内容的信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_range_response")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_range_response")]
                        public Types.UpdateRangeResponse? UpdateRangeResponse { get; set; }

                        /// <summary>
                        /// 获取或设置删除表格连续的行或列的信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delete_dimension_response")]
                        [System.Text.Json.Serialization.JsonPropertyName("delete_dimension_response")]
                        public Types.DeleteDimensionResponse? DeleteDimensionResponse { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置批量更新响应列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("responses")]
                [System.Text.Json.Serialization.JsonPropertyName("responses")]
                public Types.UpdateResponse[] BatchResponseList { get; set; } = default!;
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
