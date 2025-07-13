using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /fund-app/brand-redpacket/brand-merchant-out-batches/{out_batch_no} 接口的响应。</para>
    /// </summary>
    public class GetFundAppBrandRedPacketBrandMerchantBatchByOutBatchNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TransferDetail
            {
                /// <summary>
                /// 获取或设置商家明细单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_detail_no")]
                public string OutDetailNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信明细单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_detail_no")]
                public string DetailNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置明细状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_state")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_state")]
                public string DetailState { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置品牌微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_mchid")]
        public string BrandMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public int BrandId { get; set; }

        /// <summary>
        /// 获取或设置品牌微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_appid")]
        public string? BrandAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌红包模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 获取或设置商家批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutBatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_no")]
        public string BatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_name")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_name")]
        public string BatchName { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_state")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_state")]
        public string BatchState { get; set; } = default!;

        /// <summary>
        /// 获取或设置红包总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置红包总笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalNumber { get; set; }

        /// <summary>
        /// 获取或设置发放成功金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("success_amount")]
        public int SuccessAmount { get; set; }

        /// <summary>
        /// 获取或设置发放成功笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_num")]
        [System.Text.Json.Serialization.JsonPropertyName("success_num")]
        public int SuccessNumber { get; set; }

        /// <summary>
        /// 获取或设置发放失败金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_amount")]
        public int FailAmount { get; set; }

        /// <summary>
        /// 获取或设置发放失败笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_num")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_num")]
        public int FailNumber { get; set; }

        /// <summary>
        /// 获取或设置批次备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_remark")]
        public string BatchRemark { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌红包明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_list")]
        public Types.TransferDetail[]? TransferDetailList { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
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

        /// <summary>
        /// 获取或设置关闭原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("close_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("close_reason")]
        public string? Closeeason { get; set; }
    }
}
