namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/sync_msg 接口的响应。</para>
    /// </summary>
    public class CgibinKfSyncMessageResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Message
            {
                public static class Types
                {
                    public class TextMessage : CgibinKfSendMessageRequest.Types.TextMessage
                    {
                        /// <summary>
                        /// 获取或设置客户点击菜单的菜单项 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("menu_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("menu_id")]
                        public string? MenuId { get; set; }
                    }

                    public class ImageMessage : CgibinKfSendMessageRequest.Types.ImageMessage
                    {
                    }

                    public class VoiceMessage : CgibinKfSendMessageRequest.Types.VoiceMessage
                    {
                    }

                    public class VideoMessage : CgibinKfSendMessageRequest.Types.VideoMessage
                    {
                    }

                    public class FileMessage : CgibinKfSendMessageRequest.Types.FileMessage
                    {
                    }

                    public class LinkMessage : CgibinKfSendMessageRequest.Types.LinkMessage
                    {
                        /// <summary>
                        /// 获取或设置图文封面的 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_url")]
                        public string ThumbnailUrl { get; set; } = default!;
                    }

                    public class MiniProgramMessage : CgibinKfSendMessageRequest.Types.MiniProgramMessage
                    {
                    }

                    public class MenuMessage : CgibinKfSendMessageRequest.Types.MenuMessage
                    {
                    }

                    public class LocationMessage : CgibinKfSendMessageRequest.Types.LocationMessage
                    {
                    }

                    public class BusinessCardMessage : CgibinKfSendMessageRequest.Types.BusinessCardMessage
                    {
                    }

                    public class EventMessage
                    {
                        public static class Types
                        {
                            public class WechatChannels
                            {
                                /// <summary>
                                /// 获取或设置视频号昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                public string? Nickname { get; set; }

                                /// <summary>
                                /// 获取或设置场景值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scene")]
                                [System.Text.Json.Serialization.JsonPropertyName("scene")]
                                public int Scene { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置事件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
                        public string EventType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置客户账号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_kfid")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
                        public string? OpenKfId { get; set; }

                        /// <summary>
                        /// 获取或设置外部联系人账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                        public string? ExternalUserId { get; set; }

                        /// <summary>
                        /// 获取或设置专员的 UserId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("servicer_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("servicer_userid")]
                        public string? ServicerUserId { get; set; }

                        /// <summary>
                        /// 获取或设置场景值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene")]
                        public string? Scene { get; set; }

                        /// <summary>
                        /// 获取或设置场景参数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_param")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_param")]
                        public string? SceneParameter { get; set; }

                        /// <summary>
                        /// 获取或设置欢迎语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("welcome_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("welcome_code")]
                        public string? WelcomeCode { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int? Status { get; set; }

                        /// <summary>
                        /// 获取或设置发送失败的消息 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_msgid")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_msgid")]
                        public string? FailedMessageId { get; set; }

                        /// <summary>
                        /// 获取或设置发送失败的类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_type")]
                        public int? FailedType { get; set; }

                        /// <summary>
                        /// 获取或设置变更类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("change_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("change_type")]
                        public int? ChangeType { get; set; }

                        /// <summary>
                        /// 获取或设置旧的专员 UserId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("old_servicer_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("old_servicer_userid")]
                        public string? OldServicerUserId { get; set; }

                        /// <summary>
                        /// 获取或设置新的专员 UserId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_servicer_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_servicer_userid")]
                        public string? NewServicerUserId { get; set; }

                        /// <summary>
                        /// 获取或设置用于发送事件响应消息的 Code。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_code")]
                        public string? MessageCode { get; set; }

                        /// <summary>
                        /// 获取或设置视频号信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wechat_channels")]
                        [System.Text.Json.Serialization.JsonPropertyName("wechat_channels")]
                        public Types.WechatChannels? WechatChannels { get; set; }

                        /// <summary>
                        /// 获取或设置撤回的消息 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recall_msgid")]
                        [System.Text.Json.Serialization.JsonPropertyName("recall_msgid")]
                        public string? RecalledMessageId { get; set; }
                    }

                    public class ChannelsShopProductMessage
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品头图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_img")]
                        public string HeadImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_price")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int SalesPrice { get; set; }

                        /// <summary>
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_nickname")]
                        public string ShopNickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_head_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_head_img")]
                        public string ShopHeadImageUrl { get; set; } = default!;
                    }

                    public class ChannelsShopOrderMessage
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_titles")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_titles")]
                        public string ProductTitle { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品价格描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price_wording")]
                        [System.Text.Json.Serialization.JsonPropertyName("price_wording")]
                        public string PriceWording { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("state")]
                        [System.Text.Json.Serialization.JsonPropertyName("state")]
                        public string State { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单缩略图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                        public string ImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_nickname")]
                        public string ShopNickname { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string MessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgtype")]
                [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                public string MessageType { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("origin")]
                [System.Text.Json.Serialization.JsonPropertyName("origin")]
                public int MessageOrigin { get; set; }

                /// <summary>
                /// 获取或设置客服账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_kfid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
                public string? OpenKfId { get; set; }

                /// <summary>
                /// 获取或设置接待人员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("servicer_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("servicer_userid")]
                public string? ServicerUserId { get; set; }

                /// <summary>
                /// 获取或设置外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string? ExternalUserId { get; set; }

                /// <summary>
                /// 获取或设置文本消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public Types.TextMessage? MessageContentForText { get; set; }

                /// <summary>
                /// 获取或设置图片消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public Types.ImageMessage? MessageContentForImage { get; set; }

                /// <summary>
                /// 获取或设置语音消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voice")]
                [System.Text.Json.Serialization.JsonPropertyName("voice")]
                public Types.VoiceMessage? MessageContentForVoice { get; set; }

                /// <summary>
                /// 获取或设置视频消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public Types.VideoMessage? MessageContentForVideo { get; set; }

                /// <summary>
                /// 获取或设置文件消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file")]
                [System.Text.Json.Serialization.JsonPropertyName("file")]
                public Types.FileMessage? MessageContentForFile { get; set; }

                /// <summary>
                /// 获取或设置图文消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link")]
                [System.Text.Json.Serialization.JsonPropertyName("link")]
                public Types.LinkMessage? MessageContentForLink { get; set; }

                /// <summary>
                /// 获取或设置小程序消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("miniprogram")]
                [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                public Types.MiniProgramMessage? MessageContentForMiniProgram { get; set; }

                /// <summary>
                /// 获取或设置菜单消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgmenu")]
                [System.Text.Json.Serialization.JsonPropertyName("msgmenu")]
                public Types.MenuMessage? MessageContentForMenu { get; set; }

                /// <summary>
                /// 获取或设置地理位置消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Types.LocationMessage? MessageContentForLocation { get; set; }

                /// <summary>
                /// 获取或设置名片消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_card")]
                [System.Text.Json.Serialization.JsonPropertyName("business_card")]
                public Types.BusinessCardMessage? MessageContentForBusinessCard { get; set; }

                /// <summary>
                /// 获取或设置事件消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event")]
                [System.Text.Json.Serialization.JsonPropertyName("event")]
                public Types.EventMessage? MessageContentForEvent { get; set; }

                /// <summary>
                /// 获取或设置视频号商品消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channels_shop_product")]
                [System.Text.Json.Serialization.JsonPropertyName("channels_shop_product")]
                public Types.ChannelsShopProductMessage? MessageContentForChannelsShopProduct { get; set; }

                /// <summary>
                /// 获取或设置视频号订单消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channels_shop_order")]
                [System.Text.Json.Serialization.JsonPropertyName("channels_shop_order")]
                public Types.ChannelsShopOrderMessage? MessageContentForChannelsShopOrder { get; set; }

                /// <summary>
                /// 获取或设置发送时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_time")]
                [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                public long SendTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_list")]
        public Types.Message[] MessageList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
