using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /risk/getviolation 接口的请求。</para>
    /// </summary>
    public class QueryRiskViolationRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset BeginTime { get; set; }

        /// <summary>
        /// 获取或设置结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置分页页码。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_index")]
        [System.Text.Json.Serialization.JsonPropertyName("page_index")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("violation_records_format")]
        [System.Text.Json.Serialization.JsonPropertyName("violation_records_format")]
        public string Format { get; set; } = "json";

        /// <summary>
        /// <inheritdoc/>
        /// <para>默认值：<see cref="Constants.SignTypes.HMAC_SHA256"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
#pragma warning disable CS8765
        public override string SignType { get; set; } = Constants.SignTypes.HMAC_SHA256;
#pragma warning restore CS8765
    }
}
