namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/qic/inspect/config/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECQICInspectConfigGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class InspectConfig
            {
                public static class Types
                {
                    public class Address
                    {
                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string Province { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string City { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区县。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("county")]
                        [System.Text.Json.Serialization.JsonPropertyName("county")]
                        public string District { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail")]
                        public string Detail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_name")]
                        public string ContactName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_phone")]
                        public string ContactPhoneNumber { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置质检仓 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouse_id")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                public string WarehouseId { get; set; } = default!;

                /// <summary>
                /// 获取或设置质检仓名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouse_name")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouse_name")]
                public string WarehouseName { get; set; } = default!;

                /// <summary>
                /// 获取或设置质检仓地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouse_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouse_addr")]
                public string WarehouseAddress { get; set; } = default!;

                /// <summary>
                /// 获取或设置发货地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_address")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_address")]
                public Types.Address DeliveryReceiver { get; set; } = default!;

                /// <summary>
                /// 获取或设置退货地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_address")]
                [System.Text.Json.Serialization.JsonPropertyName("return_address")]
                public Types.Address ReturnAddress { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置质检仓配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inspect_config")]
        [System.Text.Json.Serialization.JsonPropertyName("inspect_config")]
        public Types.InspectConfig InspectConfig { get; set; } = default!;
    }
}
