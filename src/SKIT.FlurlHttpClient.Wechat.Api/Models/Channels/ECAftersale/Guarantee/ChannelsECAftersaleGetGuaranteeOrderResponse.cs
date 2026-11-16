namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/getguaranteeorder 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleGetGuaranteeOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class GuaranteeOrder : ChannelsECAftersaleSearchGuaranteeOrderResponse.Types.__zz__GuaranteeOrder
            {
                public static class Types
                {
                    public class ProductInfo : ChannelsECAftersaleSearchGuaranteeOrderResponse.Types.GuaranteeOrder.Types.ProductInfo
                    {
                    }

                    public class OrderPayInfo : ChannelsECAftersaleSearchGuaranteeOrderResponse.Types.GuaranteeOrder.Types.OrderPayInfo
                    {
                    }

                    public class OrderPresentInfo : ChannelsECAftersaleSearchGuaranteeOrderResponse.Types.GuaranteeOrder.Types.OrderPresentInfo
                    {
                    }

                    public class Fake1Pay4Info : ChannelsECAftersaleSearchGuaranteeOrderResponse.Types.GuaranteeOrder.Types.__zz__Fake1Pay4Info
                    {
                        /// <summary>
                        /// 获取或设置鉴定凭证列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_identify_proof_pic_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_identify_proof_pic_list")]
                        public List<MediaFile>? NewIdentifyProofMediaList { get; set; }

                        /// <summary>
                        /// 获取或设置费用凭证列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_fee_proof_pic_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_fee_proof_pic_list")]
                        public List<MediaFile>? NewFeeProofMediaList { get; set; }
                    }

                    public class BadPayInfo : ChannelsECAftersaleSearchGuaranteeOrderResponse.Types.GuaranteeOrder.Types.__zz__BadPayInfo
                    {
                        public static class Types
                        {
                            public class TitlePicture : ChannelsECAftersaleSearchGuaranteeOrderResponse.Types.GuaranteeOrder.Types.BadPayInfo.Types.__zz__TitlePicture
                            {
                                /// <summary>
                                /// 获取或设置凭证图片列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("new_media_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("new_media_list")]
                                public List<MediaFile>? NewMediaList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置损坏凭证图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_pic_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_pic_list")]
                        public List<MediaFile>? NewPictureList { get; set; }

                        /// <summary>
                        /// 获取或设置凭证图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title_pic_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("title_pic_list")]
                        public List<Types.TitlePicture>? TitlePictureList { get; set; }
                    }

                    public class MediaFile : ChannelsECAftersaleGetAftersaleOrderResponse.Types.AftersaleOrder.Types.__zz__MediaFile
                    {
                        public static class Types
                        {
                            public class Picture : ChannelsECAftersaleGetAftersaleOrderResponse.Types.AftersaleOrder.Types.MediaFile.Types.Picture
                            {
                            }

                            public class Video : ChannelsECAftersaleGetAftersaleOrderResponse.Types.AftersaleOrder.Types.MediaFile.Types.Video
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置图片信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("picture")]
                        [System.Text.Json.Serialization.JsonPropertyName("picture")]
                        public Types.Picture? Picture { get; set; }

                        /// <summary>
                        /// 获取或设置视频信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video")]
                        [System.Text.Json.Serialization.JsonPropertyName("video")]
                        public Types.Video? Video { get; set; }
                    }

                    public class History
                    {
                        /// <summary>
                        /// 获取或设置事件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event")]
                        [System.Text.Json.Serialization.JsonPropertyName("event")]
                        public int EventType { get; set; }

                        /// <summary>
                        /// 获取或设置事件时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time")]
                        [System.Text.Json.Serialization.JsonPropertyName("time")]
                        public int Timestamp { get; set; }

                        /// <summary>
                        /// 获取或设置客服名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("kf_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("kf_name")]
                        public string? KfName { get; set; }

                        /// <summary>
                        /// 获取或设置文字内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string? Content { get; set; }

                        /// <summary>
                        /// 获取或设置凭证图片 MediaId 列表。
                        /// </summary>
                        [Obsolete("相关接口或字段于 2026-10-12 下线。")]
                        [Newtonsoft.Json.JsonProperty("pic_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_list")]
                        public List<string>? PictureMediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置凭证图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_media_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_media_list")]
                        public List<MediaFile>? NewPictureMediaList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                public List<Types.ProductInfo>? ProductList { get; set; }

                /// <summary>
                /// 获取或设置支付信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_pay_info")]
                [System.Text.Json.Serialization.JsonPropertyName("order_pay_info")]
                public Types.OrderPayInfo? OrderPayInfo { get; set; }

                /// <summary>
                /// 获取或设置礼物信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_present_info")]
                [System.Text.Json.Serialization.JsonPropertyName("order_present_info")]
                public Types.OrderPresentInfo? OrderPresentInfo { get; set; }

                /// <summary>
                /// 获取或设置假一赔四信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fake_one_pay_four_info")]
                [System.Text.Json.Serialization.JsonPropertyName("fake_one_pay_four_info")]
                public Types.Fake1Pay4Info? Fake1Pay4Info { get; set; }

                /// <summary>
                /// 获取或设置坏损包退信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bad_pay_info")]
                [System.Text.Json.Serialization.JsonPropertyName("bad_pay_info")]
                public Types.BadPayInfo? BadPayInfo { get; set; }

                /// <summary>
                /// 获取或设置协商历史列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("history_list")]
                [System.Text.Json.Serialization.JsonPropertyName("history_list")]
                public List<Types.History>? HistoryList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置保障单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guarantee_order")]
        [System.Text.Json.Serialization.JsonPropertyName("guarantee_order")]
        public Types.GuaranteeOrder? GuaranteeOrder { get; set; }
    }
}
