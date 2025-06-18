using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.complaint_callback 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/guarantee/complaint.html ]]>
    /// </para>
    /// </summary>
    public class ComplaintCallbackEvent : WechatApiEvent
    {
        private readonly object _lockObj = new object();

        public static class Types
        {
            public class EventData
            {
                public static class Types
                {
                    public class ComplaintHistory
                    {
                        /// <summary>
                        /// 获取或设置时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time")]
                        [System.Text.Json.Serialization.JsonPropertyName("time")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        [System.Xml.Serialization.XmlElement("time")]
                        public long Timestamp { get; set; }

                        /// <summary>
                        /// 获取或设置内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        [System.Xml.Serialization.XmlElement("content", IsNullable = true)]
                        public string? Content { get; set; }

                        /// <summary>
                        /// 获取或设置图片 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id_list")]
                        [System.Xml.Serialization.XmlElement("media_id_list", Type = typeof(string), IsNullable = true)]
                        public string[]? MediaIdListString { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置事件通知类型。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("option_type")]
                public string OptionType { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉单号。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("complaint_order_id")]
                public long ComplaintOrderId { get; set; }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("open_id")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉问题类型。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置用户手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("phone_number")]
                public string PhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉材料内容。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("customer_material_content", IsNullable = true)]
                public string? CustomerMaterialContent { get; set; }

                /// <summary>
                /// 获取或设置投诉材料图片 MediaId 列表字符串（以逗号分隔）。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("customer_material_media_id_list", IsNullable = true)]
                public string? CustomerMaterialMediaIdListString { get; set; }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("out_trade_no")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("product_name")]
                public string ProductName { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("pay_time")]
                public long PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置交易金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("total_cost")]
                public int TotalCost { get; set; }

                /// <summary>
                /// 获取或设置投诉发起时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("create_time")]
                public long ComplaintCreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置投诉状态过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("expire_time")]
                public long ComplaintStatusExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置投诉进度列表。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("history", Type = typeof(Types.ComplaintHistory))]
                public Types.ComplaintHistory[] ComplaintHistoryList { get; set; } = default!;
            }
        }

        internal static class Converters
        {
            internal class EventPropertyComplaintHistoryListNewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter<Types.EventData.Types.ComplaintHistory[]?>
            {
                public override bool CanWrite
                {
                    get { return false; }
                }

                public override Types.EventData.Types.ComplaintHistory[]? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.EventData.Types.ComplaintHistory[]? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    /*
                     * NOTICE:
                     *   "history" 字段有时是对象形式，有时是数组形式。
                     *   此转换器为了同时兼容这两种数据结构。
                     */

                    switch (reader.TokenType)
                    {
                        case Newtonsoft.Json.JsonToken.Null:
                            {
                                return existingValue;
                            }

                        case Newtonsoft.Json.JsonToken.StartArray:
                            {
                                return serializer.Deserialize<Types.EventData.Types.ComplaintHistory[]>(reader);
                            }

                        case Newtonsoft.Json.JsonToken.StartObject:
                            {
                                Types.EventData.Types.ComplaintHistory[] array = new Types.EventData.Types.ComplaintHistory[1];
                                array[0] = serializer.Deserialize<Types.EventData.Types.ComplaintHistory>(reader)!;
                                return array;
                            }
                    }

                    throw new Newtonsoft.Json.JsonException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.EventData.Types.ComplaintHistory[]? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    throw new NotImplementedException();
                }
            }

            internal class EventPropertyComplaintHistoryListSystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Types.EventData.Types.ComplaintHistory[]?>
            {
                public override Types.EventData.Types.ComplaintHistory[]? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    /*
                     * NOTICE:
                     *   "history" 字段有时是对象形式，有时是数组形式。
                     *   此转换器为了同时兼容这两种数据结构。
                     */

                    switch (reader.TokenType)
                    {
                        case System.Text.Json.JsonTokenType.Null:
                            {
                                return default;
                            }

                        case System.Text.Json.JsonTokenType.StartArray:
                            {
                                return System.Text.Json.JsonSerializer.Deserialize<Types.EventData.Types.ComplaintHistory[]>(ref reader, options);
                            }

                        case System.Text.Json.JsonTokenType.StartObject:
                            {
                                Types.EventData.Types.ComplaintHistory[] array = new Types.EventData.Types.ComplaintHistory[1];
                                array[0] = System.Text.Json.JsonSerializer.Deserialize<Types.EventData.Types.ComplaintHistory>(ref reader, options)!;
                                return array;
                            }
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.EventData.Types.ComplaintHistory[]? value, System.Text.Json.JsonSerializerOptions options)
                {
                    writer.WriteRawValue(System.Text.Json.JsonSerializer.Serialize(value, typeof(Types.EventData.Types.ComplaintHistory[]), options));
                }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Xml.Serialization.XmlElement("BussiCallBackInfo")]
        public Types.EventData EventData { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// <para>等效于 <see cref="Types.EventData.AppId"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        [System.Xml.Serialization.XmlIgnore]
        public string AppId
        {
            get { return this.EventData?.AppId ?? default!; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.AppId = value!;
            }
        }

        /// <summary>
        /// 获取或设置事件通知类型。
        /// <para>等效于 <see cref="Types.EventData.OptionType"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_type")]
        [System.Text.Json.Serialization.JsonPropertyName("option_type")]
        [System.Xml.Serialization.XmlIgnore]
        public string OptionType
        {
            get { return this.EventData?.OptionType ?? default!; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.OptionType = value!;
            }
        }

        /// <summary>
        /// 获取或设置投诉单号。
        /// <para>等效于 <see cref="Types.EventData.ComplaintOrderId"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_order_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlIgnore]
        public long ComplaintOrderId
        {
            get { return this.EventData?.ComplaintOrderId ?? default; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.ComplaintOrderId = value;
            }
        }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// <para>等效于 <see cref="Types.EventData.OpenId"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        [System.Xml.Serialization.XmlIgnore]
        public string OpenId
        {
            get { return this.EventData?.OpenId ?? default!; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.OpenId = value!;
            }
        }

        /// <summary>
        /// 获取或设置投诉问题类型。
        /// <para>等效于 <see cref="Types.EventData.Type"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlIgnore]
        public int Type
        {
            get { return this.EventData?.Type ?? default; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.Type = value;
            }
        }

        /// <summary>
        /// 获取或设置订单状态。
        /// <para>等效于 <see cref="Types.EventData.Status"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlIgnore]
        public int Status
        {
            get { return this.EventData?.Status ?? default; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.Status = value;
            }
        }

        /// <summary>
        /// 获取或设置用户手机号码。
        /// <para>等效于 <see cref="Types.EventData.PhoneNumber"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
        [System.Xml.Serialization.XmlIgnore]
        public string PhoneNumber
        {
            get { return this.EventData?.PhoneNumber ?? default!; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.PhoneNumber = value!;
            }
        }

        /// <summary>
        /// 获取或设置投诉材料内容。
        /// <para>等效于 <see cref="Types.EventData.CustomerMaterialContent"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_material_content")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_material_content")]
        [System.Xml.Serialization.XmlIgnore]
        public string? CustomerMaterialContent
        {
            get { return this.EventData?.CustomerMaterialContent ?? default; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.CustomerMaterialContent = value;
            }
        }

        /// <summary>
        /// 获取或设置投诉材料图片 MediaId 列表字符串（以逗号分隔）。
        /// <para>等效于 <see cref="Types.EventData.CustomerMaterialMediaIdListString"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_material_media_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_material_media_id_list")]
        [System.Xml.Serialization.XmlIgnore]
        public string? CustomerMaterialMediaIdListString
        {
            get { return this.EventData?.CustomerMaterialMediaIdListString ?? default; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.CustomerMaterialMediaIdListString = value;
            }
        }

        /// <summary>
        /// 获取或设置订单号。
        /// <para>等效于 <see cref="Types.EventData.OrderId"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        [System.Xml.Serialization.XmlIgnore]
        public string OrderId
        {
            get { return this.EventData?.OrderId ?? default!; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.OrderId = value!;
            }
        }

        /// <summary>
        /// 获取或设置商户订单号。
        /// <para>等效于 <see cref="Types.EventData.OutTradeNumber"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        [System.Xml.Serialization.XmlIgnore]
        public string OutTradeNumber
        {
            get { return this.EventData?.OutTradeNumber ?? default!; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.OutTradeNumber = value!;
            }
        }

        /// <summary>
        /// 获取或设置商品名称。
        /// <para>等效于 <see cref="Types.EventData.ProductName"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_name")]
        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
        [System.Xml.Serialization.XmlIgnore]
        public string ProductName
        {
            get { return this.EventData?.ProductName ?? default!; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.ProductName = value!;
            }
        }

        /// <summary>
        /// 获取或设置支付时间戳。
        /// <para>等效于 <see cref="Types.EventData.PayTimestamp"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlIgnore]
        public long PayTimestamp
        {
            get { return this.EventData?.PayTimestamp ?? default; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.PayTimestamp = value;
            }
        }

        /// <summary>
        /// 获取或设置交易金额（单位：分）。
        /// <para>等效于 <see cref="Types.EventData.TotalCost"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_cost")]
        [System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlIgnore]
        public int TotalCost
        {
            get { return this.EventData?.TotalCost ?? default; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.TotalCost = value;
            }
        }

        /// <summary>
        /// 获取或设置投诉发起时间戳。
        /// <para>等效于 <see cref="Types.EventData.ComplaintCreateTimestamp"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlIgnore]
        public long ComplaintCreateTimestamp
        {
            get { return this.EventData?.ComplaintCreateTimestamp ?? default; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.ComplaintCreateTimestamp = value;
            }
        }

        /// <summary>
        /// 获取或设置投诉状态过期时间戳。
        /// <para>等效于 <see cref="Types.EventData.ComplaintStatusExpireTimestamp"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlIgnore]
        public long ComplaintStatusExpireTimestamp
        {
            get { return this.EventData?.ComplaintStatusExpireTimestamp ?? default; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.ComplaintStatusExpireTimestamp = value;
            }
        }

        /// <summary>
        /// 获取或设置投诉进度列表。
        /// <para>等效于 <see cref="Types.EventData.ComplaintHistory"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("history")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.EventPropertyComplaintHistoryListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("history")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.EventPropertyComplaintHistoryListSystemTextJsonConverter))]
        [System.Xml.Serialization.XmlIgnore]
        public Types.EventData.Types.ComplaintHistory[] ComplaintHistoryList
        {
            get { return this.EventData?.ComplaintHistoryList ?? default!; }
            set
            {
                EnsureEventDataInitialized();
                this.EventData.ComplaintHistoryList = value!;
            }
        }

        protected void EnsureEventDataInitialized()
        {
            if (this.EventData is null)
            {
                lock (_lockObj)
                {
                    if (this.EventData is null)
                    {
                        this.EventData = new Types.EventData();
                    }
                }
            }
        }
    }
}
