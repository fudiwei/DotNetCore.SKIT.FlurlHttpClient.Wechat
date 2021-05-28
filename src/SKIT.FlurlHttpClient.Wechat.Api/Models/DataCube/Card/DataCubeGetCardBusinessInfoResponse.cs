using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getcardbizuininfo 接口的响应。</para>
    /// </summary>
    public class DataCubeGetCardBusinessInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置数据的日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public string RefDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置浏览次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("view_cnt")]
                public int ViewCount { get; set; }

                /// <summary>
                /// 获取或设置浏览人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_user")]
                [System.Text.Json.Serialization.JsonPropertyName("view_user")]
                public int ViewUserCount { get; set; }

                /// <summary>
                /// 获取或设置领取次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_cnt")]
                public int ReceiveCount { get; set; }

                /// <summary>
                /// 获取或设置领取人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_user")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_user")]
                public int ReceiveUserCount { get; set; }

                /// <summary>
                /// 获取或设置使用次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_cnt")]
                public int ConsumeCount { get; set; }

                /// <summary>
                /// 获取或设置使用人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_user")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_user")]
                public int ConsumeUserCount { get; set; }

                /// <summary>
                /// 获取或设置转赠次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("given_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("given_cnt")]
                public int TransferCount { get; set; }

                /// <summary>
                /// 获取或设置转赠人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("given_user")]
                [System.Text.Json.Serialization.JsonPropertyName("given_user")]
                public int TransferUserCount { get; set; }

                /// <summary>
                /// 获取或设置过期次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_cnt")]
                public int ExpireCount { get; set; }

                /// <summary>
                /// 获取或设置过期人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_user")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_user")]
                public int ExpireUserCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
