namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getretailinfo 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGetRetailInfoResponse : WechatApiResponse
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
                public string RetailType { get; set; } = default!;

                /// <summary>
                /// 获取或设置二级类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_retail_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_retail_type")]
                public string RetailSubType { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("retail_name")]
                [System.Text.Json.Serialization.JsonPropertyName("retail_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("retail_address")]
                [System.Text.Json.Serialization.JsonPropertyName("retail_address")]
                public string Address { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店负责人的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店负责人的手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                public string Mobilephone { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("principal")]
                [System.Text.Json.Serialization.JsonPropertyName("principal")]
                public string? BusinessName { get; set; }

                /// <summary>
                /// 获取或设置营业执照注册号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification")]
                [System.Text.Json.Serialization.JsonPropertyName("identification")]
                public string? RegistrationNumber { get; set; }

                /// <summary>
                /// 获取或设置法人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person_name")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person_name")]
                public string? LegalPerson { get; set; }

                /// <summary>
                /// 获取或设置认证方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_mode")]
                public int AuthMode { get; set; }

                /// <summary>
                /// 获取或设置认证状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置认证时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_time")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_time")]
                public long? AuthTimestamp { get; set; }

                /// <summary>
                /// 获取或设置授权时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grant_time")]
                [System.Text.Json.Serialization.JsonPropertyName("grant_time")]
                public long? GrantTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置门店信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.RetailInfo[] RetailInfoList { get; set; } = default!;
    }
}
