using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getusersharehour 接口的响应。</para>
    /// </summary>
    public class DataCubeGetUserShareHourResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data : DataCubeGetUserShareResponse.Types.Data
            {
                /// <summary>
                /// 获取或设置数据的小时（格式：Hmm）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_hour")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_hour")]
                public int RefHour { get; set; }
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
