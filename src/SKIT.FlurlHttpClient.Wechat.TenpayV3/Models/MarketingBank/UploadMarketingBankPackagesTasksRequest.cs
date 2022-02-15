namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/bank/packages/{package_id}/tasks 接口的请求。</para>
    /// </summary>
    public class UploadMarketingBankPackagesTasksRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置号码包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PackageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务上传字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = new byte[0];

        /// <summary>
        /// 获取或设置任务上传文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filename")]
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置任务上传文件摘要。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sha256")]
        [System.Text.Json.Serialization.JsonPropertyName("sha256")]
        public string? FileHash { get; set; }

        /// <summary>
        /// 获取或设置任务上传文件 Conent-Type。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileContentType { get; set; }

        /// <summary>
        /// 获取或设置银行类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string? BankType { get; set; }
    }
}
