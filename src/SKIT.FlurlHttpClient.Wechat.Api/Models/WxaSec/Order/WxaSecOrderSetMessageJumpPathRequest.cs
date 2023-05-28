namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/set_msg_jump_path 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderSetMessageJumpPathRequest : WechatApiRequest, IInferable<WxaSecOrderSetMessageJumpPathRequest, WxaSecOrderSetMessageJumpPathResponse>
    {
        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string PagePath { get; set; } = string.Empty;
    }
}
