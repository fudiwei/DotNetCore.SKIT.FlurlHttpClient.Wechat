using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/devplugin?action=dev_apply_list 接口的请求。</para>
    /// </summary>
    public class WxaDevPluginDevApplyListRequest : WechatApiRequest, IMapResponse<WxaDevPluginDevApplyListRequest, WxaDevPluginDevApplyListResponse>
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "dev_apply_list";

        /// <summary>
        /// 获取或设置分页页数（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("num")]
        [System.Text.Json.Serialization.JsonPropertyName("num")]
        public int Limit { get; set; } = 10;
    }
}
