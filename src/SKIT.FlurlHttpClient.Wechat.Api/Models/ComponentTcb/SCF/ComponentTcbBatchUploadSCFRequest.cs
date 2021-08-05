using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchuploadscf 接口的请求。</para>
    /// </summary>
    public class ComponentTcbBatchUploadSCFRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置函数名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("functionname")]
        [System.Text.Json.Serialization.JsonPropertyName("functionname")]
        public string FunctionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("envs")]
        [System.Text.Json.Serialization.JsonPropertyName("envs")]
        public IList<string> EnvironmentIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置包含函数代码文件的 zip 格式文件（需经过 Base64 编码）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zipfile")]
        [System.Text.Json.Serialization.JsonPropertyName("zipfile")]
        public string EncodingZipFile { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 VPC 唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vpcid")]
        [System.Text.Json.Serialization.JsonPropertyName("vpcid")]
        public string? VPCId { get; set; }

        /// <summary>
        /// 获取或设置子网 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subnetid")]
        [System.Text.Json.Serialization.JsonPropertyName("subnetid")]
        public string? SubnetId { get; set; }
    }
}
