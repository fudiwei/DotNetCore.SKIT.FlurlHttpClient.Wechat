namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/hr/get_staff_info 接口的响应。</para>
    /// </summary>
    public class CgibinHrGetStaffInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Field
            {
                public static class Types
                {
                    public class MobileValue
                    {
                        /// <summary>
                        /// 获取或设置国际区号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_country_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_country_code")]
                        public string CountryCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_mobile")]
                        public string MobileNumber { get; set; } = default!;
                    }

                    public class FileValue
                    {
                        /// <summary>
                        /// 获取或设置文件 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string[] MediaIdList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置字段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fieldid")]
                [System.Text.Json.Serialization.JsonPropertyName("fieldid")]
                public int FieldId { get; set; }

                /// <summary>
                /// 获取或设置字段下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_idx")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_idx")]
                public int? SubIndex { get; set; }

                /// <summary>
                /// 获取或设置查询结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public int Result { get; set; }

                /// <summary>
                /// 获取或设置字段值的类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_type")]
                [System.Text.Json.Serialization.JsonPropertyName("value_type")]
                public int ValueType { get; set; }

                /// <summary>
                /// 获取或设置字符串类型的字段值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_string")]
                [System.Text.Json.Serialization.JsonPropertyName("value_string")]
                public string? StringValue { get; set; }

                /// <summary>
                /// 获取或设置 32 位非负整数类型的字段值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_uint32")]
                [System.Text.Json.Serialization.JsonPropertyName("value_uint32")]
                public uint? UInt32Value { get; set; }

                /// <summary>
                /// 获取或设置 64 位非负整数类型的字段值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_uint64")]
                [System.Text.Json.Serialization.JsonPropertyName("value_uint64")]
                public ulong? UInt64Value { get; set; }

                /// <summary>
                /// 获取或设置 32 位整数类型的字段值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_int32")]
                [System.Text.Json.Serialization.JsonPropertyName("value_int32")]
                public int? Int32Value { get; set; }

                /// <summary>
                /// 获取或设置 64 位整数类型的字段值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_int64")]
                [System.Text.Json.Serialization.JsonPropertyName("value_int64")]
                public long? Int64Value { get; set; }

                /// <summary>
                /// 获取或设置手机号码类型的字段值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("value_mobile")]
                public Types.MobileValue? MobileValue { get; set; }

                /// <summary>
                /// 获取或设置文件类型的字段值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_file")]
                [System.Text.Json.Serialization.JsonPropertyName("value_file")]
                public Types.FileValue? FileValue { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fieldinfo")]
        [System.Text.Json.Serialization.JsonPropertyName("fieldinfo")]
        public Types.Field[] FieldList { get; set; } = default!;
    }
}
