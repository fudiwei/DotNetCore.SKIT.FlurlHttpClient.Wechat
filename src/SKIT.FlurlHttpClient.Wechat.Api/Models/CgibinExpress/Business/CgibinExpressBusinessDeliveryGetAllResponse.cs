using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/express/business/delivery/getall 接口的响应。</para>
    /// </summary>
    public class CgibinExpressBusinessDeliveryGetAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DeliveryCompany
            {
                public static class Types
                {
                    public class Service
                    {
                        /// <summary>
                        /// 获取或设置服务类型 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_type")]
                        public int ServiceType { get; set; }

                        /// <summary>
                        /// 获取或设置服务类型名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_name")]
                        public string ServiceName { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_name")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
                public string DeliveryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否支持散单。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_use_cash")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("can_use_cash")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? CanUseCash { get; set; }

                /// <summary>
                /// 获取或设置是否支持查询面单余额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_get_quota")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("can_get_quota")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? CanUseQuota { get; set; }

                /// <summary>
                /// 获取或设置散单对应的快递公司客户编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash_biz_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cash_biz_id")]
                public string? CashBusinessId { get; set; }

                /// <summary>
                /// 获取或设置支持的服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_type")]
                [System.Text.Json.Serialization.JsonPropertyName("service_type")]
                public Types.Service[]? ServiceList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置快递公司列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.DeliveryCompany[] DeliveryCompanyList { get; set; } = default!;

        /// <summary>
        /// 获取或设置快递公司数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
