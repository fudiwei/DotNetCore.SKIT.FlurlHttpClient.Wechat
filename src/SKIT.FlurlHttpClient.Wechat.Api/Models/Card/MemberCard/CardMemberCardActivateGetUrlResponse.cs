using System.Collections.ObjectModel;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/activate/geturl 接口的响应。</para>
    /// </summary>
    public class CardMemberCardActivateGetUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置开卡插件所需参数 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        public IDictionary<string, string> GetUrlParameters()
        {
            if (!Flurl.Url.IsValid(Url))
                throw new InvalidOperationException();

            Flurl.Url url = Flurl.Url.Parse(Url);
            return new ReadOnlyDictionary<string, string>(
                url.QueryParams.ToDictionary(k => k.Name, v => v.Name)
            );
        }
    }
}
