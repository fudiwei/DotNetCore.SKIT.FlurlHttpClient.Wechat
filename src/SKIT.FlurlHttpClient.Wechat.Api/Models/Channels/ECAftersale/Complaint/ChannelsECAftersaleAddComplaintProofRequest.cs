namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/addcomplaintproof 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleAddComplaintProofRequest : WechatApiRequest, IInferable<ChannelsECAftersaleAddComplaintProofRequest, ChannelsECAftersaleAddComplaintProofResponse>
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
        /// 获取或设置纠纷单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_id")]
        public string? ComplaintId { get; set; }

        /// <summary>
        /// 获取或设置举证内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 获取或设置图片 MediaId 列表。
        /// </summary>
        [Obsolete("相关接口或字段于 2026-10-12 下线。")]
        [Newtonsoft.Json.JsonProperty("media_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id_list")]
        public List<string>? MediaIdList { get; set; }

        /// <summary>
        /// 获取或设置媒体文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_files")]
        [System.Text.Json.Serialization.JsonPropertyName("media_files")]
        public List<Types.MediaFile>? MediaFileList { get; set; }
    }
}
