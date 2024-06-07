using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/addpromoter 接口的请求。</para>
    /// </summary>
    public class PromoterAddPromoterRequest : PublisherStatSettlementRequest, IInferable<PromoterAddPromoterRequest, PromoterAddPromoterResponse>
    {
        public static class Types
        {
            public class Promoter
            {
                /// <summary>
                /// 获取或设置推广员的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置角色 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role_id")]
                [System.Text.Json.Serialization.JsonPropertyName("role_id")]
                public int RoleId { get; set; }

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("retail_id")]
                [System.Text.Json.Serialization.JsonPropertyName("retail_id")]
                public string? RetailId { get; set; }

                /// <summary>
                /// 获取或设置推广员参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra_info")]
                [System.Text.Json.Serialization.JsonPropertyName("extra_info")]
                public string? ExtraInfo { get; set; }

                /// <summary>
                /// 获取或设置推广员名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置推广员手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string? PhoneNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置推广员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_list")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_list")]
        public IList<Types.Promoter> PromoterList { get; set; } = new List<Types.Promoter>();
    }
}
