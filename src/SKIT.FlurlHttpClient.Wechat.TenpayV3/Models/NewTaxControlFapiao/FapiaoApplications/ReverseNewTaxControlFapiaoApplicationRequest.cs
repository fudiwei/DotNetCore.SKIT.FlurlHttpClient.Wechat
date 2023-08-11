using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/reverse 接口的请求。</para>
    /// </summary>
    public class ReverseNewTaxControlFapiaoApplicationRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Fapiao
            {
                /// <summary>
                /// 获取或设置商户发票单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_id")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_id")]
                public string FapiaoId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发票号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_number")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_number")]
                public string FapiaoNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发票代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_code")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_code")]
                public string FapiaoCode { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置发票申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FapiaoApplyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置冲红原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reverse_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reverse_reason")]
        public string ReverseReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置电子发票信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_information")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_information")]
        public IList<Types.Fapiao> FapiaoList { get; set; } = new List<Types.Fapiao>();
    }
}
