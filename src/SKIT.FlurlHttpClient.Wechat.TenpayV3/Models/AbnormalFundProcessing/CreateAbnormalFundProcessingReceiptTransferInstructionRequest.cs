using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /abnormal-fund-processing/receipts/{receipt_id}/transfer-instructions 接口的请求。</para>
    /// </summary>
    public class CreateAbnormalFundProcessingReceiptTransferInstructionRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信支付在途异常资金付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ReceiptId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public IList<string> AppIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商户指令编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_instruction_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_instruction_no")]
        public string OutInstructionNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置付款方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_mode")]
        public string TransferMode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }
    }
}
