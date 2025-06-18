namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/addcheckinuserface 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinAddCheckinUserFaceRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置经过 Base64 编码的人脸图片数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userface")]
        [System.Text.Json.Serialization.JsonPropertyName("userface")]
        public string UserFaceImageData { get; set; } = string.Empty;
    }
}
