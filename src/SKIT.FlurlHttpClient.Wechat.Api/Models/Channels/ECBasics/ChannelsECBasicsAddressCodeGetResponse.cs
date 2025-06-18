namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/addresscode/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsAddressCodeGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AddressInfo
            {
                /// <summary>
                /// 获取或设置地址名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置地址行政编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public int Code { get; set; }

                /// <summary>
                /// 获取或设置地址级别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public int Level { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置本行政编码地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrs_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("addrs_msg")]
        public Types.AddressInfo AddressInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置下一级地址列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_level_addrs")]
        [System.Text.Json.Serialization.JsonPropertyName("next_level_addrs")]
        public Types.AddressInfo[]? NextLevelAddressList { get; set; }
    }
}
