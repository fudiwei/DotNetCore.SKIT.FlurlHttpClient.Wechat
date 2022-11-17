﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getuploadsignature 接口的请求。</para>
    /// </summary>
    public class TCBGetUploadSignatureRequest : WechatApiRequest, IInferable<TCBGetUploadSignatureRequest, TCBGetUploadSignatureResponse>
    {
        /// <summary>
        /// 获取或设置请求数据的签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hashed_payload")]
        [System.Text.Json.Serialization.JsonPropertyName("hashed_payload")]
        public string HashedPayload { get; set; } = string.Empty;
    }
}
