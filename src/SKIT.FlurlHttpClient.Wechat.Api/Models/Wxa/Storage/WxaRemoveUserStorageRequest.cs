using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/remove_user_storage 接口的请求。</para>
    /// </summary>
    public class WxaRemoveUserStorageRequest : WechatApiRequest, IMapResponse<WxaRemoveUserStorageRequest, WxaRemoveUserStorageResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户登录态签名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Signature { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户登录态签名的哈希方法。
        /// <para>默认值：hmac_sha256</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SignMethod { get; set; } = "hmac_sha256";

        /// <summary>
        /// 获取或设置要删除的数据 Key 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key")]
        [System.Text.Json.Serialization.JsonPropertyName("key")]
        public IList<string> KeyList { get; set; } = new List<string>();
    }
}
