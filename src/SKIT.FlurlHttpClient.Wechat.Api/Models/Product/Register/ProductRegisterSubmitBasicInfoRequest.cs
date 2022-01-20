using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/register/submit_basicinfo 接口的请求。</para>
    /// </summary>
    public class ProductRegisterSubmitBasicInfoRequest : WechatApiRequest
    {
        public static class Types
        {
            public class AppNaming
            {
                /// <summary>
                /// 获取或设置小程序名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("abbr")]
                [System.Text.Json.Serialization.JsonPropertyName("abbr")]
                public string Abbreviation { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序简介。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("introduction")]
                [System.Text.Json.Serialization.JsonPropertyName("introduction")]
                public string Introduction { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置补充材料 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("naming_other_stuff")]
                [System.Text.Json.Serialization.JsonPropertyName("naming_other_stuff")]
                public IList<string>? OtherStuffMediaIdList { get; set; }
            }

            public class SalesReturn
            {
                public static class Types
                {
                    public class Address : ProductAddressAddRequest.Types.Address.Types.AddressInformation
                    {
                    }
                }

                /// <summary>
                /// 获取或设置邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mail")]
                [System.Text.Json.Serialization.JsonPropertyName("mail")]
                public string Email { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_info")]
                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                public Types.Address? Address { get; set; }

                /// <summary>
                /// 获取或设置公司地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_address")]
                [System.Text.Json.Serialization.JsonPropertyName("company_address")]
                public Types.Address? CompanyAddress { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置名称信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name_info")]
        [System.Text.Json.Serialization.JsonPropertyName("name_info")]
        public Types.AppNaming AppNaming { get; set; } = new Types.AppNaming();

        /// <summary>
        /// 获取或设置退货信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_info")]
        [System.Text.Json.Serialization.JsonPropertyName("return_info")]
        public Types.SalesReturn SalesReturn { get; set; } = new Types.SalesReturn();
    }
}
