namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/group/removedevice 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGroupRemoveDeviceResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result : WxaBusinessGroupAddDeviceResponse.Types.Result
            {
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
