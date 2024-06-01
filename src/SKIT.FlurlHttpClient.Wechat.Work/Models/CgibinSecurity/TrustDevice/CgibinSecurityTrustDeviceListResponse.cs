namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/trustdevice/list 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityTrustDeviceListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Device
            {
                /// <summary>
                /// 获取或设置设备的唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_code")]
                [System.Text.Json.Serialization.JsonPropertyName("device_code")]
                public string DeviceCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备系统。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("system")]
                [System.Text.Json.Serialization.JsonPropertyName("system")]
                public string System { get; set; } = default!;

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
                public string[]? HarddistUUIDList { get; set; }

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

                /// <summary>
                /// 获取或设置序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seq_no")]
                [System.Text.Json.Serialization.JsonPropertyName("seq_no")]
                public string? SequenceNumber { get; set; }

                /// <summary>
                /// 获取或设置最后登录时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("last_login_time")]
                [System.Text.Json.Serialization.JsonPropertyName("last_login_time")]
                public long? LastLoginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置最后登录成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("last_login_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("last_login_userid")]
                public string? LastLoginUserId { get; set; }

                /// <summary>
                /// 获取或设置归属确认时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("confirm_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("confirm_timestamp")]
                public long? ConfirmTimestamp { get; set; }

                /// <summary>
                /// 获取或设置归属确认成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("confirm_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("confirm_userid")]
                public string? ConfirmUserId { get; set; }

                /// <summary>
                /// 获取或设置通过申报的管理员成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("approved_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("approved_userid")]
                public string? ApprovedUserId { get; set; }

                /// <summary>
                /// 获取或设置设备来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public int Source { get; set; }

                /// <summary>
                /// 获取或设置导入结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置设备列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_list")]
        public Types.Device[] DeviceList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
