using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mch-manage/submission-files/sub-mchid/{sub_mchid}/upload 接口的请求。</para>
    /// </summary>
    public class UploadMerchantManageSubmissionFileRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置资料项 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_name")]
        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置文件摘要。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_digest")]
        [System.Text.Json.Serialization.JsonPropertyName("file_digest")]
        public string? FileHash { get; set; }

        /// <summary>
        /// 获取或设置文件 Conent-Type。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileContentType { get; set; }
    }
}
