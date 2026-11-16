namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/merchantrefuseguarantee 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleMerchantRefuseGuaranteeRequest : WechatApiRequest, IInferable<ChannelsECAftersaleMerchantRefuseGuaranteeRequest, ChannelsECAftersaleMerchantRefuseGuaranteeResponse>
    {
        public static class Types
        {
            public class MediaFile : ChannelsECAftersaleMerchantUpdateAftersaleRequest.Types.__zz__MediaFile
            {
                public static class Types
                {
                    public class Picture : ChannelsECAftersaleMerchantUpdateAftersaleRequest.Types.MediaFile.Types.Picture
                    {
                    }

                    public class Video : ChannelsECAftersaleMerchantUpdateAftersaleRequest.Types.MediaFile.Types.Video
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
        }

        /// <summary>
        /// 获取或设置保障单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guarantee_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("guarantee_order_id")]
        public long GuaranteeOrderId { get; set; }

        /// <summary>
        /// 获取或设置拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 获取或设置拒绝凭证 MediaId 列表。
        /// </summary>
        [Obsolete("相关接口或字段于 2026-10-12 下线。")]
        [Newtonsoft.Json.JsonProperty("pic_list")]
        [System.Text.Json.Serialization.JsonPropertyName("pic_list")]
        public List<string>? PictureMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置拒绝凭证列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_files")]
        [System.Text.Json.Serialization.JsonPropertyName("media_files")]
        public List<Types.MediaFile>? MediaFileList { get; set; }
    }
}
