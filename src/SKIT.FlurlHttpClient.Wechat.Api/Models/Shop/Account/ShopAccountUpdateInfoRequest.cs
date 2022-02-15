using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/account/update_info 接口的请求。</para>
    /// </summary>
    public class ShopAccountUpdateInfoRequest : WechatApiRequest, IMapResponse<ShopAccountUpdateInfoRequest, ShopAccountUpdateInfoResponse>
    {
        /// <summary>
        /// 获取或设置客服页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_agent_path")]
        [System.Text.Json.Serialization.JsonPropertyName("service_agent_path")]
        public string? ServiceAgentPagePath { get; set; }

        /// <summary>
        /// 获取或设置客服联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_agent_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("service_agent_phone")]
        public string? ServiceAgentPhoneNumber { get; set; }
    }
}
