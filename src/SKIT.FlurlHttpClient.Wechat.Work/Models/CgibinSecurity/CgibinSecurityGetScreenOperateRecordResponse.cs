namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/get_screen_oper_record 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityGetScreenOperateRecordResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Record
            {
                public static class Types
                {
                    public class DeviceInfo
                    {
                        public static class Types
                        {
                            public class WindowsDevice
                            {
                                /// <summary>
                                /// 获取或设置 MAC 地址列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mac_addr")]
                                [System.Text.Json.Serialization.JsonPropertyName("mac_addr")]
                                public string[]? MacAddressList { get; set; }

                                /// <summary>
                                /// 获取或设置主板 UUID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("motherboard_uuid")]
                                [System.Text.Json.Serialization.JsonPropertyName("motherboard_uuid")]
                                public string? MotherboardUUID { get; set; }

                                /// <summary>
                                /// 获取或设置硬盘 UUID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("harddisk_uuid")]
                                [System.Text.Json.Serialization.JsonPropertyName("harddisk_uuid")]
                                public string[]? HardDiskUUIDList { get; set; }

                                /// <summary>
                                /// 获取或设置域名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("domain")]
                                [System.Text.Json.Serialization.JsonPropertyName("domain")]
                                public string? Domain { get; set; }

                                /// <summary>
                                /// 获取或设置计算机名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pc_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("pc_name")]
                                public string? PCName { get; set; }
                            }

                            public class MacDevice
                            {
                                /// <summary>
                                /// 获取或设置 MAC 地址列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mac_addr")]
                                [System.Text.Json.Serialization.JsonPropertyName("mac_addr")]
                                public string[]? MacAddressList { get; set; }

                                /// <summary>
                                /// 获取或设置序列号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seq_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("seq_no")]
                                public string? SequenceNumber { get; set; }
                            }

                            public class MobileDevice
                            {
                                /// <summary>
                                /// 获取或设置设备类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置平台类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform")]
                        public string? Platform { get; set; }

                        /// <summary>
                        /// 获取或设置设备唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("device_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("device_code")]
                        public string? DeviceCode { get; set; }

                        /// <summary>
                        /// 获取或设置设备型号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("device_model")]
                        [System.Text.Json.Serialization.JsonPropertyName("device_model")]
                        public string? DeviceModel { get; set; }

                        /// <summary>
                        /// 获取或设置 Windows 设备信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("windows")]
                        [System.Text.Json.Serialization.JsonPropertyName("windows")]
                        public Types.WindowsDevice? WindowsDevice { get; set; }

                        /// <summary>
                        /// 获取或设置 Mac 设备信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mac")]
                        [System.Text.Json.Serialization.JsonPropertyName("mac")]
                        public Types.MacDevice? MacDevice { get; set; }

                        /// <summary>
                        /// 获取或设置移动设备信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                        public Types.MobileDevice? MobileDevice { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置操作者 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作者部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_id")]
                [System.Text.Json.Serialization.JsonPropertyName("department_id")]
                public long DepartmentId { get; set; }

                /// <summary>
                /// 获取或设置截屏操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operation_type")]
                [System.Text.Json.Serialization.JsonPropertyName("operation_type")]
                public int OperationType { get; set; }

                /// <summary>
                /// 获取或设置截屏内容类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("screen_shot_type")]
                [System.Text.Json.Serialization.JsonPropertyName("screen_shot_type")]
                public int ScreenshotType { get; set; }

                /// <summary>
                /// 获取或设置截屏内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("screen_shot_content")]
                [System.Text.Json.Serialization.JsonPropertyName("screen_shot_content")]
                public string ScreenshotContent { get; set; } = default!;

                /// <summary>
                /// 获取或设置时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置用户的操作系统。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("system")]
                [System.Text.Json.Serialization.JsonPropertyName("system")]
                public string? System { get; set; }

                /// <summary>
                /// 获取或设置设备 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ip")]
                [System.Text.Json.Serialization.JsonPropertyName("ip")]
                public string? Ip { get; set; }

                /// <summary>
                /// 获取或设置设备信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_info")]
                [System.Text.Json.Serialization.JsonPropertyName("device_info")]
                public Types.DeviceInfo? DeviceInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_list")]
        [System.Text.Json.Serialization.JsonPropertyName("record_list")]
        public Types.Record[] RecordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
