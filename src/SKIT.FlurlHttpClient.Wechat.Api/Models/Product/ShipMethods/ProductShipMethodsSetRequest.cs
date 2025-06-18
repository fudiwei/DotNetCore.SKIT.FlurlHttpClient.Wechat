namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/shipmethods/set 接口的请求。</para>
    /// </summary>
    public class ProductShipMethodsSetRequest : WechatApiRequest, IInferable<ProductShipMethodsSetRequest, ProductShipMethodsSetResponse>
    {
        public static class Types
        {
            public class ShippingMethods
            {
                /// <summary>
                /// 获取或设置是否开启快递配送。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("express")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsOpenExpress { get; set; }

                /// <summary>
                /// 获取或设置是否开启同城配送。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("same_city")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("same_city")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsOpenSameCity { get; set; }

                /// <summary>
                /// 获取或设置是否开启线下自提。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pickup")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("pickup")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsOpenPickup { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置配送方式信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supported_shipping_methods")]
        [System.Text.Json.Serialization.JsonPropertyName("supported_shipping_methods")]
        public Types.ShippingMethods ShippingMethods { get; set; } = new Types.ShippingMethods();
    }
}
