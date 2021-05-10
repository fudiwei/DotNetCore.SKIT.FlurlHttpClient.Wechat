using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/busifavor/stocks/{stock_id} 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingBusifavorStockRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class StockSendRule
            {
                /// <summary>
                /// 获取或设置是否开启自然人限制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("natural_person_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("natural_person_limit")]
                public bool? IsNaturalPersonLimit { get; set; }

                /// <summary>
                /// 获取或设置是否开启防刷拦截。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prevent_api_abuse")]
                [System.Text.Json.Serialization.JsonPropertyName("prevent_api_abuse")]
                public bool? IsPreventApiAbuse { get; set; }
            }

            public class CouponUseRule
            {
                /// <summary>
                /// 获取或设置核销方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_method")]
                [System.Text.Json.Serialization.JsonPropertyName("use_method")]
                public string? UseMethod { get; set; }

                /// <summary>
                /// 获取或设置商家小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mini_programs_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("mini_programs_appid")]
                public string? MiniProgramAppId { get; set; }

                /// <summary>
                /// 获取或设置商家小程序路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mini_programs_path")]
                [System.Text.Json.Serialization.JsonPropertyName("mini_programs_path")]
                public string? MiniProgramPath { get; set; }
            }

            public class Entrance : CreateMarketingBusifavorStockRequest.Types.Entrance
            {
            }

            public class Pattern : CreateMarketingBusifavorStockRequest.Types.Pattern
            {
            }

            public class NotifyConfig : CreateMarketingBusifavorStockRequest.Types.NotifyConfig
            {
            }
        }

        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批次名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_name")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_name")]
        public string? StockName { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发放规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_send_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_send_rule")]
        public Types.StockSendRule? StockSendRule { get; set; }

        /// <summary>
        /// 获取或设置核销规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_use_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_use_rule")]
        public Types.CouponUseRule? CouponUseRule { get; set; }

        /// <summary>
        /// 获取或设置自定义入口信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_entrance")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_entrance")]
        public Types.Entrance? CustomEntrance { get; set; }

        /// <summary>
        /// 获取或设置样式设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_pattern_info")]
        [System.Text.Json.Serialization.JsonPropertyName("display_pattern_info")]
        public Types.Pattern? DisplayPattern { get; set; }

        /// <summary>
        /// 获取或设置事件通知配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_config")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_config")]
        public Types.NotifyConfig? NotifyConfig { get; set; }

        /// <summary>
        /// 获取或设置适用商品范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_name")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
        public string? GoodsName { get; set; }

        /// <summary>
        /// 获取或设置批次备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
