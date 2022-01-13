namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_device_auth_info 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetDeviceAuthInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AuthorizerCorp : CgibinServiceGetAuthInfoResponse.Types.DealerCorp
            {
            }

            public class Device
            {
                /// <summary>
                /// 获取或设置设备型号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("model_id")]
                [System.Text.Json.Serialization.JsonPropertyName("model_id")]
                public string ModelId { get; set; } = default!;

                /// <summary>
                /// 获取或设置备注名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark_name")]
                [System.Text.Json.Serialization.JsonPropertyName("remark_name")]
                public string? RemarkName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置授权方企业信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_corp_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_corp_info")]
        public Types.AuthorizerCorp AuthorizerCorp { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_info")]
        [System.Text.Json.Serialization.JsonPropertyName("device_info")]
        public Types.Device Device { get; set; } = default!;
    }
}
