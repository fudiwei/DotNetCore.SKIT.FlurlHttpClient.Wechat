namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/getfreighttemplatedetail 接口的响应。</para>
    /// </summary>
    public class ChannelsECMerchantGetFreightTemplateDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class FreightTemplate : ChannelsECMerchantAddFreightTemplateRequest.Types.__zz__FreightTemplate
            {
                public static class Types
                {
                    public class Address : ChannelsECMerchantAddFreightTemplateRequest.Types.FreightTemplate.Types.Address
                    {
                    }

                    public class Area
                    {
                        /// <summary>
                        /// 获取或设置地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                        public List<Address>? AddressList { get; set; }
                    }

                    public class ConditionFreeDetailItem : ChannelsECMerchantAddFreightTemplateRequest.Types.FreightTemplate.Types.__zz__ConditionFreeDetailItem
                    {
                        /// <summary>
                        /// 获取或设置包邮地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("address_infos")]
                        public List<Address>? AddressList { get; set; }
                    }

                    public class ConditionFreeDetailList
                    {
                        /// <summary>
                        /// 获取或设置条件包邮详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("condition_free_detail_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("condition_free_detail_list")]
                        public List<ConditionFreeDetailItem>? Items { get; set; }
                    }

                    public class FreightCalculateMethodItem : ChannelsECMerchantAddFreightTemplateRequest.Types.FreightTemplate.Types.__zz__FreightCalculateMethodItem
                    {
                        /// <summary>
                        /// 获取或设置指定地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                        public List<Address>? AddressList { get; set; }
                    }

                    public class FreightCalculateMethodList
                    {
                        /// <summary>
                        /// 获取或设置指定地区具体计费方法列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight_calc_method_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("freight_calc_method_list")]
                        public List<FreightCalculateMethodItem>? Items { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置运费模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long TemplateId { get; set; }

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

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置运费模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freight_template")]
        [System.Text.Json.Serialization.JsonPropertyName("freight_template")]
        public Types.FreightTemplate? FreightTemplate { get; set; }
    }
}
