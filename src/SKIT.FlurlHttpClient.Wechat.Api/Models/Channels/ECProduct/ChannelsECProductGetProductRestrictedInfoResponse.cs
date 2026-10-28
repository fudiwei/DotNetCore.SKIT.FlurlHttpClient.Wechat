namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/getproductrestrictedinfo 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductGetProductRestrictedInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class RestrictedInfo
                    {
                        public static class Types
                        {
                            public class SceneInfo
                            {
                                /// <summary>
                                /// 获取或设置受限场景。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scene")]
                                [System.Text.Json.Serialization.JsonPropertyName("scene")]
                                public int Scene { get; set; }

                                /// <summary>
                                /// 获取或设置策略来源。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("source")]
                                [System.Text.Json.Serialization.JsonPropertyName("source")]
                                public int Source { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置受限场景列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
                        public List<Types.SceneInfo>? SceneInfoList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品受限信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("restricted_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("restricted_info_list")]
                public List<Types.RestrictedInfo>? RestrictedInfoList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data? Data { get; set; }
    }
}
