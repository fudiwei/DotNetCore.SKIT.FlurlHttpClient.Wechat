namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/template/preview 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliveryTemplatePreviewRequest : WechatApiRequest, IInferable<CgibinExpressDeliveryTemplatePreviewRequest, CgibinExpressDeliveryTemplatePreviewResponse>
    {
        public static class Types
        {
            public class WaybillData
            {
                /// <summary>
                /// 获取或设置运单信息 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string? Key { get; set; }

                /// <summary>
                /// 获取或设置运单信息 Value。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            public class CustomData
            {
                public static class Types
                {
                    public class Sender : CgibinExpressBusinessOrderAddRequest.Types.Sender
                    {
                    }

                    public class Receiver : CgibinExpressBusinessOrderAddRequest.Types.Receiver
                    {
                    }

                    public class Cargo : CgibinExpressBusinessOrderAddRequest.Types.Cargo
                    {
                    }

                    public class Shop : CgibinExpressBusinessOrderAddRequest.Types.Shop
                    {
                    }

                    public class Insurance : CgibinExpressBusinessOrderAddRequest.Types.Insurance
                    {
                    }

                    public class Service : CgibinExpressBusinessOrderAddRequest.Types.Service
                    {
                    }
                }

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string? DeliveryId { get; set; }

                /// <summary>
                /// 获取或设置快递公司客户编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_id")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_id")]
                public string? BusinessId { get; set; }

                /// <summary>
                /// 获取或设置快递备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置订单标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tagid")]
                [System.Text.Json.Serialization.JsonPropertyName("tagid")]
                public int? TagId { get; set; }

                /// <summary>
                /// 获取或设置发件人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sender")]
                [System.Text.Json.Serialization.JsonPropertyName("sender")]
                public Types.Sender? Sender { get; set; }

                /// <summary>
                /// 获取或设置收件人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver")]
                public Types.Receiver? Receiver { get; set; }

                /// <summary>
                /// 获取或设置包裹信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo")]
                public Types.Cargo? Cargo { get; set; }

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop")]
                [System.Text.Json.Serialization.JsonPropertyName("shop")]
                public Types.Shop? Shop { get; set; }

                /// <summary>
                /// 获取或设置保价信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("insured")]
                [System.Text.Json.Serialization.JsonPropertyName("insured")]
                public Types.Insurance? Insurance { get; set; }

                /// <summary>
                /// 获取或设置服务类型信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service")]
                [System.Text.Json.Serialization.JsonPropertyName("service")]
                public Types.Service? Service { get; set; }
            }
        }

        internal static class Converters
        {
            internal class RequestPropertyWaybillDataListNewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter<List<Types.WaybillData>?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override List<Types.WaybillData>? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, List<Types.WaybillData>? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.String)
                    {
                        string? value = serializer.Deserialize<string>(reader);
                        if (value is null)
                            return existingValue;

                        List<Types.WaybillData> list = new();
                        string[] sources = value.TrimStart('#').TrimEnd('#').Split(new string[] { "##" }, StringSplitOptions.None);
                        for (int i = 0; i < sources.Length; i += 2)
                        {
                            list.Add(new Types.WaybillData()
                            {
                                Key = sources[i],
                                Value = sources.Length > i ? sources[i + 1] : string.Empty
                            });
                        }
                        return list;
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, List<Types.WaybillData>? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value is not null)
                        writer.WriteValue("##" + string.Join("##", value.SelectMany(e => new string?[] { e.Key, e.Value }).Select(e => e?.Replace("#", string.Empty) ?? string.Empty)) + "##");
                    else
                        writer.WriteNull();
                }
            }

            internal class RequestPropertyWaybillDataListSystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<List<Types.WaybillData>?>
            {
                public override List<Types.WaybillData>? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return null;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.String)
                    {
                        string? value = reader.GetString();
                        if (value is null)
                            return null;

                        List<Types.WaybillData> list = new();
                        string[] sources = value.TrimStart('#').TrimEnd('#').Split(new string[] { "##" }, StringSplitOptions.None);
                        for (int i = 0; i < sources.Length; i += 2)
                        {
                            list.Add(new Types.WaybillData()
                            {
                                Key = sources[i],
                                Value = sources.Length > i ? sources[i + 1] : string.Empty
                            });
                        }
                        return list;
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, List<Types.WaybillData>? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value is not null)
                        writer.WriteStringValue("##" + string.Join("##", value.SelectMany(e => new string?[] { e.Key, e.Value }).Select(e => e?.Replace("#", string.Empty) ?? string.Empty)) + "##");
                    else
                        writer.WriteNullValue();
                }
            }
        }

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置面单模板 HTML 内容（需经 Base64 编码）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_template")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_template")]
        public string? WaybillTemplateHtml { get; set; }

        /// <summary>
        /// 获取或设置面单数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_data")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyWaybillDataListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_data")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyWaybillDataListSystemTextJsonConverter))]
        public List<Types.WaybillData>? WaybillDataList { get; set; }

        /// <summary>
        /// 获取或设置商户下单数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom")]
        [System.Text.Json.Serialization.JsonPropertyName("custom")]
        public Types.CustomData? CustomData { get; set; }
    }
}
