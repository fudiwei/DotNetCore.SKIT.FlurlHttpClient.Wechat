using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/batchcreateretail 接口的请求。</para>
    /// </summary>
    public class WxaBusinessBatchCreateRetailRequest : WechatApiRequest, IInferable<WxaBusinessBatchCreateRetailRequest, WxaBusinessBatchCreateRetailResponse>
    {
        public static class Types
        {
            public class RetailInfo
            {
                /// <summary>
                /// 获取或设置一级类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("retail_type")]
                [System.Text.Json.Serialization.JsonPropertyName("retail_type")]
                public string RetailType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置二级类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_retail_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_retail_type")]
                public string? RetailSubType { get; set; }

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("retail_name")]
                [System.Text.Json.Serialization.JsonPropertyName("retail_name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店地址省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_province")]
                [System.Text.Json.Serialization.JsonPropertyName("address_province")]
                public string Province { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店地址城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_city")]
                [System.Text.Json.Serialization.JsonPropertyName("address_city")]
                public string City { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店地址区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_region")]
                [System.Text.Json.Serialization.JsonPropertyName("address_region")]
                public string District { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店地址街道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_street")]
                [System.Text.Json.Serialization.JsonPropertyName("address_street")]
                public string Street { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店负责人的手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                public string Mobilephone { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_name")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_name")]
                public string? BusinessName { get; set; }

                /// <summary>
                /// 获取或设置营业执照注册号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("registration_number")]
                [System.Text.Json.Serialization.JsonPropertyName("registration_number")]
                public string? RegistrationNumber { get; set; }

                /// <summary>
                /// 获取或设置法人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corporation_name")]
                [System.Text.Json.Serialization.JsonPropertyName("corporation_name")]
                public string? LegalPerson { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置门店信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retail_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("retail_info_list")]
        public IList<Types.RetailInfo> RetailInfoList { get; set; } = new List<Types.RetailInfo>();
    }
}
