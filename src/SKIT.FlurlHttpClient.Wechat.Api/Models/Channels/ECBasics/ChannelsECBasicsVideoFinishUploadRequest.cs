using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/video/finishupload 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsVideoFinishUploadRequest : WechatApiRequest, IInferable<ChannelsECBasicsVideoFinishUploadRequest, ChannelsECBasicsVideoFinishUploadResponse>
    {
        public static class Types
        {
            public class Part
            {
                /// <summary>
                /// 获取或设置块编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partnum")]
                [System.Text.Json.Serialization.JsonPropertyName("partnum")]
                public int PartNumber { get; set; }

                /// <summary>
                /// 获取或设置分片 SHA-1 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("part_sha")]
                [System.Text.Json.Serialization.JsonPropertyName("part_sha")]
                public string PartSha { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置文件上传标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_upload_key")]
        [System.Text.Json.Serialization.JsonPropertyName("video_upload_key")]
        public string VideoUploadKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上传场景类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_parts")]
        [System.Text.Json.Serialization.JsonPropertyName("finish_parts")]
        public IList<Types.Part> PartList { get; set; } = new List<Types.Part>();
    }
}
