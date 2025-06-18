namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /pay-devices/printers/{device_id}/print-orders/{print_order_no} 接口的响应。</para>
    /// </summary>
    public class GetPayDevicePrinterPrintOrderByPrintOrderNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Variable
            {
                /// <summary>
                /// 获取或设置键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string Key { get; set; } = default!;

                /// <summary>
                /// 获取或设置值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = default!;
            }

            public class Table
            {
                public static class Types
                {
                    public class Row
                    {
                        /// <summary>
                        /// 获取或设置单元格值列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cell_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("cell_list")]
                        public string[] CellList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string Key { get; set; } = default!;

                /// <summary>
                /// 获取或设置行列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("row_list")]
                [System.Text.Json.Serialization.JsonPropertyName("row_list")]
                public Types.Row[] RowList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置打印单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("print_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("print_order_no")]
        public string PrintOrderNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = default!;

        /// <summary>
        /// 获取或设置通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置打印状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("print_state")]
        [System.Text.Json.Serialization.JsonPropertyName("print_state")]
        public string PrintState { get; set; } = default!;

        /// <summary>
        /// 获取或设置打印状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("print_state_description")]
        [System.Text.Json.Serialization.JsonPropertyName("print_state_description")]
        public string PrintStateDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置变量列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("variable_list")]
        [System.Text.Json.Serialization.JsonPropertyName("variable_list")]
        public Types.Variable[]? VariableList { get; set; }

        /// <summary>
        /// 获取或设置表格变量列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table_list")]
        [System.Text.Json.Serialization.JsonPropertyName("table_list")]
        public Types.Table[]? TableList { get; set; }
    }
}
