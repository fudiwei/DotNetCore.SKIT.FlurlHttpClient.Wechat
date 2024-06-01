using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/trustdevice/import 接口的请求。</para>
    /// </summary>
    public class CgibinSecurityTrustDeviceImportRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Device
            {
                /// <summary>
                /// 获取或设置设备系统。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("system")]
                [System.Text.Json.Serialization.JsonPropertyName("system")]
                public string System { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置 MAC 地址列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mac_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("mac_addr")]
                public IList<string>? MacAddressList { get; set; }

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
                public IList<string>? HardDistUUIDList { get; set; }

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
            }
        }

        /// <summary>
        /// 获取或设置设备列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_list")]
        public IList<Types.Device> DeviceList { get; set; } = new List<Types.Device>();
    }
}
