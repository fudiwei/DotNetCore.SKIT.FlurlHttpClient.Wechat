using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /custom_audience_files/add 接口的请求。</para>
    /// </summary>
    public class CustomAudienceFilesAddRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置自定义人群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int CustomAudienceId { get; set; }

        /// <summary>
        /// 获取或设置用户 ID 类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UserIdType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OperationType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置压缩文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = new byte[0];
    }
}
