namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/generatenfcscheme 接口的请求。</para>
    /// </summary>
    public class WxaGenerateNFCSchemeRequest : WechatApiRequest, IInferable<WxaGenerateNFCSchemeRequest, WxaGenerateNFCSchemeResponse>
    {
        public static class Types
        {
            public class MiniProgram : WxaGenerateSchemeRequest.Types.MiniProgram
            {
            }
        }

        /// <summary>
        /// 获取或设置跳转到的目标小程序信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jump_wxa")]
        [System.Text.Json.Serialization.JsonPropertyName("jump_wxa")]
        public Types.MiniProgram MiniProgram { get; set; } = new Types.MiniProgram();

        /// <summary>
        /// 获取或设置设备 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_id")]
        [System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sn")]
        [System.Text.Json.Serialization.JsonPropertyName("sn")]
        public string? SerialNumber { get; set; }
    }
}
