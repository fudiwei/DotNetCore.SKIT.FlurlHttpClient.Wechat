namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/update 接口的请求。</para>
    /// </summary>
    public class CardUpdateRequest : WechatApiRequest, IInferable<CardUpdateRequest, CardUpdateResponse>
    {
        public static class Types
        {
            public abstract class __zz__CardBaseInfo : CardCreateRequest.Types.Card.Types.__zz__CardBaseInfo
            {
            }

            public class CardBaseInfo : __zz__CardBaseInfo
            {
                public static class Types
                {
                    public class Date : CardCreateRequest.Types.Card.Types.CardBaseInfo.Types.Date
                    {
                    }
                }
            }

            public class CardCustomField : CardCreateRequest.Types.Card.Types.CardCustomField
            {
            }

            public class CardCustomCell : CardCreateRequest.Types.Card.Types.CardCustomCell
            {
            }

            public class Groupon : CardCreateRequest.Types.Card.Types.__zz__Groupon
            {
                public static class Types
                {
                    public class BaseInfo : __zz__CardBaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }
            }

            public class Cash : CardCreateRequest.Types.Card.Types.__zz__Cash
            {
                public static class Types
                {
                    public class BaseInfo : __zz__CardBaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }
            }

            public class Discount : CardCreateRequest.Types.Card.Types.__zz__Discount
            {
                public static class Types
                {
                    public class BaseInfo : __zz__CardBaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }
            }

            public class Gift : CardCreateRequest.Types.Card.Types.__zz__Gift
            {
                public static class Types
                {
                    public class BaseInfo : __zz__CardBaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }
            }

            public class GeneralCoupon : CardCreateRequest.Types.Card.Types.__zz__GeneralCoupon
            {
                public static class Types
                {
                    public class BaseInfo : __zz__CardBaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }
            }

            public class GeneralCard : CardCreateRequest.Types.Card.Types.__zz__GeneralCard
            {
                public static class Types
                {
                    public class BaseInfo : CardCreateRequest.Types.Card.Types.GeneralCard.Types.__zz__BaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }

                            public class GiftCard : CardCreateRequest.Types.Card.Types.GeneralCard.Types.BaseInfo.Types.GiftCard
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }

                        /// <summary>
                        /// 获取或设置礼品卡信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("giftcard_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("giftcard_info")]
                        public Types.GiftCard? GiftCard { get; set; }
                    }

                    public class CustomField : CardCustomField
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }

                /// <summary>
                /// 获取或设置自定义会员信息类目 1 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field1")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field1")]
                public Types.CustomField? CustomField1 { get; set; }

                /// <summary>
                /// 获取或设置自定义会员信息类目 2 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field2")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field2")]
                public Types.CustomField? CustomField2 { get; set; }

                /// <summary>
                /// 获取或设置自定义会员信息类目 3 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field3")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field3")]
                public Types.CustomField? CustomField3 { get; set; }
            }

            public class Membership : CardCreateRequest.Types.Card.Types.__zz__Membership
            {
                public static class Types
                {
                    public class BaseInfo : CardCreateRequest.Types.Card.Types.Membership.Types.__zz__BaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }

                            public class Payment
                            {
                                public static class Types
                                {
                                    public class SwipingCard : CardCreateRequest.Types.Card.Types.Membership.Types.BaseInfo.Types.Payment.Types.SwipingCard
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置是否支持微信支付刷卡。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("swipe_card")]
                                [System.Text.Json.Serialization.JsonPropertyName("swipe_card")]
                                public Types.SwipingCard? SwipingCard { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }

                        /// <summary>
                        /// 获取或设置微信支付信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_info")]
                        public Types.Payment? Payment { get; set; }
                    }

                    public class CustomField : CardCustomField
                    {
                    }

                    public class CustomCell : CardCustomCell
                    {
                    }

                    public class BonusRule : CardCreateRequest.Types.Card.Types.Membership.Types.BonusRule
                    {
                    }

                    public class Operation
                    {
                        public static class Types
                        {
                            public class UrlCell : CardCreateRequest.Types.Card.Types.Membership.Types.Operation.Types.UrlCell
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置推荐内容信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url_cell")]
                        [System.Text.Json.Serialization.JsonPropertyName("url_cell")]
                        public Types.UrlCell? UrlCell { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }

                /// <summary>
                /// 获取或设置积分规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_rule")]
                public Types.BonusRule? BonusRule { get; set; }

                /// <summary>
                /// 获取或设置自定义会员信息类目 1 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field1")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field1")]
                public Types.CustomField? CustomField1 { get; set; }

                /// <summary>
                /// 获取或设置自定义会员信息类目 2 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field2")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field2")]
                public Types.CustomField? CustomField2 { get; set; }

                /// <summary>
                /// 获取或设置自定义会员信息类目 3 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field3")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field3")]
                public Types.CustomField? CustomField3 { get; set; }

                /// <summary>
                /// 获取或设置自定义会员服务入口 1 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_cell1")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_cell1")]
                public Types.CustomCell? CustomCell1 { get; set; }

                /// <summary>
                /// 获取或设置自定义会员服务入口 2 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_cell2")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_cell2")]
                public Types.CustomCell? CustomCell2 { get; set; }

                /// <summary>
                /// 获取或设置自定义会员服务入口 3 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_cell3")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_cell3")]
                public Types.CustomCell? CustomCell3 { get; set; }

                /// <summary>
                /// 获取或设置积分余额等变动消息赠券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_msg_operation")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_msg_operation")]
                public Types.Operation? OperationAfterModify { get; set; }

                /// <summary>
                /// 获取或设置会员卡激活消息赠券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activate_msg_operation")]
                [System.Text.Json.Serialization.JsonPropertyName("activate_msg_operation")]
                public Types.Operation? OperationAfterActivate { get; set; }
            }

            public class MeetingTicket : CardCreateRequest.Types.Card.Types.__zz__MeetingTicket
            {
                public static class Types
                {
                    public class BaseInfo : CardCreateRequest.Types.Card.Types.__zz__CardBaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }
            }

            public class ScenicTicket : CardCreateRequest.Types.Card.Types.__zz__ScenicTicket
            {
                public static class Types
                {
                    public class BaseInfo : CardCreateRequest.Types.Card.Types.__zz__CardBaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }
            }

            public class MovieTicket : CardCreateRequest.Types.Card.Types.__zz__MovieTicket
            {
                public static class Types
                {
                    public class BaseInfo : CardCreateRequest.Types.Card.Types.__zz__CardBaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }
            }

            public class BoardingPass : CardCreateRequest.Types.Card.Types.__zz__BoardingPass
            {
                public static class Types
                {
                    public class BaseInfo : CardCreateRequest.Types.Card.Types.__zz__CardBaseInfo
                    {
                        public static class Types
                        {
                            public class Date : CardBaseInfo.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置团购券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupon")]
        [System.Text.Json.Serialization.JsonPropertyName("groupon")]
        public Types.Groupon? Groupon { get; set; }

        /// <summary>
        /// 获取或设置代金券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash")]
        [System.Text.Json.Serialization.JsonPropertyName("cash")]
        public Types.Cash? Cash { get; set; }

        /// <summary>
        /// 获取或设置折扣券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount")]
        [System.Text.Json.Serialization.JsonPropertyName("discount")]
        public Types.Discount? Discount { get; set; }

        /// <summary>
        /// 获取或设置兑换券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gift")]
        [System.Text.Json.Serialization.JsonPropertyName("gift")]
        public Types.Gift? Gift { get; set; }

        /// <summary>
        /// 获取或设置优惠券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("general_coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("general_coupon")]
        public Types.GeneralCoupon? GeneralCoupon { get; set; }

        /// <summary>
        /// 获取或设置礼品卡信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("general_card")]
        [System.Text.Json.Serialization.JsonPropertyName("general_card")]
        public Types.GeneralCard? GeneralCard { get; set; }

        /// <summary>
        /// 获取或设置会员卡信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("member_card")]
        [System.Text.Json.Serialization.JsonPropertyName("member_card")]
        public Types.Membership? Membership { get; set; }

        /// <summary>
        /// 获取或设置会议门票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_ticket")]
        public Types.MeetingTicket? MeetingTicket { get; set; }

        /// <summary>
        /// 获取或设置景区门票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scenic_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("scenic_ticket")]
        public Types.ScenicTicket? ScenicTicket { get; set; }

        /// <summary>
        /// 获取或设置电影票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("movie_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("movie_ticket")]
        public Types.MovieTicket? MovieTicket { get; set; }

        /// <summary>
        /// 获取或设置飞机票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("boarding_pass")]
        [System.Text.Json.Serialization.JsonPropertyName("boarding_pass")]
        public Types.BoardingPass? BoardingPass { get; set; }
    }
}
