namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/partnerpay/querystate 接口的响应。</para>
    /// </summary>
    public class GetVehiclePartnerPayStateResponse : GetVehiclePayStateResponse
    {
        public static new class Types
        {
            public class PlateNumberInfo : GetVehiclePayStateResponse.Types.PlateNumberInfo
            {
                public static new class Types
                {
                    public class Data : GetVehiclePayStateResponse.Types.PlateNumberInfo.Types.Data
                    {
                    }
                }

                /// <summary>
                /// 获取或设置车牌号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plate_number_info")]
                [System.Text.Json.Serialization.JsonPropertyName("plate_number_info")]
                public new Types.Data[] Data { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置用户在子商户下的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置车牌号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number_info")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number_info")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public new Types.PlateNumberInfo? PlateNumberInfo { get; set; }
    }
}
