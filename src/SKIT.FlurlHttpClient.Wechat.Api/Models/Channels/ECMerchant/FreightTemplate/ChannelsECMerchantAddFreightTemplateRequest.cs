﻿using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/addfreighttemplate 接口的请求。</para>
    /// </summary>
    public class ChannelsECMerchantAddFreightTemplateRequest : WechatApiRequest, IInferable<ChannelsECMerchantAddFreightTemplateRequest, ChannelsECMerchantAddFreightTemplateResponse>
    {
        public static class Types
        {
            public class FreightTemplate
            {
                public static class Types
                {
                    public class Address
                    {
                        /// <summary>
                        /// 获取或设置联系人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                        public string UserName { get; set; } = string.Empty;

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
                        public string ProvinceName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                        public string CityName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置区县。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("county_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("county_name")]
                        public string DistrictName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail_info")]
                        public string Detail { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置国家码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("national_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("national_code")]
                        public string? NationalCode { get; set; }

                        /// <summary>
                        /// 获取或设置电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tel_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("tel_number")]
                        public string TeleNumber { get; set; } = string.Empty;

                    }

                    public class Area
                    {
                        /// <summary>
                        /// 获取或设置地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                        public IList<Address> AddressList { get; set; } = new List<Address>();
                    }

                    public class ConditionFreeDetailItem
                    {
                        /// <summary>
                        /// 获取或设置包邮地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("address_infos")]
                        public IList<Address> AddressList { get; set; } = new List<Address>();

                        /// <summary>
                        /// 获取或设置包邮最低件数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min_piece")]
                        [System.Text.Json.Serialization.JsonPropertyName("min_piece")]
                        public int? MinPiece { get; set; }

                        /// <summary>
                        /// 获取或设置包邮最低金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("min_amount")]
                        public int? MinAmount { get; set; }

                        /// <summary>
                        /// 获取或设置包邮最低重量（单位：千克）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min_weight")]
                        [System.Text.Json.Serialization.JsonPropertyName("min_weight")]
                        public int? MinWeight { get; set; }

                        /// <summary>
                        /// 获取或设置计费方式对应选项是否已经设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valuation_flag")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("valuation_flag")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool? HasSetValuation { get; set; }

                        /// <summary>
                        /// 获取或设置金额是否设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount_flag")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("amount_flag")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool? HasSetAmount { get; set; }
                    }

                    public class ConditionFreeDetailList
                    {
                        /// <summary>
                        /// 获取或设置条件包邮详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("condition_free_detail_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("condition_free_detail_list")]
                        public IList<ConditionFreeDetailItem> Items { get; set; } = new List<ConditionFreeDetailItem>();
                    }

                    public class FreightCalculateMethodItem
                    {
                        /// <summary>
                        /// 获取或设置指定地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                        public IList<Address> AddressList { get; set; } = new List<Address>();

                        /// <summary>
                        /// 获取或设置是否为默认运费。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_default")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_default")]
                        public bool IsDefault { get; set; }

                        /// <summary>
                        /// 获取或设置快递公司 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                        public string? DeliveryId { get; set; }

                        /// <summary>
                        /// 获取或设置首段运费满足重量（单位：千克）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_val_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_val_amount")]
                        public int FirstValueWeight { get; set; }

                        /// <summary>
                        /// 获取或设置首段运费的金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_price")]
                        public int FirstValuePrice { get; set; }

                        /// <summary>
                        /// 获取或设置增量运费满足重量（单位：千克）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_val_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_val_amount")]
                        public int SecondValueWeight { get; set; }

                        /// <summary>
                        /// 获取或设置增量运费的金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_price")]
                        public int SecondValuePrice { get; set; }
                    }

                    public class FreightCalculateMethodList
                    {
                        /// <summary>
                        /// 获取或设置指定地区具体计费方法列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight_calc_method_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("freight_calc_method_list")]
                        public IList<FreightCalculateMethodItem> Items { get; set; } = new List<FreightCalculateMethodItem>();
                    }
                }

                /// <summary>
                /// 获取或设置模板名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置计费类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valuation_type")]
                [System.Text.Json.Serialization.JsonPropertyName("valuation_type")]
                public string ValuationType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发货时间类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_time")]
                [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                public string SendTimeType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置快递方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_type")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                public string DeliveryType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置快递公司 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public IList<string>? DeliveryIdList { get; set; }

                /// <summary>
                /// 获取或设置配送方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_method")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_method")]
                public string ShippingMethod { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发货地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_info")]
                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                public Types.Address? SendAddress { get; set; }

                /// <summary>
                /// 获取或设置不发货地区信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("not_send_area")]
                [System.Text.Json.Serialization.JsonPropertyName("not_send_area")]
                public Types.Area? NotSupportedArea { get; set; }

                /// <summary>
                /// 获取或设置是否为默认模版。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_default")]
                [System.Text.Json.Serialization.JsonPropertyName("is_default")]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// 获取或设置条件包邮详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("all_condition_free_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("all_condition_free_detail")]
                public Types.ConditionFreeDetailList? ConditionFreeDetailList { get; set; }

                /// <summary>
                /// 获取或设置指定地区具体计费方法信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("all_freight_calc_method")]
                [System.Text.Json.Serialization.JsonPropertyName("all_freight_calc_method")]
                public Types.FreightCalculateMethodList? FreightCalculateMethodList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置运费模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freight_template")]
        [System.Text.Json.Serialization.JsonPropertyName("freight_template")]
        public Types.FreightTemplate FreightTemplate { get; set; } = new Types.FreightTemplate();
    }
}
