using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/vehicle/querystate 接口的响应。</para>
    /// </summary>
    public class NontaxVehicleQueryStateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用户状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_state")]
        [System.Text.Json.Serialization.JsonPropertyName("user_state")]
        public string UserState { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置跳转车主小程序的页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }

        /// <summary>
        /// 获取或设置车牌号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number_info")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number_info")]
        public string[]? PlateNumberList { get; set; }

        /// <summary>
        /// 获取或设置授权参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_package")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_package")]
        public IDictionary<string, string>? AuthorizePackage { get; set; }
    }
}
