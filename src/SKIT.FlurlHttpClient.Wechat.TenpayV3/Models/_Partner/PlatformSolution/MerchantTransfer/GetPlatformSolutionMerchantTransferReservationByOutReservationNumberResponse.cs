using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/mch-transfer/reservation/out-reservation-no/{out_reservation_no} 接口的响应。</para>
    /// </summary>
    public class GetPlatformSolutionMerchantTransferReservationByOutReservationNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class CloseInfo
            {
                /// <summary>
                /// 获取或设置关闭原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("close_reason")]
                public string CloseReason { get; set; } = default!;

                /// <summary>
                /// 获取或设置关闭时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("close_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CloseTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置二级商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商户预约单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_reservation_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_reservation_no")]
        public string OutReservationNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信预约单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reservation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("reservation_id")]
        public string ReservationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置转账场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_id")]
        public string TransferSceneId { get; set; } = default!;

        /// <summary>
        /// 获取或设置预计最晚转账日期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimated_date")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("estimated_date")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? EstimatedDate { get; set; }

        /// <summary>
        /// 获取或设置预计最大转账金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimated_max_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("estimated_max_amount")]
        public int? EstimatedMaxAmount { get; set; }

        /// <summary>
        /// 获取或设置准确转账金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exact_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("exact_amount")]
        public int? ExactAmount { get; set; }

        /// <summary>
        /// 获取或设置收款用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款银行类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string? BankType { get; set; }

        /// <summary>
        /// 获取或设置预约记录状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置预约受理时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("accept_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AcceptTime { get; set; }

        /// <summary>
        /// 获取或设置确认预约时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reserve_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("reserve_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? ReserveTime { get; set; }

        /// <summary>
        /// 获取或设置预约关闭信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("close_info")]
        [System.Text.Json.Serialization.JsonPropertyName("close_info")]
        public Types.CloseInfo? CloseInfo { get; set; }
    }
}
