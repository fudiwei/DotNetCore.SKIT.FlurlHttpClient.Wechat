namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getmedia 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetMediaResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MediaInfo : WxaSecVodListMediaResponse.Types.MediaInfo
            {
                public static new class Types
                {
                    public class AuditDetail : WxaSecVodListMediaResponse.Types.MediaInfo.Types.AuditDetail
                    {
                    }
                }

                /// <summary>
                /// 获取或设置审核详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
                public new Types.AuditDetail? AuditDetail { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置媒资信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_info")]
        [System.Text.Json.Serialization.JsonPropertyName("media_info")]
        public Types.MediaInfo MediaInfo { get; set; } = default!;
    }
}
