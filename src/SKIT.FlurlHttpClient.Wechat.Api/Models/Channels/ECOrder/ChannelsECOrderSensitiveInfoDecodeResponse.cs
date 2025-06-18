using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/sensitiveinfo/decode 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderSensitiveInfoDecodeResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Address
            {
                /// <summary>
                /// 获取或设置收件人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string UserName { get; set; } = default!;

                /// <summary>
                /// 获取或设置邮政编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("postal_code")]
                [System.Text.Json.Serialization.JsonPropertyName("postal_code")]
                public string? PostalCode { get; set; }

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_name")]
                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                public string? ProvinceName { get; set; }

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_name")]
                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                public string? CityName { get; set; }

                /// <summary>
                /// 获取或设置区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("county_name")]
                [System.Text.Json.Serialization.JsonPropertyName("county_name")]
                public string? DistrictName { get; set; }

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_info")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_info")]
                public string? Detail { get; set; }

                /// <summary>
                /// 获取或设置电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tel_number")]
                [System.Text.Json.Serialization.JsonPropertyName("tel_number")]
                public string TelNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置门牌号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("house_number")]
                [System.Text.Json.Serialization.JsonPropertyName("house_number")]
                public string? HouseNumber { get; set; }

                /// <summary>
                /// 获取或设置虚拟发货订单联系方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("virtual_order_tel_number")]
                [System.Text.Json.Serialization.JsonPropertyName("virtual_order_tel_number")]
                public string? VirtualOrderTelNumber { get; set; }
            }

            public class VirtualNumber
            {
                /// <summary>
                /// 获取或设置虚拟号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("virtual_number")]
                [System.Text.Json.Serialization.JsonPropertyName("virtual_number")]
                public string TelNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置分机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extension")]
                [System.Text.Json.Serialization.JsonPropertyName("extension")]
                public string? Extension { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expiration")]
                [System.Text.Json.Serialization.JsonPropertyName("expiration")]
                public long ExpirationTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_info")]
        [System.Text.Json.Serialization.JsonPropertyName("address_info")]
        public Types.Address? Address { get; set; }

        /// <summary>
        /// 获取或设置虚拟号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("virtual_number_info")]
        [System.Text.Json.Serialization.JsonPropertyName("virtual_number_info")]
        public Types.VirtualNumber? VirtualNumber { get; set; }
    }
}
