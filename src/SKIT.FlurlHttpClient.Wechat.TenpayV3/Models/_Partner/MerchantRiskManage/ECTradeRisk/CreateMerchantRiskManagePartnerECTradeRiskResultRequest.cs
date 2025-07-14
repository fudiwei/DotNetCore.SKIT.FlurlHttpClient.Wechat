using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-risk-manage/ec-trade-risk/recv-dispose-result 接口的请求。</para>
    /// </summary>
    public class CreateMerchantRiskManagePartnerECTradeRiskResultRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置最终风险结论。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("final_risk_result")]
        [System.Text.Json.Serialization.JsonPropertyName("final_risk_result")]
        public int? FinalRiskResult { get; set; }

        /// <summary>
        /// 获取或设置最终风险类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("final_risk_type")]
        [System.Text.Json.Serialization.JsonPropertyName("final_risk_type")]
        public int? FinalRiskType { get; set; }

        /// <summary>
        /// 获取或设置处置结论列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disp_conclusion")]
        [System.Text.Json.Serialization.JsonPropertyName("disp_conclusion")]
        public IList<int>? DisposeConclusionList { get; set; }

        /// <summary>
        /// 获取或设置处置补充。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disp_addition")]
        [System.Text.Json.Serialization.JsonPropertyName("disp_addition")]
        public string? DisposeAdditional { get; set; }

        /// <summary>
        /// 获取或设置是否有投诉。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exist_complaint")]
        [System.Text.Json.Serialization.JsonPropertyName("exist_complaint")]
        public bool? IsComplaintExist { get; set; }

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
        public int? RefundAmount { get; set; }
    }
}
