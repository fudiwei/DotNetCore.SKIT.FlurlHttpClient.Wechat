namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /new-tax-control-fapiao/fapiao-applications/upload-fapiao-file 接口的响应。</para>
    /// </summary>
    public class UploadNewTaxControlFapiaoApplicationFapiaoFileResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置发票文件 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_media_id")]
        public string FapiaoMediaId { get; set; } = default!;
    }
}
