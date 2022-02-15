using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/address/add 接口的请求。</para>
    /// </summary>
    public class ProductAddressAddRequest : WechatApiRequest, IMapResponse<ProductAddressAddRequest, ProductAddressAddResponse>
    {
        public static class Types
        {
            public class Address
            {
                public static class Types
                {
                    public class AddressInformation
                    {
                        /// <summary>
                        /// 获取或设置联系人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                        public string Name { get; set; } = string.Empty;

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
                        public string Province { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                        public string City { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置区县。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("county_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("county_name")]
                        public string District { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail_info")]
                        public string AddressDetail { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置国家码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("national_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("national_code")]
                        public int? NationalCode { get; set; }

                        /// <summary>
                        /// 获取或设置电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tel_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("tel_number")]
                        public string TeleNumber { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置经度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lng")]
                        [System.Text.Json.Serialization.JsonPropertyName("lng")]
                        public double? Longitude { get; set; }

                        /// <summary>
                        /// 获取或设置纬度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lat")]
                        [System.Text.Json.Serialization.JsonPropertyName("lat")]
                        public double? Latitude { get; set; }

                        /// <summary>
                        /// 获取或设置门牌号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("house_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("house_number")]
                        public string? HouseNumber { get; set; }
                    }

                    public class AddressType
                    {
                        /// <summary>
                        /// 获取或设置是否为同城配送地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("same_city")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("same_city")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsSupportSameCity { get; set; }

                        /// <summary>
                        /// 获取或设置是否为线下自提地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pickup")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("pickup")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsSupportPickup { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_info")]
                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                public Types.AddressInformation AddressInformation { get; set; } = new Types.AddressInformation();

                /// <summary>
                /// 获取或设置地址类型信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_type")]
                [System.Text.Json.Serialization.JsonPropertyName("address_type")]
                public Types.AddressType? AddressType { get; set; }

                /// <summary>
                /// 获取或设置座机。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("landline")]
                [System.Text.Json.Serialization.JsonPropertyName("landline")]
                public string? Landline { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置是否为发货地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_addr")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("send_addr")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsSendAddress { get; set; }

                /// <summary>
                /// 获取或设置是否为默认发货地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_send")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("default_send")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsDefaultSendAddress { get; set; }

                /// <summary>
                /// 获取或设置是否为收货地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recv_addr")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("recv_addr")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsReceiveAddress { get; set; }

                /// <summary>
                /// 获取或设置是否为默认收货地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_recv")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("default_recv")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsDefaultReceiveAddress { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
        public Types.Address Address { get; set; } = new Types.Address();
    }
}
