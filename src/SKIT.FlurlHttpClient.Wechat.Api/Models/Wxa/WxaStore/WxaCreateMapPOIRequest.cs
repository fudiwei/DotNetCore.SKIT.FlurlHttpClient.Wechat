namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/create_map_poi 接口的请求。</para>
    /// </summary>
    public class WxaCreateMapPOIRequest : WechatApiRequest, IInferable<WxaCreateMapPOIRequest, WxaCreateMapPOIResponse>
    {
        /// <summary>
        /// 获取或设置原门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string? POIId { get; set; }

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店分类。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category")]
        [System.Text.Json.Serialization.JsonPropertyName("category")]
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("introduct")]
        [System.Text.Json.Serialization.JsonPropertyName("introduct")]
        public string Introduction { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("telephone")]
        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
        public string Telephone { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店位置经度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude")]
        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public decimal Longitude { get; set; }

        /// <summary>
        /// 获取或设置门店位置纬度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude")]
        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// 获取或设置门店区域 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("districtid")]
        [System.Text.Json.Serialization.JsonPropertyName("districtid")]
        public int DistrictId { get; set; }

        /// <summary>
        /// 获取或设置门店所在省份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        [System.Text.Json.Serialization.JsonPropertyName("province")]
        public string Province { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店所在城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店所在区县。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district")]
        [System.Text.Json.Serialization.JsonPropertyName("district")]
        public string District { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店详细地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店图片媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("photo")]
        [System.Text.Json.Serialization.JsonPropertyName("photo")]
        public string PictureMediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业执照图片媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license")]
        [System.Text.Json.Serialization.JsonPropertyName("license")]
        public string LicenseMediaId { get; set; } = string.Empty;
    }
}
