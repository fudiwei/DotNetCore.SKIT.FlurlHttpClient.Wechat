namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/partnerpay/notification 接口的请求。</para>
    /// </summary>
    public class NotifyVehiclePartnerPayRequest : NotifyVehiclePayRequest
    {
        public static new class Types
        {
            public class Scene : NotifyVehiclePayRequest.Types.Scene
            {
                public static new class Types
                {
                    public class Data : NotifyVehiclePayRequest.Types.Scene.Types.Data
                    {
                    }
                }

                /// <summary>
                /// 获取或设置停车信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_info")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
                public new Types.Data Data { get; set; } = new Types.Data();
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public new Types.Scene? Scene { get; set; }
    }
}
