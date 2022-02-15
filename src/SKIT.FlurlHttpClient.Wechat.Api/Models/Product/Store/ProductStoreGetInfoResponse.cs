namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/store/get_info 接口的响应。</para>
    /// </summary>
    public class ProductStoreGetInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Store
            {
                /// <summary>
                /// 获取或设置店铺类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置店铺名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                public string StoreName { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logo")]
                [System.Text.Json.Serialization.JsonPropertyName("logo")]
                public string LogoUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置店铺信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Store Store { get; set; } = default!;
    }
}
