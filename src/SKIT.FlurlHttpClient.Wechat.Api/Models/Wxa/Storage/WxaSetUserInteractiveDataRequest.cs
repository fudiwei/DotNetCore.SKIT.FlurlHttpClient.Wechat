using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/setuserinteractivedata 接口的请求。</para>
    /// </summary>
    public class WxaSetUserInteractiveDataRequest : WechatApiRequest, IInferable<WxaSetUserInteractiveDataRequest, WxaSetUserInteractiveDataResponse>
    {
        public static class Types
        {
            public class KeyValue
            {
                /// <summary>
                /// 获取或设置数据的 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置数据的值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public int Value { get; set; }
            }
        }

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
        /// <para>默认值："hmac_sha256"</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SignMethod { get; set; } = "hmac_sha256";

        /// <summary>
        /// 获取或设置要上报的数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kv_list")]
        [System.Text.Json.Serialization.JsonPropertyName("kv_list")]
        public IList<Types.KeyValue> KeyValueList { get; set; } = new List<Types.KeyValue>();
    }
}
