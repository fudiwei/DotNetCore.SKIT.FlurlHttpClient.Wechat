using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/ecommerce/insurance-compensation-contracts/sub-mchid/{sub_mchid}/check-opened 接口的响应。</para>
    /// </summary>
    public class GetPlatformSolutionEcommerceInsuranceCompensationContractBySubMerchantIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否开通成功。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opened")]
        [System.Text.Json.Serialization.JsonPropertyName("opened")]
        public bool IsOpened { get; set; }

        /// <summary>
        /// 获取或设置开通成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }
    }
}
