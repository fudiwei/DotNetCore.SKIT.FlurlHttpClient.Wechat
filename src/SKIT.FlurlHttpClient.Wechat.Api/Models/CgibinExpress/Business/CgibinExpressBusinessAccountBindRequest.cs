using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/account/bind 接口的请求。</para>
    /// </summary>
    public class CgibinExpressBusinessAccountBindRequest : WechatApiRequest, IMapResponse<CgibinExpressBusinessAccountBindRequest, CgibinExpressBusinessAccountBindResponse>
    {
        /// <summary>
        /// 获取或设置执行操作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_id")]
        public string BusinessId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司客户密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("password")]
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 获取或设置备注内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark_content")]
        [System.Text.Json.Serialization.JsonPropertyName("remark_content")]
        public string? RemarkContent { get; set; }
    }
}
