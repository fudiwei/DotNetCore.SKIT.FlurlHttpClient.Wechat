using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/get_wxa_followers 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGetWxaFollowersRequest : WechatApiRequest, IMapResponse<WxaBusinessGetWxaFollowersRequest, WxaBusinessGetWxaFollowersResponse>
    {
        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_break")]
        [System.Text.Json.Serialization.JsonPropertyName("page_break")]
        public int? NextPageBreak { get; set; }
    }
}
