namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/updatestore 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityUpdateStoreRequest : WechatApiRequest, IInferable<CgibinExpressIntracityUpdateStoreRequest, CgibinExpressIntracityUpdateStoreResponse>
    {
        public static class Types
        {
            public class Key
            {
                /// <summary>
                /// 获取或设置商家自定义门店 ID。与字段 <see cref="StoreId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_store_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_store_id")]
                public string? OutStoreId { get; set; }

                /// <summary>
                /// 获取或设置微信门店编号。与字段 <see cref="OutStoreId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wx_store_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
                public string? StoreId { get; set; }
            }

            public class Content
            {
                public static class Types
                {
                    public class AddressInfo : CgibinExpressIntracityCreateStoreRequest.Types.AddressInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                public string? StoreName { get; set; }

                /// <summary>
                /// 获取或设置运力偏好类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_pattern")]
                [System.Text.Json.Serialization.JsonPropertyName("order_pattern")]
                public int? OrderPatternType { get; set; }

                /// <summary>
                /// 获取或设置优先使用的运力 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_trans_prefer")]
                [System.Text.Json.Serialization.JsonPropertyName("service_trans_prefer")]
                public string? ServiceTransIdPrefer { get; set; }

                /// <summary>
                /// 获取或设置门店地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_info")]
                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                public Types.AddressInfo? AddressInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keys")]
        [System.Text.Json.Serialization.JsonPropertyName("keys")]
        public Types.Key Key { get; set; } = new Types.Key();

        /// <summary>
        /// 获取或设置更新内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public Types.Content Content { get; set; } = new Types.Content();
    }
}
