namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/update_store 接口的请求。</para>
    /// </summary>
    public class WxaUpdateStoreRequest : WechatApiRequest, IInferable<WxaUpdateStoreRequest, WxaUpdateStoreResponse>
    {
        public static class Types
        {
            public class Picture : WxaAddStoreRequest.Types.Picture
            {
            }
        }

        internal static class Converters
        {
            internal class RequestPropertyPictureNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Picture?>
            {
            }

            internal class RequestPropertyPictureSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Picture?>
            {
            }
        }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置腾讯地图的位置点 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("map_poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("map_poi_id")]
        public string MapPOIId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店图片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyPictureNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pic_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyPictureSystemTextJsonConverter))]
        public Types.Picture Picture { get; set; } = new Types.Picture();

        /// <summary>
        /// 获取或设置营业时间（格式：HHmm-HHmm）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour")]
        [System.Text.Json.Serialization.JsonPropertyName("hour")]
        public string BusinessHours { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_phone")]
        public string Telephone { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;
    }
}
