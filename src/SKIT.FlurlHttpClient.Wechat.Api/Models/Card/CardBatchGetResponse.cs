namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/batchget 接口的响应。</para>
    /// </summary>
    public class CardBatchGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置卡券模板编号 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id_list")]
        public string[] CardIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡券总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
