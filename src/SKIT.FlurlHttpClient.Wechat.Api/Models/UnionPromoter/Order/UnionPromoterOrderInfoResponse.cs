using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/order/info 接口的响应。</para>
    /// </summary>
    public class UnionPromoterOrderInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class Product
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("productId")]
                        [System.Text.Json.Serialization.JsonPropertyName("productId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品缩略图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("thumbImg")]
                        [System.Text.Json.Serialization.JsonPropertyName("thumbImg")]
                        public string ThumbnailImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonCurrencyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonCurrencyConverter))]
                        public int Price { get; set; }

                        /// <summary>
                        /// 获取或设置佣金比例（单位：万分之一）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                        public int CommissionRatio { get; set; }

                        /// <summary>
                        /// 获取或设置佣金金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission")]
                        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonCurrencyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("commission")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonCurrencyConverter))]
                        public int CommissionValue { get; set; }

                        /// <summary>
                        /// 获取或设置分佣状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commissionStatus")]
                        [System.Text.Json.Serialization.JsonPropertyName("commissionStatus")]
                        public string CommissionStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品类目名称，使用逗号分隔。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categoryStr")]
                        [System.Text.Json.Serialization.JsonPropertyName("categoryStr")]
                        public string CategoryNames { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推广信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotionInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotionInfo")]
                        public Promotion? Promotion { get; set; }

                        /// <summary>
                        /// 获取或设置自定义扩展参数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customizeInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("customizeInfo")]
                        public string? CustomizeExtra { get; set; }
                    }

                    public class Promotion
                    {
                        /// <summary>
                        /// 获取或设置推广位 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotionSourcePid")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotionSourcePid")]
                        public string PromotionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推广位 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotionSourceName")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotionSourceName")]
                        public string SourceName { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderId")]
                [System.Text.Json.Serialization.JsonPropertyName("orderId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productList")]
                [System.Text.Json.Serialization.JsonPropertyName("productList")]
                public Types.Product[] ProductList { get; set; } = default!;

                /// <summary>
                /// 获取或设置小商店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shopAppid")]
                [System.Text.Json.Serialization.JsonPropertyName("shopAppid")]
                public string? ShopAppId { get; set; }

                /// <summary>
                /// 获取或设置小商店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shopName")]
                [System.Text.Json.Serialization.JsonPropertyName("shopName")]
                public string? ShopName { get; set; }

                /// <summary>
                /// 获取或设置付款时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payTime")]
                [System.Text.Json.Serialization.JsonPropertyName("payTime")]
                public long? PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置确认收货时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("confirmReceiptTime")]
                [System.Text.Json.Serialization.JsonPropertyName("confirmReceiptTime")]
                public long? ConfirmReceiptTimestamp { get; set; }
            }
        }

        internal static class Converters
        {
            internal class NewtonsoftJsonCurrencyConverter : Newtonsoft.Json.JsonConverter<int>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override int ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, int existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.String)
                    {
                        string? value = serializer.Deserialize<string>(reader);
                        if (value == null)
                            return existingValue;

                        value = value.Replace("¥", string.Empty).Replace("-", string.Empty);
                        if (string.IsNullOrEmpty(value))
                            return existingValue;

                        if (double.TryParse(value, out double currency))
                        {
                            return (int)(currency * 100);
                        }
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, int value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    writer.WriteValue("¥" + ((double)value / 100).ToString("#.##"));
                }
            }

            internal class SystemTextJsonCurrencyConverter : System.Text.Json.Serialization.JsonConverter<int>
            {
                public override int Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return default;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.String)
                    {
                        string? value = reader.GetString();
                        if (value == null)
                            return default;

                        value = value.Replace("¥", string.Empty).Replace("-", string.Empty);
                        if (string.IsNullOrEmpty(value))
                            return default;

                        if (double.TryParse(value, out double currency))
                        {
                            return (int)(currency * 100);
                        }
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, int value, System.Text.Json.JsonSerializerOptions options)
                {
                    writer.WriteStringValue("¥" + ((double)value / 100).ToString("#.##"));
                }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderList")]
        [System.Text.Json.Serialization.JsonPropertyName("orderList")]

        public Types.Order[] OrderList { get; set; } = default!;
    }
}
