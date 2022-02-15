using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /businesscircle/points/notify 接口的请求。</para>
    /// </summary>
    public class NotifyBusinessCirclePointsRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否获得积分。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("earn_points")]
        [System.Text.Json.Serialization.JsonPropertyName("earn_points")]
        public bool IsEarnPoints { get; set; }

        /// <summary>
        /// 获取或设置订单新增积分值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("increased_points")]
        [System.Text.Json.Serialization.JsonPropertyName("increased_points")]
        public int IncreasedPoints { get; set; }

        /// <summary>
        /// 获取或设置积分更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("points_update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("points_update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }

        /// <summary>
        /// 获取或设置未获得积分的备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("no_points_remarks")]
        [System.Text.Json.Serialization.JsonPropertyName("no_points_remarks")]
        public string? NoPointsRemarks { get; set; }

        /// <summary>
        /// 获取或设置顾客积分总额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_points")]
        [System.Text.Json.Serialization.JsonPropertyName("total_points")]
        public int? TotalPoints { get; set; }
    }
}
