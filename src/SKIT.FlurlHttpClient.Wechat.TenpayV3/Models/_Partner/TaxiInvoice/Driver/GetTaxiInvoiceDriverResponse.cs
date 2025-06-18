namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /taxi-invoice/drivers/{driver_license} 接口的响应。</para>
    /// </summary>
    public class GetTaxiInvoiceDriverResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Photo
            {
                public static class Types
                {
                    public class Digest
                    {
                        /// <summary>
                        /// 获取或设置哈希类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hash_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("hash_type")]
                        public string HashType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置哈希值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hash_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("hash_value")]
                        public string HashValue { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置照片类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("photo_type")]
                [System.Text.Json.Serialization.JsonPropertyName("photo_type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置照片信息摘要信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("photo_digest")]
                [System.Text.Json.Serialization.JsonPropertyName("photo_digest")]
                public Types.Digest? Digest { get; set; }

                /// <summary>
                /// 获取或设置照片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("photo_url")]
                [System.Text.Json.Serialization.JsonPropertyName("photo_url")]
                public string? PhotoUrl { get; set; }

                /// <summary>
                /// 获取或设置经 Base64 编码的照片数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("photo_data")]
                [System.Text.Json.Serialization.JsonPropertyName("photo_data")]
                public string? EncodingPhotoData { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置公司商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("company_mchid")]
        public string CompanyMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = default!;

        /// <summary>
        /// 获取或设置司机姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("driver_name")]
        [System.Text.Json.Serialization.JsonPropertyName("driver_name")]
        public string DriverName { get; set; } = default!;

        /// <summary>
        /// 获取或设置司机资格证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("driver_license")]
        [System.Text.Json.Serialization.JsonPropertyName("driver_license")]
        public string DriverLicenseNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置司机类别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("driver_category")]
        [System.Text.Json.Serialization.JsonPropertyName("driver_category")]
        public string DriverCategory { get; set; } = default!;

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_id")]
        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int RegionId { get; set; }

        /// <summary>
        /// 获取或设置岗位状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("driver_state")]
        [System.Text.Json.Serialization.JsonPropertyName("driver_state")]
        public string? DriverState { get; set; }

        /// <summary>
        /// 获取或设置司机头像信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("driver_photo")]
        [System.Text.Json.Serialization.JsonPropertyName("driver_photo")]
        public Types.Photo? DriverPhoto { get; set; }
    }
}
