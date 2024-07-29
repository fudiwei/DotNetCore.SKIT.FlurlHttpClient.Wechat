using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.subscribe_msg_popup_event 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Subscription_Messages/api.html#%E4%BA%8B%E4%BB%B6%E6%8E%A8%E9%80%81 ]]>
    /// </para>
    /// </summary>
    public class SubscribeMessagePopupEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                public static class Types
                {
                    public class EventItem
                    {
                        /// <summary>
                        /// 获取或设置订阅消息模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("TemplateId")]
                        [System.Text.Json.Serialization.JsonPropertyName("TemplateId")]
                        [System.Xml.Serialization.XmlElement("TemplateId")]
                        public string TemplateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户点击行为。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("SubscribeStatusString")]
                        [System.Text.Json.Serialization.JsonPropertyName("SubscribeStatusString")]
                        [System.Xml.Serialization.XmlElement("SubscribeStatusString")]
                        public string SubscribeStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置场景。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("PopupScene")]
                        [System.Text.Json.Serialization.JsonPropertyName("PopupScene")]
                        [System.Xml.Serialization.XmlElement("PopupScene")]
                        public int PopupScene { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户订阅通知弹窗数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("List", typeof(Types.EventItem))]
                public Types.EventItem[] EventList { get; set; } = default!;
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyEventDataListNewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter<Types.EventData.Types.EventItem[]?>
            {
                public override bool CanWrite
                {
                    get { return false; }
                }

                public override Types.EventData.Types.EventItem[]? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.EventData.Types.EventItem[]? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    /*
                     * NOTICE:
                     *   按官方文档的说法，当数组中只存在一个元素时，将以对象形式返回。
                     *   此转换器为了同时兼容数组和对象两种形式的数据结构。
                     */

                    switch (reader.TokenType)
                    {
                        case Newtonsoft.Json.JsonToken.Null:
                            {
                                return existingValue;
                            }

                        case Newtonsoft.Json.JsonToken.StartArray:
                            {
                                return serializer.Deserialize<Types.EventData.Types.EventItem[]>(reader);
                            }

                        case Newtonsoft.Json.JsonToken.StartObject:
                            {
                                Types.EventData.Types.EventItem[] array = new Types.EventData.Types.EventItem[1];
                                array[0] = serializer.Deserialize<Types.EventData.Types.EventItem>(reader)!;
                                return array;
                            }
                    }

                    throw new Newtonsoft.Json.JsonException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.EventData.Types.EventItem[]? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    throw new NotImplementedException();
                }
            }

            internal class ResponsePropertyEventDataListSystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Types.EventData.Types.EventItem[]?>
            {
                public override Types.EventData.Types.EventItem[]? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    /*
                     * NOTICE:
                     *   按官方文档的说法，当数组中只存在一个元素时，将以对象形式返回。
                     *   此转换器为了同时兼容数组和对象两种形式的数据结构。
                     */

                    switch (reader.TokenType)
                    {
                        case System.Text.Json.JsonTokenType.Null:
                            {
                                return default;
                            }

                        case System.Text.Json.JsonTokenType.StartArray:
                            {
                                return System.Text.Json.JsonSerializer.Deserialize<Types.EventData.Types.EventItem[]>(ref reader, options);
                            }

                        case System.Text.Json.JsonTokenType.StartObject:
                            {
                                Types.EventData.Types.EventItem[] array = new Types.EventData.Types.EventItem[1];
                                array[0] = System.Text.Json.JsonSerializer.Deserialize<Types.EventData.Types.EventItem>(ref reader, options)!;
                                return array;
                            }
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.EventData.Types.EventItem[]? value, System.Text.Json.JsonSerializerOptions options)
                {
                    writer.WriteRawValue(System.Text.Json.JsonSerializer.Serialize(value, typeof(Types.EventData.Types.EventItem[]), options));
                }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Xml.Serialization.XmlElement("SubscribeMsgPopupEvent")]
        public Types.EventData EventData { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户订阅通知弹窗数据列表。
        /// <para>等效于 <see cref="Types.EventData.EventList"/>。</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("List")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyEventDataListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("List")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyEventDataListSystemTextJsonConverter))]
        [System.Xml.Serialization.XmlIgnore]
        public Types.EventData.Types.EventItem[]? EventDataList
        {
            get { return this.EventData?.EventList; }
            set
            {
                this.EventData ??= new Types.EventData();
                this.EventData.EventList = value!;
            }
        }
    }
}
