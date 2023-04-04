namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/pay/querystate 接口的响应。</para>
    /// </summary>
    public class GetVehiclePayStateResponse : WechatTenpaySignableResponse
    {
        public static class Types
        {
            public class PlateNumberInfo
            {
                public static class Types
                {
                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置车牌号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("plate_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
                        public string PlateNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置车牌通道标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("channel_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
                        public string? ChannelType { get; set; }

                        /// <summary>
                        /// 获取或设置常用车牌标志。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("common_use_flag")]
                        [System.Text.Json.Serialization.JsonPropertyName("common_use_flag")]
                        public string? CommonUseFlag { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置车牌号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plate_number_info")]
                [System.Text.Json.Serialization.JsonPropertyName("plate_number_info")]
                public Types.Data[] Data { get; set; } = default!;
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyPlateNumberInfoNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.PlateNumberInfo>
            {
            }

            internal class ResponsePropertyPlateNumberInfoSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.PlateNumberInfo>
            {
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string MerchantId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string AppId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// 获取或设置用户状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_state")]
        [System.Text.Json.Serialization.JsonPropertyName("user_state")]
        public string UserState { get; set; } = default!;

        /// <summary>
        /// 获取或设置发起扣费方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_mode")]
        public string? DeductMode { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置跳转路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? JumpPath { get; set; }

        /// <summary>
        /// 获取或设置车牌号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number_info")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyPlateNumberInfoNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number_info")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyPlateNumberInfoSystemTextJsonConverter))]
        public Types.PlateNumberInfo? PlateNumberInfo { get; set; }
    }
}
