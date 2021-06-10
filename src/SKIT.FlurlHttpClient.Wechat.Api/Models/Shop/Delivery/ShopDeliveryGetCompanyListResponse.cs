using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/delivery/get_company_list 接口的响应。</para>
    /// </summary>
    public class ShopDeliveryGetCompanyListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DeliveryCompanyList
            {
                /// <summary>
                /// 获取或设置快递公司列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_list")]
                [System.Text.Json.Serialization.JsonPropertyName("company_list")]
                public DeliveryCompanyItem[] Items { get; set; } = default!;
            }

            public class DeliveryCompanyItem
            {
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
            }
        }

        /// <summary>
        /// 获取或设置快递公司列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.DeliveryCompanyList DeliveryCompanyList { get; set; } = default!;
    }
}
