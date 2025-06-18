namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/preaddorder 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityPreAddOrderRequest : WechatApiRequest, IInferable<CgibinExpressIntracityPreAddOrderRequest, CgibinExpressIntracityPreAddOrderResponse>
    {
        public static class Types
        {
            public class CargoInfo
            {
                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_name")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_name")]
                public string CargoName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_type")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_type")]
                public int CargoType { get; set; }

                /// <summary>
                /// 获取或设置商品重量（单位：克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_weight")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_weight")]
                public int CargoWeight { get; set; }

                /// <summary>
                /// 获取或设置商品价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_price")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_price")]
                public int CargoPrice { get; set; }

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_num")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_num")]
                public int CargoCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string StoreId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收件人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收件人手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("user_phone")]
        public string UserPhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收件用户位置经度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_lng")]
        [System.Text.Json.Serialization.JsonPropertyName("user_lng")]
        public decimal UserLongitude { get; set; }

        /// <summary>
        /// 获取或设置收件用户位置维度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_lat")]
        [System.Text.Json.Serialization.JsonPropertyName("user_lat")]
        public decimal UserLatitude { get; set; }

        /// <summary>
        /// 获取或设置收件用户详细地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_address")]
        [System.Text.Json.Serialization.JsonPropertyName("user_address")]
        public string UserAddress { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public Types.CargoInfo CargoInfo { get; set; } = new Types.CargoInfo();

        /// <summary>
        /// 获取或设置是否使用沙箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_sandbox")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("use_sandbox")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsSandbox { get; set; }
    }
}
