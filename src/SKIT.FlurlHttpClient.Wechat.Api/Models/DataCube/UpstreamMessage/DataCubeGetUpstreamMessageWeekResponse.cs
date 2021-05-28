using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getupstreammsgweek 接口的响应。</para>
    /// </summary>
    public class DataCubeGetUpstreamMessageWeekResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data : DataCubeGetUpstreamMessageResponse.Types.Data
            {
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
