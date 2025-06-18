namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/get_device_detail 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceGetDeviceDetailResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class DeviceDetail
            {
                public static class Types
                {
                    public class BindCorp
                    {
                        /// <summary>
                        /// 获取或设置服务商主体下的密文 CorpId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_corpid")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_corpid")]
                        public string OpenCorpId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置企业名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("corp_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置设备二维码数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qr_code")]
                [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
                public string QrcodeData { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备型号名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("model_name")]
                [System.Text.Json.Serialization.JsonPropertyName("model_name")]
                public string? ModelName { get; set; }

                /// <summary>
                /// 获取或设置设备出厂名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_name")]
                [System.Text.Json.Serialization.JsonPropertyName("default_name")]
                public string? DefaultName { get; set; }

                /// <summary>
                /// 获取或设置设备备注名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark_name")]
                [System.Text.Json.Serialization.JsonPropertyName("remark_name")]
                public string? RemarkName { get; set; }

                /// <summary>
                /// 获取或设置绑定状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_status")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
                public int BindStatus { get; set; }

                /// <summary>
                /// 获取或设置绑定方企业信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_corpinfo")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_corpinfo")]
                public Types.BindCorp? BindCorp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置设备详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("device_detail")]
        public Types.DeviceDetail DeviceDetail { get; set; } = default!;
    }
}
