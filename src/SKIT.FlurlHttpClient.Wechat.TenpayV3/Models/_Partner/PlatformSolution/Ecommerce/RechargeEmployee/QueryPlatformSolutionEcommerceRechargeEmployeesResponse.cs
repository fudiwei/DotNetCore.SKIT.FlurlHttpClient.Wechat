using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/ecommerce/recharge-employees/sub-mchid/{sub_mchid} 接口的响应。</para>
    /// </summary>
    public class QueryPlatformSolutionEcommerceRechargeEmployeesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Employee
            {
                /// <summary>
                /// 获取或设置二级商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string SubMerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置员工的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置员工状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string State { get; set; } = default!;

                /// <summary>
                /// 获取或设置添加时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

                /// <summary>
                /// 获取或设置更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置员工列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employees")]
        [System.Text.Json.Serialization.JsonPropertyName("employees")]
        public Types.Employee[] EmployeeList { get; set; } = default!;
    }
}
