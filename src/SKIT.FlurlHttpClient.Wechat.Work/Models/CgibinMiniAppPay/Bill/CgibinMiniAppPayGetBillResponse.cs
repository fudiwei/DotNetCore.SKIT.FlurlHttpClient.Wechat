namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/miniapppay/get_bill 接口的响应。</para>
    /// </summary>
    public class CgibinMiniAppPayGetBillResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置哈希类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_type")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_type")]
        public string HashType { get; set; } = default!;

        /// <summary>
        /// 获取或设置哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_value")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_value")]
        public string HashValue { get; set; } = default!;

        /// <summary>
        /// 获取或设置账单下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置校验头。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth")]
        [System.Text.Json.Serialization.JsonPropertyName("auth")]
        public string Authorization { get; set; } = default!;
    }
}
