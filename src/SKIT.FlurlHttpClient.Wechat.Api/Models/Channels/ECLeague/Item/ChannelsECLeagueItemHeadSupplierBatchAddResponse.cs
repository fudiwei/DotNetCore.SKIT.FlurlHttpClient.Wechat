namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/headsupplier/batchadd 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueItemHeadSupplierBatchAddResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result : ChannelsECLeagueItemBatchAddResponse.Types.Result
            {
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("result_info_list")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
