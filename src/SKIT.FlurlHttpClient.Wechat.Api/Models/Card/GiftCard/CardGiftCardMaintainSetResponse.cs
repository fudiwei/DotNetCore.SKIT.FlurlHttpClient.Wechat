using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/maintain/set 接口的响应。</para>
    /// </summary>
    public class CardGiftCardMaintainSetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Control
            {
                public static class Types
                {
                    public class Page
                    {
                        /// <summary>
                        /// 获取或设置货架 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedStringConverter))]
                        public string PageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商户控制的货架状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_control_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_control_type")]
                        public string PageControlType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置系统控制的货架状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("system_page_control_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("system_page_control_type")]
                        public string SystemPageControlType { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商户控制的所有货架的状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_control_type")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_control_type")]
                public string BusinessControlType { get; set; } = default!;

                /// <summary>
                /// 获取或设置系统控制的所有货架的状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("system_biz_control_type")]
                [System.Text.Json.Serialization.JsonPropertyName("system_biz_control_type")]
                public string SystemBusinessControlType { get; set; } = default!;

                /// <summary>
                /// 获取或设置货架列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Page[] PageList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置控制结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("control_info")]
        [System.Text.Json.Serialization.JsonPropertyName("control_info")]
        public Types.Control Control { get; set; } = default!;
    }
}
