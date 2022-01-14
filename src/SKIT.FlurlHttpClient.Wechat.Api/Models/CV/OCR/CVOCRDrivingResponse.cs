namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/driving 接口的响应。</para>
    /// </summary>
    public class CVOCRDrivingResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CardPosition
            {
                public static class Types
                {
                    public class Position : CVImageQrcodeResponse.Types.CodeResult.Types.Position
                    {
                    }
                }

                /// <summary>
                /// 获取或设置识别坐标信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pos")]
                [System.Text.Json.Serialization.JsonPropertyName("pos")]
                public Types.Position Position { get; set; } = default!;
            }

            public class ImageSize : CVImageQrcodeResponse.Types.ImageSize
            {
            }
        }

        /// <summary>
        /// 获取或设置车牌号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_num")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_num")]
        public string PlateNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置车辆类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_type")]
        [System.Text.Json.Serialization.JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; } = default!;

        /// <summary>
        /// 获取或设置所有人。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner")]
        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// 获取或设置住址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addr")]
        [System.Text.Json.Serialization.JsonPropertyName("addr")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// 获取或设置使用性质。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_character")]
        [System.Text.Json.Serialization.JsonPropertyName("use_character")]
        public string UseCharacter { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌型号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model")]
        [System.Text.Json.Serialization.JsonPropertyName("model")]
        public string VehicleModel { get; set; } = default!;

        /// <summary>
        /// 获取或设置车辆识别代号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vin")]
        [System.Text.Json.Serialization.JsonPropertyName("vin")]
        public string VIN { get; set; } = default!;

        /// <summary>
        /// 获取或设置发动机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("engine_num")]
        [System.Text.Json.Serialization.JsonPropertyName("engine_num")]
        public string EngineNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置注册日期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("register_date")]
        [System.Text.Json.Serialization.JsonPropertyName("register_date")]
        public string RegisterDate { get; set; } = default!;

        /// <summary>
        /// 获取或设置发证日期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("issue_date")]
        [System.Text.Json.Serialization.JsonPropertyName("issue_date")]
        public string IssueDate { get; set; } = default!;

        /// <summary>
        /// 获取或设置车牌号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_num_b")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_num_b")]
        public string PlateNumberB { get; set; } = default!;

        /// <summary>
        /// 获取或设置号牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record")]
        [System.Text.Json.Serialization.JsonPropertyName("record")]
        public string Record { get; set; } = default!;

        /// <summary>
        /// 获取或设置核定载人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("passengers_num")]
        [System.Text.Json.Serialization.JsonPropertyName("passengers_num")]
        public string Passengers { get; set; } = default!;

        /// <summary>
        /// 获取或设置总质量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_quality")]
        [System.Text.Json.Serialization.JsonPropertyName("total_quality")]
        public string TotalQuality { get; set; } = default!;

        /// <summary>
        /// 获取或设置整备质量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepare_quality")]
        [System.Text.Json.Serialization.JsonPropertyName("prepare_quality")]
        public string PrepareQuality { get; set; } = default!;

        /// <summary>
        /// 获取或设置外廓尺寸。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overall_size")]
        [System.Text.Json.Serialization.JsonPropertyName("overall_size")]
        public string OverallSize { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡片正面位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_position_front")]
        [System.Text.Json.Serialization.JsonPropertyName("card_position_front")]
        public Types.CardPosition? CardFrontPosition { get; set; }

        /// <summary>
        /// 获取或设置卡片反面位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_position_back")]
        [System.Text.Json.Serialization.JsonPropertyName("card_position_back")]
        public Types.CardPosition? CardBackPosition { get; set; }

        /// <summary>
        /// 获取或设置图片大小信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_size")]
        [System.Text.Json.Serialization.JsonPropertyName("img_size")]
        public Types.ImageSize ImageSize { get; set; } = default!;
    }
}
