using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-activity/activities 接口的请求。</para>
    /// </summary>
    public class CreateMarketingMemberCardActivityRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class AwardSendPeriod
            {
                public static class Types
                {
                    public class AwardSendTime
                    {
                        /// <summary>
                        /// 获取或设置开始时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                        public DateTimeOffset BeginTime { get; set; }

                        /// <summary>
                        /// 获取或设置结束时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                        public DateTimeOffset EndTime { get; set; }
                    }

                    public class AwardSendDayTime
                    {
                        public static class Types
                        {
                            public class DayTime : GetMarketingMemberCardActivityByActivityIdResponse.Types.AwardSendPeriod.Types.AwardSendDayTime.Types.DayTime
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置每日可用开始时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_day_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_day_time")]
                        public Types.DayTime BeginDayTime { get; set; } = new Types.DayTime();

                        /// <summary>
                        /// 获取或设置每日可用结束时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_day_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_day_time")]
                        public Types.DayTime EndDayTime { get; set; } = new Types.DayTime();
                    }
                }

                /// <summary>
                /// 获取或设置有效期内指定部分活动时间段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("award_send_time")]
                [System.Text.Json.Serialization.JsonPropertyName("award_send_time")]
                public Types.AwardSendTime[]? AwardSendTimeList { get; set; }

                /// <summary>
                /// 获取或设置指定时间段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("award_send_day_time")]
                [System.Text.Json.Serialization.JsonPropertyName("award_send_day_time")]
                public Types.AwardSendDayTime[]? AwardSendDayTimeList { get; set; }
            }
        
            public class Stock
            {
                /// <summary>
                /// 获取或设置批次号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_id")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                public string StockId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置创建批次的商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_creator_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_creator_mchid")]
                public string? StockCreatorMerchantId { get; set; }
            }

            public class PayActivitySetting
            {
                public static class Types
                {
                    public class ActivateSetting
                    {
                        public static class Types
                        {
                            public class MiniProgram
                            {
                                /// <summary>
                                /// 获取或设置小程序 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("activate_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("activate_appid")]
                                public string AppId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置小程序页面路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("activate_path")]
                                [System.Text.Json.Serialization.JsonPropertyName("activate_path")]
                                public string Path { get; set; } = string.Empty;                            
                            }
                        }

                        /// <summary>
                        /// 获取或设置激活类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activate_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("activate_type")]
                        public string ActivateType { get; set; } = string.Empty;
                        
                        /// <summary>
                        /// 获取或设置激活跳转的 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activate_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("activate_url")]
                        public string? ActivateUrl { get; set; }
                        
                        /// <summary>
                        /// 获取或设置激活跳转的小程序信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activate_miniprogram")]
                        [System.Text.Json.Serialization.JsonPropertyName("activate_miniprogram")]
                        public Types.MiniProgram? ActivateMiniProgram { get; set; }
                    }
                
                    public class PaymentSetting
                    {
                        public static class Types
                        {
                            public class PaymentMode
                            {
                                /// <summary>
                                /// 获取或设置支付场景值列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("payment_scene_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("payment_scene_list")]
                                public IList<string>? PaymentSceneList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置限定支付模式信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_mode")]
                        public Types.PaymentMode? LimitPaymentMode { get; set; }

                        /// <summary>
                        /// 获取或设置限定银行简称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("limit_bank")]
                        [System.Text.Json.Serialization.JsonPropertyName("limit_bank")]
                        public string? LimitBankName { get; set; }

                        /// <summary>
                        /// 获取或设置限定订单优惠标记列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_tags")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_tags")]
                        public IList<string>? LimitGoodsTagList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置会员卡 Logo 媒体文件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logo_url")]
                [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
                public string? LogoMediaUrl { get; set; }

                /// <summary>
                /// 获取或设置支付结果页活动副标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_second_title")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_second_title")]
                public string? ActivitySecondTitle { get; set; }

                /// <summary>
                /// 获取或设置活动曝光商户号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid_list")]
                public IList<string> MerchantIdList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置激活方式设置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activate_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("activate_setting")]
                public Types.ActivateSetting? ActivateSetting { get; set; }

                /// <summary>
                /// 获取或设置支付设置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_setting")]
                public Types.PaymentSetting? PaymentSetting { get; set; }
            }
        
            public class MiniProgramActivitySetting
            {
                public static class Types
                {
                    public class AwardSetting
                    { 
                        /// <summary>
                        /// 获取或设置跳转按钮文案。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("button_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("button_text")]
                        public string? ButtonText { get; set; }

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mini_program_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("mini_program_appid")]
                        public string? MiniProgramAppId { get; set; }

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mini_program_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("mini_program_path")]
                        public string? MiniProgramPath { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置领取渠道列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outer_str")]
                [System.Text.Json.Serialization.JsonPropertyName("outer_str")]
                public List<string>? OuterString { get; set; }   

                /// <summary>
                /// 获取或设置领奖页面跳转配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("award_jump_deploy")]
                [System.Text.Json.Serialization.JsonPropertyName("award_jump_deploy")]
                public Types.AwardSetting? AwardSetting { get; set; }   
            }
        }

        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_name")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
        public string ActivityName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_type")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_type")]
        public string ActivityType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? BeginTime { get; set; }

        /// <summary>
        /// 获取或设置活动结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置发放时间段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("award_send_period")]
        [System.Text.Json.Serialization.JsonPropertyName("award_send_period")]
        public Types.AwardSendPeriod? AwardSendPeriod { get; set; }

        /// <summary>
        /// 获取或设置优惠券批次列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_list")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_list")]
        public IList<Types.Stock> StockList { get; set; } = new List<Types.Stock>();

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置支付后活动设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_activity_setting")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_activity_setting")]
        public Types.PayActivitySetting? PayActivitySetting { get; set; }

        /// <summary>
        /// 获取或设置支付前会员活动设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_activity_setting")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_activity_setting")]
        public Types.MiniProgramActivitySetting? MiniProgramActivitySetting { get; set; }
    }
}
