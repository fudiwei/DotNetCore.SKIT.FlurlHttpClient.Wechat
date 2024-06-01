namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/trustdevice/import 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityTrustDeviceImportResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置导入设备记录的顺序。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_index")]
                [System.Text.Json.Serialization.JsonPropertyName("device_index")]
                public int DeviceIndex { get; set; }

                /// <summary>
                /// 获取或设置设备的唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_code")]
                [System.Text.Json.Serialization.JsonPropertyName("device_code")]
                public string? DeviceCode { get; set; }

                /// <summary>
                /// 获取或设置冲突设备的唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("duplicated_device_code")]
                [System.Text.Json.Serialization.JsonPropertyName("duplicated_device_code")]
                public string? DuplicatedDeviceCode { get; set; }

                /// <summary>
                /// 获取或设置导入结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
