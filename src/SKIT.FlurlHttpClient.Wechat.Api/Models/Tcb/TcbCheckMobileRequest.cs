namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/checkmobile 接口的请求。</para>
    /// </summary>
    public class TcbCheckMobileRequest : WechatApiRequest, IInferable<TcbCheckMobileRequest, TcbCheckMobileResponse>
    {
        /// <summary>
        /// 获取或设置是否在小程序未绑定手机号时推送模版消息给管理员收集手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("push_tmpl")]
        [System.Text.Json.Serialization.JsonPropertyName("push_tmpl")]
        public bool? RequestPushTemplateMessage { get; set; }
    }
}
