using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /new-tax-control-fapiao/fapiao-applications/upload-fapiao-file 接口的请求。</para>
    /// </summary>
    public class UploadNewTaxControlFapiaoApplicationFapiaoFileRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置文件类型。
        /// <para>默认值："PDF"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_type")]
        [System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public string FileType { get; set; } = "PDF";

        /// <summary>
        /// 获取或设置文件内容哈希算法。
        /// <para>默认值："SM3"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("digest_alogrithm")]
        [System.Text.Json.Serialization.JsonPropertyName("digest_alogrithm")]
        public string FileHashAlgorithm { get; set; } = "SM3";

        /// <summary>
        /// 获取或设置文件内容哈希值。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("digest")]
        [System.Text.Json.Serialization.JsonPropertyName("digest")]
        public string? FileHash { get; set; }
    }
}
