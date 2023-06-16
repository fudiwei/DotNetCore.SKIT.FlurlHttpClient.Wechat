namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/group/getinfo 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGroupGetInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Device
            {
                /// <summary>
                /// 获取或设置设备型号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("model_id")]
                [System.Text.Json.Serialization.JsonPropertyName("model_id")]
                public string ModelId { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sn")]
                [System.Text.Json.Serialization.JsonPropertyName("sn")]
                public string SerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置设备型号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_id")]
        [System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_type")]
        [System.Text.Json.Serialization.JsonPropertyName("model_type")]
        public string ModelType { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_name")]
        [System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string GroupName { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_list")]
        public Types.Device[] DeviceList { get; set; } = default!;
    }
}
