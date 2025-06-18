namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/license/activedevice 接口的响应。</para>
    /// </summary>
    public class WxaBusinessLicenseActiveDeviceResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
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
                /// 获取或设置设备过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_list")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
