namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/createstore 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityCreateStoreRequest : WechatApiRequest, IInferable<CgibinExpressIntracityCreateStoreRequest, CgibinExpressIntracityCreateStoreResponse>
    {
        public static class Types
        {
            public class AddressInfo
            {
                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string Province { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                public string District { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置街道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("street")]
                [System.Text.Json.Serialization.JsonPropertyName("street")]
                public string Street { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("house")]
                [System.Text.Json.Serialization.JsonPropertyName("house")]
                public string Address { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lng")]
                [System.Text.Json.Serialization.JsonPropertyName("lng")]
                public double Longitude { get; set; }

                /// <summary>
                /// 获取或设置纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lat")]
                [System.Text.Json.Serialization.JsonPropertyName("lat")]
                public double Latitude { get; set; }

                /// <summary>
                /// 获取或设置门店联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string PhoneNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置商家自定义门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_store_id")]
        public string OutStoreId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_name")]
        [System.Text.Json.Serialization.JsonPropertyName("store_name")]
        public string StoreName { get; set; } = string.Empty;

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
