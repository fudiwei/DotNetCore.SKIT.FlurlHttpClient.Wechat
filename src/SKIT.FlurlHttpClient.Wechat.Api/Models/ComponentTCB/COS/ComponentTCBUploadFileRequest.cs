﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/uploadfile 接口的请求。</para>
    /// </summary>
    public class ComponentTCBUploadFileRequest : WechatApiRequest, IInferable<ComponentTCBUploadFileRequest, ComponentTCBUploadFileResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上传路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string Path { get; set; } = string.Empty;
    }
}
