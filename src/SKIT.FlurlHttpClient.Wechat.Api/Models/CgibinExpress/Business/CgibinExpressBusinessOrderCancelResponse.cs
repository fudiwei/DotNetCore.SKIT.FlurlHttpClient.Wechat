using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/order/cancel 接口的响应。</para>
    /// </summary>
    public class CgibinExpressBusinessOrderCancelResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置快递侧错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_resultcode")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_resultcode")]
        public int? ResultCode { get; set; }

        /// <summary>
        /// 获取或设置快递侧错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_resultmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_resultmsg")]
        public string? ResultMessage { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode.GetValueOrDefault() == 0;
        }
    }
}
