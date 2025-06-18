using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/open_msg/query_follow_trace 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-05-31 下线。")]
    public class CgibinExpressDeliveryOpenMessageQueryFollowTraceRequest : WechatApiRequest, IInferable<CgibinExpressDeliveryOpenMessageQueryFollowTraceRequest, CgibinExpressDeliveryOpenMessageQueryFollowTraceResponse>
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信订单查询 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_token")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_token")]
        public string WaybillToken { get; set; } = string.Empty;
    }
}
