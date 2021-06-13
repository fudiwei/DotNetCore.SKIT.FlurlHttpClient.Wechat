using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/poi/updatepoi 接口的请求。</para>
    /// </summary>
    public class CgibinPOIUpdatePOIRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Business
            {
                public static class Types
                {
                    public class Base
                    {
                        public static class Types
                        {
                            public class Photo : CgibinPOIAddPOIRequest.Types.POI.Types.Base.Types.Photo
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置商户门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sid")]
                        [System.Text.Json.Serialization.JsonPropertyName("sid")]
                        public string? SID { get; set; }

                        /// <summary>
                        /// 获取或设置门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string POIId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置联系电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("telephone")]
                        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                        public string? Telephone { get; set; }

                        /// <summary>
                        /// 获取或设置门店照片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("photo_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("photo_list")]
                        public IList<Types.Photo>? PhotoList { get; set; }

                        /// <summary>
                        /// 获取或设置推荐品。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recommend")]
                        [System.Text.Json.Serialization.JsonPropertyName("recommend")]
                        public string? Recommend { get; set; }

                        /// <summary>
                        /// 获取或设置特色服务。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("special")]
                        [System.Text.Json.Serialization.JsonPropertyName("special")]
                        public string? Special { get; set; }

                        /// <summary>
                        /// 获取或设置商户简介。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("introduction")]
                        [System.Text.Json.Serialization.JsonPropertyName("introduction")]
                        public string? Introduction { get; set; }

                        /// <summary>
                        /// 获取或设置营业时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_time")]
                        public string? OpenTime { get; set; }

                        /// <summary>
                        /// 获取或设置人均价格（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avg_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("avg_price")]
                        public double? AveragePrice { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置门店基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();
            }
        }

        /// <summary>
        /// 获取或设置门店信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business")]
        [System.Text.Json.Serialization.JsonPropertyName("business")]
        public Types.Business Business { get; set; } = new Types.Business();
    }
}
