using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getuploadsignature 接口的请求。</para>
    /// </summary>
    public class TcbGetUploadSignatureRequest : WechatApiRequest, IMapResponse<TcbGetUploadSignatureRequest, TcbGetUploadSignatureResponse>
    {
        /// <summary>
        /// 获取或设置请求数据的签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hashed_payload")]
        [System.Text.Json.Serialization.JsonPropertyName("hashed_payload")]
        public string HashedPayload { get; set; } = string.Empty;
    }
}
