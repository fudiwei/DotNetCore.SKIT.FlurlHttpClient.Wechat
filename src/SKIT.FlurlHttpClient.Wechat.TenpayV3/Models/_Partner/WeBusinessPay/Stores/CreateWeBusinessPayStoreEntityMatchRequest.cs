using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /webizpay/stores/entity-matches 接口的请求。</para>
    /// </summary>
    public class CreateWeBusinessPayStoreEntityMatchRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class MatchDetail
            {
                /// <summary>
                /// 获取或设置门店统一社会信用代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organization_code")]
                [System.Text.Json.Serialization.JsonPropertyName("organization_code")]
                public string OrganizationCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                public string StoreName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置需要查询的支付产品。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public string? ProductType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayGlobalClient"/> 时的 <see cref="WechatTenpayGlobalClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户主体匹配批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_id")]
        public string OutBatchId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置主体匹配明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("match_details")]
        [System.Text.Json.Serialization.JsonPropertyName("match_details")]
        public IList<Types.MatchDetail>? MatchDetailList { get; set; } 
    }
}
