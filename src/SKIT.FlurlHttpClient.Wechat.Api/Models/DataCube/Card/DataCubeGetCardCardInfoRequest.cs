namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getcardcardinfo 接口的请求。</para>
    /// </summary>
    public class DataCubeGetCardCardInfoRequest : DataCubeGetCardBusinessInfoRequest
    {
        /// <summary>
        /// 获取或设置卡券 Id。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }
    }
}
