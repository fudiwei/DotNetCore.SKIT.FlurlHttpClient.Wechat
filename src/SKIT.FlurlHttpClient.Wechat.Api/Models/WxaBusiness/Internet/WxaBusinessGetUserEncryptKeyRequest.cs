using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getuserencryptkey 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGetUserEncryptKeyRequest : WechatApiRequest, IMapResponse<WxaBusinessGetUserEncryptKeyRequest, WxaBusinessGetUserEncryptKeyResponse>
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用 SessionKey 对空字符串签名得到的结果。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Signature { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置签名方法。
        /// <para>默认值：hmac_sha256</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SignMethod { get; set; } = "hmac_sha256";
    }
}
