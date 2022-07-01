namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/business/get 接口的响应。</para>
    /// </summary>
    public class CgibinBusinessGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BusinessInfo
            {
                /// <summary>
                /// 获取或设置商户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_id")]
                [System.Text.Json.Serialization.JsonPropertyName("business_id")]
                public long BusinessId { get; set; }

                /// <summary>
                /// 获取或设置商户账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                public string AccountName { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("icon_url")]
                [System.Text.Json.Serialization.JsonPropertyName("icon_url")]
                public string IconUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_info")]
        [System.Text.Json.Serialization.JsonPropertyName("business_info")]
        public Types.BusinessInfo BusinessInfo { get; set; } = default!;
    }
}
