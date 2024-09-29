using System;
using Flurl.Http.Configuration;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant-service/complaints-v2/{complaint_id}/negotiation-historys 接口的响应。</para>
    /// </summary>
    public class QueryMerchantServiceComplaintNegotiationHistoriesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class NegotiationHistory
            {
                public static class Types
                {
                    public class ComplaintMedia : GetMerchantServiceComplaintByComplaintIdResponse.Types.ComplaintMedia
                    {
                    }
                }

                /// <summary>
                /// 获取或设置操作流水号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("log_id")]
                [System.Text.Json.Serialization.JsonPropertyName("log_id")]
                public string LogId { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operator")]
                [System.Text.Json.Serialization.JsonPropertyName("operator")]
                public string Operator { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operate_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset OperateTime { get; set; }

                /// <summary>
                /// 获取或设置操作时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operate_type")]
                [System.Text.Json.Serialization.JsonPropertyName("operate_type")]
                public string OperateType { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operate_details")]
                [System.Text.Json.Serialization.JsonPropertyName("operate_details")]
                public string? OperateDetails { get; set; }

                /// <summary>
                /// 获取或设置图片凭证地址列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_list")]
                [System.Text.Json.Serialization.JsonPropertyName("image_list")]
                public string[]? ImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置投诉资料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_media_list")]
                [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyNegotiationHistoryItemComplaintMediaListNewtonsoftJsonConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_media_list")]
                [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyNegotiationHistoryItemComplaintMediaListSystemTextJsonConverter))]
                public Types.ComplaintMedia[]? ComplaintMediaList { get; set; }

                /// <summary>
                /// 获取或设置用户申请平台协助原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_appy_platform_service_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("user_appy_platform_service_reason")]
                public string? UserAppyPlatformServiceReason { get; set; }

                /// <summary>
                /// 获取或设置用户申请平台协助原因描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_appy_platform_service_reason_description")]
                [System.Text.Json.Serialization.JsonPropertyName("user_appy_platform_service_reason_description")]
                public string? UserAppyPlatformServiceReasonDescription { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyNegotiationHistoryItemComplaintMediaListNewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter<Types.NegotiationHistory.Types.ComplaintMedia[]?>
            {
                public override bool CanWrite
                {
                    get { return false; }
                }

                public override Types.NegotiationHistory.Types.ComplaintMedia[]? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.NegotiationHistory.Types.ComplaintMedia[]? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    /*
                     * NOTICE:
                     *   2023-03-07 微信支付调整了返回结果的数据结构。
                     *   原 "complaint_media_list" 字段是数组形式，现改为对象形式。
                     *   此转换器为了适配并同时兼容新旧两种数据结构。
                     */

                    switch (reader.TokenType)
                    {
                        case Newtonsoft.Json.JsonToken.Null:
                            {
                                return existingValue;
                            }

                        case Newtonsoft.Json.JsonToken.StartArray:
                            {
                                return serializer.Deserialize<Types.NegotiationHistory.Types.ComplaintMedia[]>(reader);
                            }

                        case Newtonsoft.Json.JsonToken.StartObject:
                            {
                                Types.NegotiationHistory.Types.ComplaintMedia[] array = new Types.NegotiationHistory.Types.ComplaintMedia[1];
                                array[0] = serializer.Deserialize<Types.NegotiationHistory.Types.ComplaintMedia>(reader)!;
                                return array;
                            }
                    }

                    throw new Newtonsoft.Json.JsonException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.NegotiationHistory.Types.ComplaintMedia[]? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    throw new NotImplementedException();
                }
            }

            internal class ResponsePropertyNegotiationHistoryItemComplaintMediaListSystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Types.NegotiationHistory.Types.ComplaintMedia[]?>
            {
                public override Types.NegotiationHistory.Types.ComplaintMedia[]? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    /*
                     * NOTICE:
                     *   2023-03-07 微信支付调整了返回结果的数据结构。
                     *   原 "complaint_media_list" 字段是数组形式，现改为对象形式。
                     *   此转换器为了适配并同时兼容新旧两种数据结构。
                     */

                    switch (reader.TokenType)
                    {
                        case System.Text.Json.JsonTokenType.Null:
                            {
                                return default;
                            }

                        case System.Text.Json.JsonTokenType.StartArray:
                            {
                                return System.Text.Json.JsonSerializer.Deserialize<Types.NegotiationHistory.Types.ComplaintMedia[]>(ref reader, options);
                            }

                        case System.Text.Json.JsonTokenType.StartObject:
                            {
                                Types.NegotiationHistory.Types.ComplaintMedia[] array = new Types.NegotiationHistory.Types.ComplaintMedia[1];
                                array[0] = System.Text.Json.JsonSerializer.Deserialize<Types.NegotiationHistory.Types.ComplaintMedia>(ref reader, options)!;
                                return array;
                            }
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.NegotiationHistory.Types.ComplaintMedia[]? value, System.Text.Json.JsonSerializerOptions options)
                {
                    writer.WriteRawValue(System.Text.Json.JsonSerializer.Serialize(value, typeof(Types.NegotiationHistory.Types.ComplaintMedia[]), options));
                }
            }
        }

        /// <summary>
        /// 获取或设置投诉协商历史列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.NegotiationHistory[] NegotiationHistoryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置投诉协商历史总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
    }
}
