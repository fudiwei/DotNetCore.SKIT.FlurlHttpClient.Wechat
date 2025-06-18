using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/uploadauthmaterial 接口的请求。</para>
    /// </summary>
    public class WxaSecUploadAuthMaterialRequest : WechatApiRequest, IInferable<WxaSecUploadAuthMaterialRequest, WxaSecUploadAuthMaterialResponse>
    {
        /// <summary>
        /// 获取或设置文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();
    }
}
