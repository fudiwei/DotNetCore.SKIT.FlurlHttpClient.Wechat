using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/poi/getpoilist 接口的请求。</para>
    /// </summary>
    public class CgibinPOIGetPOIListRequest : WechatApiRequest, IMapResponse<CgibinPOIGetPOIListRequest, CgibinPOIGetPOIListResponse>
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin")]
        [System.Text.Json.Serialization.JsonPropertyName("begin")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 20;
    }
}
