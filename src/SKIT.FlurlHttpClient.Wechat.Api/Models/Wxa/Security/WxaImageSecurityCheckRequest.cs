namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/img_sec_check 接口的请求。</para>
    /// </summary>
    public class WxaImageSecurityCheckRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置图片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = new byte[0];
    }
}
