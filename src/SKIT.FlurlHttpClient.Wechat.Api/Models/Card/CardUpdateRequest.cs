using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/update 接口的请求。</para>
    /// </summary>
    public class CardUpdateRequest : WechatApiRequest, IMapResponse<CardUpdateRequest, CardUpdateResponse>
    {
        public static class Types
        {
            public class GrouponCard
            {
                public static class Types
                {
                    public class Base
                    {
                        public static class Types
                        {
                            public class Date : CardCreateRequest.Types.GrouponCard.Types.Base.Types.Date
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置商户 Logo URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logo_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
                        public string? LogoUrl { get; set; }

                        /// <summary>
                        /// 获取或设置码型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("code_type")]
                        public string? CodeType { get; set; }

                        /// <summary>
                        /// 获取或设置商户名字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
                        public string? BrandName { get; set; }

                        /// <summary>
                        /// 获取或设置卡券名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置卡券颜色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("color")]
                        [System.Text.Json.Serialization.JsonPropertyName("color")]
                        public string? Color { get; set; }

                        /// <summary>
                        /// 获取或设置卡券使用提醒。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("notice")]
                        [System.Text.Json.Serialization.JsonPropertyName("notice")]
                        public string? Notice { get; set; }

                        /// <summary>
                        /// 获取或设置卡券使用说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置使用日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("date_info")]
                        public Types.Date? Date { get; set; }

                        /// <summary>
                        /// 获取或设置客服电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_phone")]
                        public string? ServicePhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置门店 Id 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("location_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("location_id_list")]
                        public IList<long>? POIIdList { get; set; }

                        /// <summary>
                        /// 获取或设置是否支持全部门店。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_all_locations")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_all_locations")]
                        public bool? UseAllPOIs { get; set; }

                        /// <summary>
                        /// 获取或设置显示在顶部居中的按钮文字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("center_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("center_title")]
                        public string? CenterTitle { get; set; }

                        /// <summary>
                        /// 获取或设置显示在入口下方的提示语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("center_sub_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("center_sub_title")]
                        public string? CenterSubTitle { get; set; }

                        /// <summary>
                        /// 获取或设置顶部居中的 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("center_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("center_url")]
                        public string? CenterUrl { get; set; }

                        /// <summary>
                        /// 获取或设置卡券跳转的小程序的原始 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("center_app_brand_user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("center_app_brand_user_name")]
                        public string? CenterBrandMiniProgramUsername { get; set; }

                        /// <summary>
                        /// 获取或设置卡券跳转的小程序的页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("center_app_brand_pass")]
                        [System.Text.Json.Serialization.JsonPropertyName("center_app_brand_pass")]
                        public string? CenterBrandMiniProgramPath { get; set; }

                        /// <summary>
                        /// 获取或设置自定义跳转外链的入口名字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_url_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_url_name")]
                        public string? CustomUrlTitle { get; set; }

                        /// <summary>
                        /// 获取或设置自定义跳转外链的入口右侧提示语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_url_sub_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_url_sub_title")]
                        public string? CustomUrlSubTitle { get; set; }

                        /// <summary>
                        /// 获取或设置自定义跳转外链。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_url")]
                        public string? CustomUrl { get; set; }

                        /// <summary>
                        /// 获取或设置卡券跳转的小程序的原始 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_app_brand_user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_app_brand_user_name")]
                        public string? CustomBrandMiniProgramUsername { get; set; }

                        /// <summary>
                        /// 获取或设置卡券跳转的小程序的页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_app_brand_pass")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_app_brand_pass")]
                        public string? CustomBrandMiniProgramPath { get; set; }

                        /// <summary>
                        /// 获取或设置营销场景的入口名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_url_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_url_name")]
                        public string? PromotionUrlTitle { get; set; }

                        /// <summary>
                        /// 获取或设置营销场景的入口右侧的提示语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_url_sub_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_url_sub_title")]
                        public string? PromotionUrlSubTitle { get; set; }

                        /// <summary>
                        /// 获取或设置营销场景外链。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_url")]
                        public string? PromotionUrl { get; set; }

                        /// <summary>
                        /// 获取或设置卡券跳转的小程序的原始 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_app_brand_user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_app_brand_user_name")]
                        public string? PromotionBrandMiniProgramUsername { get; set; }

                        /// <summary>
                        /// 获取或设置卡券跳转的小程序的页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_app_brand_pass")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_app_brand_pass")]
                        public string? PromotionBrandMiniProgramPath { get; set; }

                        /// <summary>
                        /// 获取或设置每人可领券的数量限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("get_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("get_limit")]
                        public int? GetLimitPerUser { get; set; }

                        /// <summary>
                        /// 获取或设置每人可核销的数量限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_limit")]
                        public int? UseLimitPerUser { get; set; }

                        /// <summary>
                        /// 获取或设置卡券领取页面是否可分享。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_share")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_share")]
                        public bool? CanShare { get; set; }

                        /// <summary>
                        /// 获取或设置卡券是否可转赠。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_give_friend")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_give_friend")]
                        public bool? CanTransfer { get; set; }

                        /// <summary>
                        /// 获取或设置第三方来源名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source")]
                        [System.Text.Json.Serialization.JsonPropertyName("source")]
                        public string? Source { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置团购详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deal_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("deal_detail")]
                public string? DealDetail { get; set; }
            }

            public class CashCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置起用金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("least_cost")]
                [System.Text.Json.Serialization.JsonPropertyName("least_cost")]
                public int? LeastCost { get; set; }

                /// <summary>
                /// 获取或设置减免金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reduce_cost")]
                [System.Text.Json.Serialization.JsonPropertyName("reduce_cost")]
                public int? ReduceCost { get; set; }
            }

            public class DiscountCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置打折额度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount")]
                [System.Text.Json.Serialization.JsonPropertyName("discount")]
                public int? Discount { get; set; }
            }

            public class GiftCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置兑换内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gift")]
                [System.Text.Json.Serialization.JsonPropertyName("gift")]
                public string? GiftDetail { get; set; }
            }

            public class GeneralCouponCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置优惠详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("default_detail")]
                public string? DefaultDetail { get; set; }
            }


            public class GeneralCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                        /// <summary>
                        /// 获取或设置进入礼品卡时是否推送事件。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_push_on_view")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_push_on_view")]
                        public bool? RequirePushOnView { get; set; }
                    }

                    public class CustomField : CardCreateRequest.Types.GeneralCard.Types.CustomField
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置礼品卡背景图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("background_pic_url")]
                [System.Text.Json.Serialization.JsonPropertyName("background_pic_url")]
                public string? BackgrounPictureUrl { get; set; }

                /// <summary>
                /// 获取或设置礼品卡特权说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prerogative")]
                [System.Text.Json.Serialization.JsonPropertyName("prerogative")]
                public string? Prerogative { get; set; }

                /// <summary>
                /// 获取或设置是否领取后自动激活。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_activate")]
                [System.Text.Json.Serialization.JsonPropertyName("auto_activate")]
                public bool? IsAutoActivate { get; set; }

                /// <summary>
                /// 获取或设置是否支持积分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supply_bonus")]
                [System.Text.Json.Serialization.JsonPropertyName("supply_bonus")]
                public bool? IsSupplyBonus { get; set; }

                /// <summary>
                /// 获取或设置是否支持余额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supply_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("supply_balance")]
                public bool? IsSupplyBalance { get; set; }

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

            public class MembershipCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                        public new static class Types
                        {
                            public class Payment
                            {
                                public static class Types
                                {
                                    public class SwipingCard
                                    {
                                        /// <summary>
                                        /// 获取或设置是否支持微信支付刷卡。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("is_swipe_card")]
                                        [System.Text.Json.Serialization.JsonPropertyName("is_swipe_card")]
                                        public bool CanSwipe { get; set; }
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
                        /// 获取或设置进入会员卡时是否推送事件。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_push_on_view")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_push_on_view")]
                        public bool? RequirePushOnView { get; set; }

                        /// <summary>
                        /// 获取或设置微信支付信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_info")]
                        public Types.Payment? Payment { get; set; }
                    }

                    public class CustomField : CardCreateRequest.Types.MembershipCard.Types.CustomField
                    {
                    }

                    public class CustomCell : CardCreateRequest.Types.MembershipCard.Types.CustomCell
                    {
                    }

                    public class BonusRule : CardCreateRequest.Types.MembershipCard.Types.BonusRule
                    {
                    }

                    public class Operation
                    {
                        public static class Types
                        {
                            public class UrlCell
                            {
                                /// <summary>
                                /// 获取或设置送券的 CardId 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("card_id_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("card_id_list")]
                                public IList<string>? CardIdList { get; set; }

                                /// <summary>
                                /// 获取或设置推荐位展示的截止时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public long? EndTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置文本内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string? Text { get; set; }

                                /// <summary>
                                /// 获取或设置跳转链接。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string? Url { get; set; }

                                /// <summary>
                                /// 获取或设置跳转链接对应的小程序 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_brand_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_brand_id")]
                                public string? BrandMiniProgramAppId { get; set; }

                                /// <summary>
                                /// 获取或设置跳转链接对应的小程序页面路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_brand_pass")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_brand_pass")]
                                public string? BrandMiniProgramPath { get; set; }
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
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置会员卡背景图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("background_pic_url")]
                [System.Text.Json.Serialization.JsonPropertyName("background_pic_url")]
                public string? BackgrounPictureUrl { get; set; }

                /// <summary>
                /// 获取或设置会员卡特权说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prerogative")]
                [System.Text.Json.Serialization.JsonPropertyName("prerogative")]
                public string? Prerogative { get; set; }

                /// <summary>
                /// 获取或设置是否领取后自动激活。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_activate")]
                [System.Text.Json.Serialization.JsonPropertyName("auto_activate")]
                public bool? IsAutoActivate { get; set; }

                /// <summary>
                /// 获取或设置是否支持一键开卡。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wx_activate")]
                [System.Text.Json.Serialization.JsonPropertyName("wx_activate")]
                public bool? IsWechatActivate { get; set; }

                /// <summary>
                /// 获取或设置是否支持跳转型一键激活。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wx_activate_after_submit")]
                [System.Text.Json.Serialization.JsonPropertyName("wx_activate_after_submit")]
                public bool? IsWechatActivateAfterSubmit { get; set; }

                /// <summary>
                /// 获取或设置激活会员卡外链。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activate_url")]
                [System.Text.Json.Serialization.JsonPropertyName("activate_url")]
                public string? ActivateUrl { get; set; }

                /// <summary>
                /// 获取或设置激活会员卡对应的小程序原始 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activate_app_brand_user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("activate_app_brand_user_name")]
                public string? ActivateBrandMiniProgramUsername { get; set; }

                /// <summary>
                /// 获取或设置激活会员卡对应的小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activate_app_brand_pass")]
                [System.Text.Json.Serialization.JsonPropertyName("activate_app_brand_pass")]
                public string? ActivateBrandMiniProgramPath { get; set; }

                /// <summary>
                /// 获取或设置跳转型一键激活的跳转外链。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wx_activate_after_submit_url")]
                [System.Text.Json.Serialization.JsonPropertyName("wx_activate_after_submit_url")]
                public string? WechatActivateAfterSubmitUrl { get; set; }

                /// <summary>
                /// 获取或设置是否支持积分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supply_bonus")]
                [System.Text.Json.Serialization.JsonPropertyName("supply_bonus")]
                public bool? IsSupplyBonus { get; set; }

                /// <summary>
                /// 获取或设置查看积分详情外链。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_url")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_url")]
                public string? BonusUrl { get; set; }

                /// <summary>
                /// 获取或设置积分清零规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_cleared")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_cleared")]
                public string? BonusClearedString { get; set; }

                /// <summary>
                /// 获取或设置积分规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_rules")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_rules")]
                public string? BonusRulesString { get; set; }

                /// <summary>
                /// 获取或设置积分规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_rule")]
                public Types.BonusRule? BonusRule { get; set; }

                /// <summary>
                /// 获取或设置是否支持储值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supply_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("supply_balance")]
                public bool? IsSupplyBalance { get; set; }

                /// <summary>
                /// 获取或设置查看余额详情外链。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance_url")]
                [System.Text.Json.Serialization.JsonPropertyName("balance_url")]
                public string? BalanceUrl { get; set; }

                /// <summary>
                /// 获取或设置储值规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance_rules")]
                [System.Text.Json.Serialization.JsonPropertyName("balance_rules")]
                public string? BalanceRules { get; set; }

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
                /// 获取或设置折扣优惠。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount")]
                [System.Text.Json.Serialization.JsonPropertyName("discount")]
                public int? Discount { get; set; }

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

            public class MeetingTicketCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置会议详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_detail")]
                public string? MeetingDetail { get; set; }

                /// <summary>
                /// 获取或设置会场导览图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("map_url")]
                [System.Text.Json.Serialization.JsonPropertyName("map_url")]
                public string? MapUrl { get; set; }
            }

            public class ScenicTicketCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置票类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket_class")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket_class")]
                public string? TicketClass { get; set; }

                /// <summary>
                /// 获取或设置景区导览图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guide_url")]
                [System.Text.Json.Serialization.JsonPropertyName("guide_url")]
                public string? GuideUrl { get; set; }
            }

            public class MovieTicketCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置电影详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public string? MovieDetail { get; set; }
            }

            public class BoardingPassCard
            {
                public static class Types
                {
                    public class Base : GrouponCard.Types.Base
                    {
                    }
                }

                /// <summary>
                /// 获取或设置卡券基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置起点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("from")]
                [System.Text.Json.Serialization.JsonPropertyName("from")]
                public string? From { get; set; }

                /// <summary>
                /// 获取或设置终点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("to")]
                [System.Text.Json.Serialization.JsonPropertyName("to")]
                public string? To { get; set; }

                /// <summary>
                /// 获取或设置航班。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flight")]
                [System.Text.Json.Serialization.JsonPropertyName("flight")]
                public string? Flight { get; set; }

                /// <summary>
                /// 获取或设置登机口。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gate")]
                [System.Text.Json.Serialization.JsonPropertyName("gate")]
                public string? Gate { get; set; }

                /// <summary>
                /// 获取或设置在线值机外链。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("check_in_url")]
                [System.Text.Json.Serialization.JsonPropertyName("check_in_url")]
                public string? CheckinUrl { get; set; }

                /// <summary>
                /// 获取或设置机型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("air_model")]
                [System.Text.Json.Serialization.JsonPropertyName("air_model")]
                public string? AirModel { get; set; }

                /// <summary>
                /// 获取或设置起飞时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("departure_time")]
                [System.Text.Json.Serialization.JsonPropertyName("departure_time")]
                public long? DepartureTimestamp { get; set; }

                /// <summary>
                /// 获取或设置降落时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("landing_time")]
                [System.Text.Json.Serialization.JsonPropertyName("landing_time")]
                public long? LandingTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置团购券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupon")]
        [System.Text.Json.Serialization.JsonPropertyName("groupon")]
        public Types.GrouponCard? Groupon { get; set; }

        /// <summary>
        /// 获取或设置代金券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash")]
        [System.Text.Json.Serialization.JsonPropertyName("cash")]
        public Types.CashCard? Cash { get; set; }

        /// <summary>
        /// 获取或设置折扣券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount")]
        [System.Text.Json.Serialization.JsonPropertyName("discount")]
        public Types.DiscountCard? Discount { get; set; }

        /// <summary>
        /// 获取或设置兑换券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gift")]
        [System.Text.Json.Serialization.JsonPropertyName("gift")]
        public Types.GiftCard? Gift { get; set; }

        /// <summary>
        /// 获取或设置优惠券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("general_coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("general_coupon")]
        public Types.GeneralCouponCard? GeneralCoupon { get; set; }

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
        public Types.MembershipCard? Membership { get; set; }

        /// <summary>
        /// 获取或设置会议门票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_ticket")]
        public Types.MeetingTicketCard? MeetingTicket { get; set; }

        /// <summary>
        /// 获取或设置景区门票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scenic_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("scenic_ticket")]
        public Types.ScenicTicketCard? ScenicTicket { get; set; }

        /// <summary>
        /// 获取或设置电影票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("movie_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("movie_ticket")]
        public Types.MovieTicketCard? MovieTicket { get; set; }

        /// <summary>
        /// 获取或设置飞机票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("boarding_pass")]
        [System.Text.Json.Serialization.JsonPropertyName("boarding_pass")]
        public Types.BoardingPassCard? BoardingPass { get; set; }
    }
}
