namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/account/get_info 接口的响应。</para>
    /// </summary>
    public class ShopAccountGetInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置客服页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_agent_path")]
                [System.Text.Json.Serialization.JsonPropertyName("service_agent_path")]
                public string? ServiceAgentPagePath { get; set; }

                /// <summary>
                /// 获取或设置客服联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_agent_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("service_agent_phone")]
                public string? ServiceAgentPhoneNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
