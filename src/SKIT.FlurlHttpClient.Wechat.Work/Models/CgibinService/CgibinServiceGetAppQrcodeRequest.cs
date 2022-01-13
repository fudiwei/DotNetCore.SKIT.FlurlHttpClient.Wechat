namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_app_qrcode 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetAppQrcodeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置第三方应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置安装渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置二维码样式选项。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("style")]
        [System.Text.Json.Serialization.JsonPropertyName("style")]
        public int? Style { get; set; }

        /// <summary>
        /// 获取或设置结果返回方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_type")]
        [System.Text.Json.Serialization.JsonPropertyName("result_type")]
        public int? ResultType { get; set; }
    }
}
