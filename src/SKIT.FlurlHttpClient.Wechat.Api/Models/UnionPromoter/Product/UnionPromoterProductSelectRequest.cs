using System;
using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/product/select 接口的请求。</para>
    /// </summary>
    public class UnionPromoterProductSelectRequest : WechatApiRequest, IMapResponse<UnionPromoterProductSelectRequest, UnionPromoterProductSelectResponse>
    {
        public static class Types
        {
            public class ShippingMethods
            {
                /// <summary>
                /// 获取或设置是否开启快递配送。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("express")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsOpenExpress { get; set; }

                /// <summary>
                /// 获取或设置是否开启同城配送。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("same_city")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("same_city")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsOpenSameCity { get; set; }

                /// <summary>
                /// 获取或设置是否开启线下自提。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pickup")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("pickup")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsOpenPickup { get; set; }
            }

            public class Address
            {
                public static class Types
                {
                    public class AddressInformation
                    {
                        /// <summary>
                        /// 获取或设置省份名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("provinceName")]
                        [System.Text.Json.Serialization.JsonPropertyName("provinceName")]
                        public string ProvinceName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置城市名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cityName")]
                        [System.Text.Json.Serialization.JsonPropertyName("cityName")]
                        public string CityName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置区县名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("countyName")]
                        [System.Text.Json.Serialization.JsonPropertyName("countyName")]
                        public string DistrictName { get; set; } = string.Empty;
                    }

                    public class AddressType : ShippingMethods
                    { 
                    }
                }

                /// <summary>
                /// 获取或设置地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("addressInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("addressInfo")]
                public Types.AddressInformation AddressInformation { get; set; } = new Types.AddressInformation();

                /// <summary>
                /// 获取或设置地址类型信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("addressType")]
                [System.Text.Json.Serialization.JsonPropertyName("addressType")]
                public Types.AddressType? AddressType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 20;

        /// <summary>
        /// 获取或设置商品最高价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? MaxPrice { get; set; }

        /// <summary>
        /// 获取或设置商品最低价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? MinPrice { get; set; }

        /// <summary>
        /// 获取或设置佣金金额下限（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? MinCommissionValue { get; set; }

        /// <summary>
        /// 获取或设置佣金比例下限（单位：万分之一）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? MinCommissionRatio { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? SortType { get; set; }

        /// <summary>
        /// 获取或设置小商店 AppId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string>? ShopAppIdList { get; set; }

        /// <summary>
        /// 获取或设置是否有联盟优惠券。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool? HasCoupon { get; set; }

        /// <summary>
        /// 获取或设置商品类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? CategoryId { get; set; }

        /// <summary>
        /// 获取或设置商品类目 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<int>? CategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置商品类目 ID 黑名单列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<int>? CategoryIdBlackList { get; set; }

        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<long>? ProductIdList { get; set; }

        /// <summary>
        /// 获取或设置配送方式信息。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Types.ShippingMethods? ShippingMethods { get; set; }

        /// <summary>
        /// 获取或设置发货地址列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<Types.Address>? AddressList { get; set; }
    }
}
