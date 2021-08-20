using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/poi/getpoilist 接口的响应。</para>
    /// </summary>
    public class CgibinPOIGetPOIListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class POI
            {
                public static class Types
                {
                    public class Base : CgibinPOIGetPOIResponse.Types.POI.Types.Base
                    {
                        /// <summary>
                        /// 获取或设置门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                        public string POIId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置腾讯地图的位置点 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mapid")]
                        [System.Text.Json.Serialization.JsonPropertyName("mapid")]
                        public string? MapPOIId { get; set; }

                        /// <summary>
                        /// 获取或设置迁移状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upgrade_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("upgrade_status")]
                        public int? UpgradeStatus { get; set; }

                        /// <summary>
                        /// 获取或设置迁移驳回的理由。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upgrade_comment")]
                        [System.Text.Json.Serialization.JsonPropertyName("upgrade_comment")]
                        public string? UpgradeRejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置门店基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_list")]
        [System.Text.Json.Serialization.JsonPropertyName("business_list")]
        public Types.POI[] POIList { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int Total { get; set; }
    }
}
