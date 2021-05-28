using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappidvisitdistribution 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdVisitDistributionResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置场景 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public int Key { get; set; }

                        /// <summary>
                        /// 获取或设置该场景访问 PV。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public int Value { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分布类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("index")]
                [System.Text.Json.Serialization.JsonPropertyName("index")]
                public string Index { get; set; } = default!;

                /// <summary>
                /// 获取或设置分布数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_list")]
                [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                public Types.Item[] ItemList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置数据的日期（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ref_date")]
        [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
        public virtual string RefDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户访问分布数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
