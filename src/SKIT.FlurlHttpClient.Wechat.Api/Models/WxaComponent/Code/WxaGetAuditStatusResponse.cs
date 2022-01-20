namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/get_auditstatus 接口的响应。</para>
    /// </summary>
    public class WxaGetAuditStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置截图 MediaId 列表，使用竖线分隔。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("screenshot")]
        [System.Text.Json.Serialization.JsonPropertyName("screenshot")]
        public string? ScreenshotMediaIds { get; set; }
    }
}
