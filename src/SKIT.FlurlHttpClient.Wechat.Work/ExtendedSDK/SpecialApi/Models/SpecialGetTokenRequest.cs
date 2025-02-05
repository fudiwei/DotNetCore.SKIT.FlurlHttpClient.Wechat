using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /spec/gettoken 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-06-06 下线。")]
    public class SpecialGetTokenRequest : WechatWorkSpecialApiRequest
    {
        /// <summary>
        /// 获取或设置服务商 CorpId。如果不指定将使用构造 <see cref="WechatWorkSpecialApiClient"/> 时的 <see cref="WechatWorkSpecialApiClientOptions.ProviderCorpId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_id")]
        [System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? CorpId { get; set; }

        /// <summary>
        /// 获取或设置数据分析专区 Secret。如果不指定将使用构造 <see cref="WechatWorkSpecialApiClient"/> 时的 <see cref="WechatWorkSpecialApiClientOptions.SpecialSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secret")]
        [System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }
    }
}
