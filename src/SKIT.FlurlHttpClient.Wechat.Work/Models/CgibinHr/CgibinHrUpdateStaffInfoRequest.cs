using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/hr/update_staff_info 接口的请求。</para>
    /// </summary>
    public class CgibinHrUpdateStaffInfoRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class UpdatedItem
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
                        public string CountryCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_mobile")]
                        public string MobileNumber { get; set; } = string.Empty;
                    }

                    public class FileValue
                    {
                        /// <summary>
                        /// 获取或设置文件 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public IList<string> MediaIdList { get; set; } = new List<string>();
                    }
                }

                /// <summary>
                /// 获取或设置字段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fieldid")]
                [System.Text.Json.Serialization.JsonPropertyName("fieldid")]
                public int FieldId { get; set; }

                /// <summary>
                /// 获取或设置需要获取的字段下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_idx")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_idx")]
                public int? SubIndex { get; set; }

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

            public class InsertedItem
            {
                public static class Types
                {
                    public class Field : UpdatedItem
                    {
                    }
                }

                /// <summary>
                /// 获取或设置字段组类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_type")]
                [System.Text.Json.Serialization.JsonPropertyName("group_type")]
                public int GroupType { get; set; }

                /// <summary>
                /// 获取或设置字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item")]
                [System.Text.Json.Serialization.JsonPropertyName("item")]
                public IList<Types.Field> FieldList { get; set; } = new List<Types.Field>();
            }

            public class RemovedItem
            {
                /// <summary>
                /// 获取或设置字段组类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_type")]
                [System.Text.Json.Serialization.JsonPropertyName("group_type")]
                public int GroupType { get; set; }

                /// <summary>
                /// 获取或设置字段组下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_idx")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_idx")]
                public int SubIndex { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置需要更新的项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_items")]
        [System.Text.Json.Serialization.JsonPropertyName("update_items")]
        public IList<Types.UpdatedItem>? UpdatedItemList { get; set; }

        /// <summary>
        /// 获取或设置需要新增的项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insert_items")]
        [System.Text.Json.Serialization.JsonPropertyName("insert_items")]
        public IList<Types.InsertedItem>? InsertedItemList { get; set; }

        /// <summary>
        /// 获取或设置需要删除的项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remove_items")]
        [System.Text.Json.Serialization.JsonPropertyName("remove_items")]
        public IList<Types.RemovedItem>? RemovedItemList { get; set; }
    }
}
