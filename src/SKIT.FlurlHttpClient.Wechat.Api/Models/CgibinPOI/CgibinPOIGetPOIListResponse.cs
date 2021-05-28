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
            public class Business
            {
                public static class Types
                {
                    public class Base : CgibinPOIGetPOIResponse.Types.Business.Types.Base
                    {
                        /// <summary>
                        /// 获取或设置商户门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedStringConverter))]
                        public string? POIId { get; set; }
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
        public Types.Business[] BusinessList { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int Total { get; set; }
    }
}
