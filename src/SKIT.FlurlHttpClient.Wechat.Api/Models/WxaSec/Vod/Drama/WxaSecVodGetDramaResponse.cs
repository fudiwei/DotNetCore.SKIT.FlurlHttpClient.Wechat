namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getdrama 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetDramaResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DramaInfo : WxaSecVodListDramasResponse.Types.DramaInfo
            {
                public static new class Types
                {
                    public class Media : WxaSecVodListDramasResponse.Types.DramaInfo.Types.Media
                    {
                    }

                    public class AuditDetail : WxaSecVodListDramasResponse.Types.DramaInfo.Types.AuditDetail
                    {
                    }
                }

                /// <summary>
                /// 获取或设置媒资文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_list")]
                [System.Text.Json.Serialization.JsonPropertyName("media_list")]
                public new Types.Media[] MediaList { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
                public new Types.AuditDetail? AuditDetail { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置剧目信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_info")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_info")]
        public Types.DramaInfo DramaInfo { get; set; } = default!;
    }
}
