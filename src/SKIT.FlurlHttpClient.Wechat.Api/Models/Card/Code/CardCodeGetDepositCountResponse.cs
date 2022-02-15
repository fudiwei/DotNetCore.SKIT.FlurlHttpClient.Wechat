namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/code/getdepositcount 接口的响应。</para>
    /// </summary>
    public class CardCodeGetDepositCountResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置已经成功存入的卡券 Code 数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
