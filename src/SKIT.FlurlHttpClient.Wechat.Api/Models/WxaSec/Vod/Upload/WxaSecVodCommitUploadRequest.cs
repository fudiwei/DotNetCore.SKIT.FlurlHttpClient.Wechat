using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/commitupload 接口的请求。</para>
    /// </summary>
    public class WxaSecVodCommitUploadRequest : WechatApiRequest, IInferable<WxaSecVodCommitUploadRequest, WxaSecVodCommitUploadResponse>
    {
        public static class Types
        {
            public class PartInfo
            {
                /// <summary>
                /// 获取或设置分片编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("part_number")]
                [System.Text.Json.Serialization.JsonPropertyName("part_number")]
                public int PartNumber { get; set; }

                /// <summary>
                /// 获取或设置分片标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("etag")]
                [System.Text.Json.Serialization.JsonPropertyName("etag")]
                public string ETag { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置分片上传 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_id")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string UploadId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频文件分片信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_part_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("media_part_infos")]
        public IList<Types.PartInfo> MediaPartInfo { get; set; } = new List<Types.PartInfo>();

        /// <summary>
        /// 获取或设置视频封面图片文件分片信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_part_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_part_infos")]
        public IList<Types.PartInfo>? CoverPartInfo { get; set; }
    }
}
