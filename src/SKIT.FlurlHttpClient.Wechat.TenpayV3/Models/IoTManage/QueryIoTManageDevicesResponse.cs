using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /iotmanage/devices 接口的响应。</para>
    /// </summary>
    public class QueryIoTManageDevicesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Device
            {
                /// <summary>
                /// 获取或设置设备序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_sn")]
                [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
                public string? DeviceSerialNumber { get; set; }

                /// <summary>
                /// 获取或设置摄像头序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("camera_sn")]
                [System.Text.Json.Serialization.JsonPropertyName("camera_sn")]
                public string? CameraSerialNumber { get; set; }

                /// <summary>
                /// 获取或设置设备品类代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_category_code")]
                [System.Text.Json.Serialization.JsonPropertyName("device_category_code")]
                public string? DeviceCategoryCode { get; set; }

                /// <summary>
                /// 获取或设置设备品类。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_category")]
                [System.Text.Json.Serialization.JsonPropertyName("device_category")]
                public string? DeviceCategory { get; set; }

                /// <summary>
                /// 获取或设置设备类型代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_class_code")]
                [System.Text.Json.Serialization.JsonPropertyName("device_class_code")]
                public string? DeviceClassCode { get; set; }

                /// <summary>
                /// 获取或设置设备类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_class")]
                [System.Text.Json.Serialization.JsonPropertyName("device_class")]
                public string? DeviceClass { get; set; }

                /// <summary>
                /// 获取或设置设备型号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_model")]
                [System.Text.Json.Serialization.JsonPropertyName("device_model")]
                public string? DeviceModel { get; set; }

                /// <summary>
                /// 获取或设置刷脸应用软件模式代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_scene_code")]
                [System.Text.Json.Serialization.JsonPropertyName("app_scene_code")]
                public string? AppSceneCode { get; set; }

                /// <summary>
                /// 获取或设置刷脸应用软件模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("app_scene")]
                public string? AppScene { get; set; }

                /// <summary>
                /// 获取或设置刷脸应用操作系统。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operating_system")]
                [System.Text.Json.Serialization.JsonPropertyName("operating_system")]
                public string? OperatingSystem { get; set; }

                /// <summary>
                /// 获取或设置激活状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activation_status")]
                [System.Text.Json.Serialization.JsonPropertyName("activation_status")]
                public string? ActivationStatus { get; set; }

                /// <summary>
                /// 获取或设置激活时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activation_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("activation_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? ActivationTime { get; set; }

                /// <summary>
                /// 获取或设置商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置商户简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_shortname")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_shortname")]
                public string? MerchantShortName { get; set; }

                /// <summary>
                /// 获取或设置子商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置子商户简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_merchant_shortname")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_merchant_shortname")]
                public string? SubMerchantShortName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置设备列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Device[] DeviceList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
