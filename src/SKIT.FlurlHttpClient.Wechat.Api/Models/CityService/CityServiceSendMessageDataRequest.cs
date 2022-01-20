using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/sendmsgdata 接口的请求。</para>
    /// </summary>
    public class CityServiceSendMessageDataRequest : WechatApiRequest
    {
        public static class Types
        {
            public class DataItem : CgibinMessageTemplateSendRequest.Types.DataItem
            {
            }
        }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置城市服务分配的模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_template_id")]
        public string BusinessTemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结果页样式 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_page_style_id")]
        [System.Text.Json.Serialization.JsonPropertyName("result_page_style_id")]
        public string? ResultPageStyleId { get; set; }

        /// <summary>
        /// 获取或设置办事记录样式 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deal_msg_style_id")]
        [System.Text.Json.Serialization.JsonPropertyName("deal_msg_style_id")]
        public string? DealMessageStyleId { get; set; }

        /// <summary>
        /// 获取或设置页卡样式 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_style_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_style_id")]
        public string? CardStyleId { get; set; }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("order_no")]
        public string OrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置跳转链接 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 获取或设置消息正文。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IDictionary<string, Types.DataItem>? Data { get; set; }
    }
}
