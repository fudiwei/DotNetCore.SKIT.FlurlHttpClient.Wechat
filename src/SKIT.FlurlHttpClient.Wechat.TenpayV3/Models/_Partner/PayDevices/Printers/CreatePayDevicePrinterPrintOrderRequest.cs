using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay-devices/printers/{device_id}/print-orders 接口的请求。</para>
    /// </summary>
    public class CreatePayDevicePrinterPrintOrderRequest : WechatTenpayRequest
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
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
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
                        public IList<string> CellList { get; set; } = new List<string>();
                    }
                }

                /// <summary>
                /// 获取或设置键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置行列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("row_list")]
                [System.Text.Json.Serialization.JsonPropertyName("row_list")]
                public IList<Types.Row> RowList { get; set; } = new List<Types.Row>();
            }
        }

        /// <summary>
        /// 获取或设置小票机设备号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DeviceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置打印单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("print_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("print_order_no")]
        public string PrintOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置变量列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("variable_list")]
        [System.Text.Json.Serialization.JsonPropertyName("variable_list")]
        public IList<Types.Variable>? VariableList { get; set; }

        /// <summary>
        /// 获取或设置表格变量列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table_list")]
        [System.Text.Json.Serialization.JsonPropertyName("table_list")]
        public IList<Types.Table>? TableList { get; set; }
    }
}
